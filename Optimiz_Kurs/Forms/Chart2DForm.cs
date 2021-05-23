using System;
using System.Data;
using System.Windows.Forms;
using Optimiz_Kurs.Calculation;

namespace Optimiz_Kurs
{
    public partial class Chart2DForm : Form
    {
        public DataTable table;
        public Chart2DForm(DataTable table)
        {
            InitializeComponent();
            this.table = table;
            DrawChart();
        }

        public Chart2DForm(int funcNum, double minT1, double minT2, double maxT1, double maxT2)
        {
            InitializeComponent();
            DrawChart(funcNum, minT1, minT2, maxT1, maxT2);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void DrawChart()
        {
            for(int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 50)
                {
                    chart1.Series[0].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 250)
                {
                    chart1.Series[1].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 500)
                {
                    chart1.Series[2].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 1000)
                {
                    chart1.Series[3].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 2000)
                {
                    chart1.Series[4].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 3000)
                {
                    chart1.Series[5].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
                if (Convert.ToDouble(table.Rows[i].ItemArray[2].ToString()) == 5000)
                {
                    chart1.Series[6].Points.AddXY(table.Rows[i].ItemArray[0], table.Rows[i].ItemArray[1]);
                }
            }
        }

        public void DrawChart(int funcNum, double minT1, double minT2, double maxT1, double maxT2)
        {
            if(funcNum == 0)
            {
                for (double x = minT1; x <= maxT1; x += 0.01)
                {
                    for (double y = minT2; y <= maxT2; y += 0.01)
                    {
                        if (!(x + y/2 <= 1))
                            continue;

                        double S = Functions.f0(x, y);
                        S = S >= 1000 ? Math.Round(S / 100, 0) * 100 : Math.Round(S / 10, 0) * 10;
                        
                        if (S == 50)
                        {
                            chart1.Series[0].Points.AddXY(x, y);
                        }
                        else if (S == 250)
                        {
                            chart1.Series[1].Points.AddXY(x, y);
                        }
                        else if(S == 500)
                        {
                            chart1.Series[2].Points.AddXY(x, y);
                        }
                        else if(S == 1000)
                        {
                            chart1.Series[3].Points.AddXY(x, y);
                        }
                        else if(S == 2000)
                        {
                            chart1.Series[4].Points.AddXY(x, y);
                        }
                        else if(S == 3000)
                        {
                            chart1.Series[5].Points.AddXY(x, y);
                        }
                        else if(S == 5000)
                        {
                            chart1.Series[6].Points.AddXY(x, y);
                        }
                    }
                }
            }
            else if (funcNum == 1)
            {

            }
        }
    }
}
