using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimiz_Kurs
{
    public partial class AllTasksForm : Form
    {
        public AllTasksForm()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void UpdateTable()
        {
            dataGridView1.Rows.Clear();

            using (Calculation.TaskContext db = new Calculation.TaskContext())
            {
                try
                {
                    var tasks = db.Tasks; 

                    foreach (var tk in tasks)
                    {
                        dataGridView1.Rows.Add(tk.Id, tk.Variant, tk.Function, tk.TaskText, tk.MinT1, tk.MaxT1, tk.MinT2, tk.MaxT2, tk.ConditionsSecType, tk.Accuracy);
                    }
                    dataGridView1.Columns[0].Visible = false;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так");
                }

            }
 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 1)
            if (MessageBox.Show("Вы уверены, что хотите удалить запись? Действие отменить невозможно.", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (Calculation.TaskContext db = new Calculation.TaskContext())
                    {

                        string temp = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        var tasks = db.Tasks.Where(p => p.Variant.ToString() == temp);



                        db.Tasks.Remove(tasks.FirstOrDefault());

                        db.SaveChanges();
                        UpdateTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так");
                }
         }
        
    }
}

