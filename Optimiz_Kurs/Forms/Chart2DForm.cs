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
    public partial class Chart2DForm : Form
    {
        public DataTable table;
        public Chart2DForm(DataTable table)
        {
            InitializeComponent();
            this.table = table;
            DrawChart();
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

      
    }
}
