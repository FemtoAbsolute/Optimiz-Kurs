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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
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

   

        private void AllTasksButton_Click(object sender, EventArgs e)
        {
            AllTasksForm form = new AllTasksForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            
        }

        private void AddUsersButton_Click(object sender, EventArgs e)
        {
            AddTaskForm form = new AddTaskForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void AddTasksButton_Click(object sender, EventArgs e)
        {
            AddTaskForm form = new AddTaskForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            using (Calculation.AccountContext dbase = new Calculation.AccountContext())
            {
                string value = LoginTextbox.Text;
                var accs = dbase.Accounts.Where(p => p.Login.ToString() == value);
                if (accs.Count() == 0)
                {
                    Calculation.Databases db = new Calculation.Databases();
                    db.AddAccount(LoginTextbox.Text, PasswordTextbox.Text, NameTextbox.Text, RoleCombobox.SelectedItem.ToString());
                }
                else
                    if (MessageBox.Show("Такой пользователь уже существует. Выберите Да, если хотите перезаписать данные о пользователе.", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    accs.FirstOrDefault().Login = LoginTextbox.Text;
                    accs.FirstOrDefault().Password = PasswordTextbox.Text;
                    accs.FirstOrDefault().Name = NameTextbox.Text;
                    accs.FirstOrDefault().Role = RoleCombobox.SelectedItem.ToString();
                }
                dbase.SaveChanges();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllUsersForm form = new AllUsersForm();
            this.Close();
            form.ShowDialog();
            this.Show();
        }
    }
}
