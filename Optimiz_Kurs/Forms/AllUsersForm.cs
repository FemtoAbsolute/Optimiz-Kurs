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
    public partial class AllUsersForm : Form
    {
        public AllUsersForm()
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

            using (Calculation.AccountContext db = new Calculation.AccountContext())
            {
                try
                {
                    var accs = db.Accounts; 

                    foreach (var tk in accs)
                    {
                        dataGridView1.Rows.Add(tk.Id, tk.Name, tk.Login, tk.Password, tk.Role);
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
                    using (Calculation.AccountContext db = new Calculation.AccountContext())
                    {

                        string temp = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        var accs = db.Accounts.Where(p => p.Login.ToString() == temp);



                        db.Accounts.Remove(accs.FirstOrDefault());

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

