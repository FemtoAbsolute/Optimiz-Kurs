using DynamicExpresso;
using Optimiz_Kurs.Calculation;
using Optimiz_Kurs.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimiz_Kurs
{
    public partial class ResearchForm : Form
    {
        public string name;
        public Func<Dictionary<string, double>, double> func;
        public Func<double, double, bool> conditionsSecType;

        public ResearchForm(string name)
        {
            InitializeComponent();
            this.name = name;
            label1.Text = "С возвращением, " + name;
            LoadVariants();
        }

        public class Point
        {
            public double x { get; set; }
            public double y { get; set; }

            public Point() { }

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

            private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        void LoadVariants()
        {
            using (TaskContext dbase = new TaskContext())
            {
                var task = dbase.Tasks;
                foreach (var variants in task)
                    VariantCombobox.Items.Add(variants.Variant);
            }
        }

        private void VariantChanged(object sender, EventArgs e)
        {
            using (TaskContext dbase = new TaskContext())
            {
                string variant = VariantCombobox.SelectedItem.ToString();
                var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                TaskTextTextbox.Text = task.FirstOrDefault().TaskText;
                FunctionTextbox.Text = task.FirstOrDefault().Function;
                MinT1Textbox.Text = task.FirstOrDefault().MinT1.ToString();
                MaxT1Textbox.Text = task.FirstOrDefault().MaxT1.ToString();
                MinT2Textbox.Text = task.FirstOrDefault().MinT2.ToString();
                MaxT2Textbox.Text = task.FirstOrDefault().MaxT2.ToString();
                SecondTypeTextbox.Text = task.FirstOrDefault().ConditionsSecType;
                AccuracyNumeric.Value = (decimal)task.FirstOrDefault().Accuracy;

                var calcs = new Sprache.Calc.XtensibleCalculator();
                var expr = calcs.ParseFunction(FunctionTextbox.Text);
                func = expr.Compile();
                conditionsSecType = new Interpreter().ParseAsDelegate<Func<double, double, bool>>(SecondTypeTextbox.Text, new string[] { "T1", "T2" });
            }
        }
        DataTable table = new DataTable();
        Point[] complex = new Point[4];
        Random Random = new Random();

        void ComplexGenerator()
        {
            double gx, gy, hx, hy;
            using (TaskContext dbase = new TaskContext())
            {
                string variant = VariantCombobox.SelectedItem.ToString();
                var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                gx = task.FirstOrDefault().MinT1;
                gy = task.FirstOrDefault().MinT2;
                hx = task.FirstOrDefault().MaxT1;
                hy = task.FirstOrDefault().MaxT2;
            }
            int P = 0;
            double validXSum = 0;
            double validYSum = 0;
            while (P == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    complex[i] = new Point();
                    complex[i].x = gx + Random.NextDouble() * (hx - gx);
                    complex[i].y = gy + Random.NextDouble() * (hy - gy);
                    if (conditionsSecType(complex[i].x, complex[i].y))
                    {
                        P++;
                        validXSum += complex[i].x;
                        validYSum += complex[i].y;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                while (!conditionsSecType(complex[i].x, complex[i].y))
                {
                    complex[i].x = (complex[i].x + validXSum / 2) / 2;
                    complex[i].y = (complex[i].y + validYSum / 2) / 2;
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try {
                var calcs = new Sprache.Calc.XtensibleCalculator();
                var expr = calcs.ParseFunction(FunctionTextbox.Text);
                func = expr.Compile();
                conditionsSecType = new Interpreter().ParseAsDelegate<Func<double, double, bool>>(SecondTypeTextbox.Text, new string[] { "T1", "T2" });

                if (MethodCombobox.SelectedItem == null)
                    MessageBox.Show("Вы не выбрали вариант или метод решения");
                else if (MethodCombobox.SelectedItem.ToString() == "Метод Сканирования")
                {
                    using (TaskContext dbase = new TaskContext())
                    {                        
                        string variant = VariantCombobox.SelectedItem.ToString();
                        var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                        Calculations calc = new Calculations();
                        table = calc.Calculate(task.FirstOrDefault().MinT1, task.FirstOrDefault().MinT2, task.FirstOrDefault().MaxT1, task.FirstOrDefault().MaxT2, func, conditionsSecType, task.FirstOrDefault().Accuracy);
                        dataGridView1.DataSource = table;

                        if(radioButton1.Checked)
                            dataGridView1.Sort(dataGridView1.Columns["Value"], ListSortDirection.Ascending);
                        else
                            dataGridView1.Sort(dataGridView1.Columns["Value"], ListSortDirection.Descending);
                        ResultLabel.Text = $"Оптимальное значение целевой функции {dataGridView1.Rows[0].Cells[2].Value} достигается при T1 = {dataGridView1.Rows[0].Cells[0].Value} и T2 = { dataGridView1.Rows[0].Cells[1].Value}";
                    }
                }
                else if (MethodCombobox.SelectedItem.ToString() == "Комплексный метод Бокса")
                {
                    double epsilon = 0.1;
                    double B = 0;
                    double gx, gy, hx, hy;
                    Point result;
                    DataTable table = new DataTable();
                    table.Columns.Add("T1", typeof(double));
                    table.Columns.Add("T2", typeof(double));
                    table.Columns.Add("Value", typeof(double));

                    using (TaskContext dbase = new TaskContext())
                    {
                        string variant = VariantCombobox.SelectedItem.ToString();
                        var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                        gx = task.FirstOrDefault().MinT1;
                        gy = task.FirstOrDefault().MinT2;
                        hx = task.FirstOrDefault().MaxT1;
                        hy = task.FirstOrDefault().MaxT2;
                        epsilon = task.FirstOrDefault().Accuracy;
                    }
                    ComplexGenerator();
                    do
                    {
                        int bestIndex = 0;
                        int worstIndex = 0;

                        for (int i = 1; i < 4; i++)
                        {
                            if (func(new Dictionary<string, double>() { { "T1", complex[bestIndex].x }, { "T2", complex[bestIndex].y } }) < func(new Dictionary<string, double>() { { "T1", complex[i].x }, { "T2", complex[i].y } }))
                                bestIndex = i;
                            else if (func(new Dictionary<string, double>() { { "T1", complex[worstIndex].x }, { "T2", complex[worstIndex].y } }) > func(new Dictionary<string, double>() { { "T1", complex[i].x }, { "T2", complex[i].y } }))
                                worstIndex = i;
                        }
                        if (radioButton1.Checked)
                        {
                            int temp = bestIndex;
                            bestIndex = worstIndex;
                            worstIndex = temp;
                        }

                        Point C = new Point();
                        C.x = (complex.Sum(value => value.x) - complex[worstIndex].x) / 3;
                        C.y = (complex.Sum(value => value.y) - complex[worstIndex].y) / 3;

                        B = (Math.Abs(C.x - complex[worstIndex].x) + Math.Abs(C.x - complex[bestIndex].x) + Math.Abs(C.y - complex[worstIndex].y) + Math.Abs(C.y - complex[bestIndex].y)) / 4;

                        Point newPoint = new Point();
                        int newPointIndex = worstIndex;
                        if (B > epsilon)
                        {
                            newPoint.x = 2.3 * C.x - 1.3 * complex[worstIndex].x;
                            newPoint.y = 2.3 * C.y - 1.3 * complex[worstIndex].y;

                            if (newPoint.x < gx)
                                newPoint.x = gx + epsilon;
                            else if (newPoint.x > hx)
                                newPoint.x = hx - epsilon;

                            if (newPoint.y < gy)
                                newPoint.y = gy + epsilon;
                            else if (newPoint.y > hy)
                                newPoint.y = hy - epsilon;

                            while (!conditionsSecType(newPoint.x, newPoint.y))
                            {
                                newPoint.x = (newPoint.x + C.x) / 2;
                                newPoint.y = (newPoint.y + C.y) / 2;
                            }
                            if (radioButton1.Checked)
                                while (func(new Dictionary<string, double>() { { "T1", newPoint.x }, { "T2", newPoint.y } }) > func(new Dictionary<string, double>() { { "T1", complex[worstIndex].x }, { "T2", complex[worstIndex].y } }))
                                {
                                    newPoint.x = (newPoint.x + complex[bestIndex].x) / 2;
                                    newPoint.y = (newPoint.y + complex[bestIndex].y) / 2;
                                }
                            else
                                while (func(new Dictionary<string, double>() { { "T1", newPoint.x }, { "T2", newPoint.y } }) < func(new Dictionary<string, double>() { { "T1", complex[worstIndex].x }, { "T2", complex[worstIndex].y } }))
                                {
                                    newPoint.x = (newPoint.x + complex[bestIndex].x) / 2;
                                    newPoint.y = (newPoint.y + complex[bestIndex].y) / 2;
                                }
                            complex[worstIndex] = newPoint;
                        }
                        result = complex[bestIndex];
                        table.Rows.Add(Math.Round(complex[bestIndex].x, 3), Math.Round(complex[bestIndex].y, 3), Math.Round(func(new Dictionary<string, double>() { { "T1", complex[bestIndex].x }, { "T2", complex[bestIndex].y } }), 3));
                    } while (B > epsilon);                    
                    ResultLabel.Text = $"Оптимальное значение целевой функции {Math.Round(func(new Dictionary<string, double>() { { "T1", result.x }, { "T2", result.y } }), 3)} достигается при T1 = { Math.Round(result.x, 3) } и T2 = { Math.Round(result.y, 3) }";
                    dataGridView1.DataSource = table;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Build2DChartButton_Click(object sender, EventArgs e)
        {
            var calcs = new Sprache.Calc.XtensibleCalculator();
            var expr = calcs.ParseFunction(FunctionTextbox.Text);
            func = expr.Compile();
            conditionsSecType = new Interpreter().ParseAsDelegate<Func<double, double, bool>>(SecondTypeTextbox.Text, new string[] { "T1", "T2" });
            Chart2DForm form = null;
            using (TaskContext dbase = new TaskContext())
            {
                string variant = VariantCombobox.SelectedItem.ToString();
                var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                form = new Chart2DForm(func, conditionsSecType, task.FirstOrDefault().MinT1, task.FirstOrDefault().MinT2, task.FirstOrDefault().MaxT1, task.FirstOrDefault().MaxT2);
            }

            Hide();
            form.ShowDialog();
            Show();
        }

        private void Build3DChartButton_Click(object sender, EventArgs e)
        {
            double gx, gy, hx, hy;
            using (TaskContext dbase = new TaskContext())
            {
                string variant = VariantCombobox.SelectedItem.ToString();
                var task = dbase.Tasks.Where(p => p.Variant.ToString() == variant);
                gx = task.FirstOrDefault().MinT1;
                gy = task.FirstOrDefault().MinT2;
                hx = task.FirstOrDefault().MaxT1;
                hy = task.FirstOrDefault().MaxT2;
            }
            Hide();
            new Chart3DForm(func, gx, gy, hx, hy).ShowDialog();
            Show();
        }
    }
       
}
