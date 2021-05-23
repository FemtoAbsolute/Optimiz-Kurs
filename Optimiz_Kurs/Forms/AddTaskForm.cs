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
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
       
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            using (Calculation.TaskContext dbase = new Calculation.TaskContext())
            {
                string value = VariantComboBox.Value.ToString();
                var tasks = dbase.Tasks.Where(p => p.Variant.ToString() == value);
                if (tasks.Count() == 0)
                {
                    Calculation.Databases db = new Calculation.Databases();
                    db.AddTask((int)VariantComboBox.Value, FunctionTextbox.Text, TaskTextTextbox.Text, (double)MinT1Numeric.Value, (double)MaxT1Numeric.Value, (double)MinT2Numeric.Value, (double)MaxT2Numeric.Value, SecondTypeTextbox.Text, (double)AccuracyNumeric.Value);
                }
                else
                    if (MessageBox.Show("Такой вариант уже существует. Выберите Да, если хотите перезаписать задачу.", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tasks.FirstOrDefault().Variant = (int)VariantComboBox.Value;
                        tasks.FirstOrDefault().Function = FunctionTextbox.Text;
                        tasks.FirstOrDefault().TaskText = TaskTextTextbox.Text;
                        tasks.FirstOrDefault().MinT1 = (double)MinT1Numeric.Value;
                        tasks.FirstOrDefault().MaxT1 = (double)MaxT1Numeric.Value;
                        tasks.FirstOrDefault().MinT2 = (double)MinT2Numeric.Value;
                        tasks.FirstOrDefault().MaxT2 = (double)MaxT2Numeric.Value;
                        tasks.FirstOrDefault().ConditionsSecType = SecondTypeTextbox.Text;
                        tasks.FirstOrDefault().Accuracy = (double)AccuracyNumeric.Value;
                    }
                dbase.SaveChanges();
                               
            }

        }

        private void AllTasksButton_Click(object sender, EventArgs e)
        {
            AllTasksForm form = new AllTasksForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            
        }
    }
}
