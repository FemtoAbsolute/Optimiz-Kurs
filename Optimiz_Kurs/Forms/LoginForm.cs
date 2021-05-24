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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (Calculation.AccountContext dbase = new Calculation.AccountContext())
            {
                string login = LoginTextbox.Text;
                string password = PasswordTextbox.Text;
                var accs = dbase.Accounts.Where(p => p.Login.ToString() == login && p.Password.ToString() == password);
                if (accs.Count() == 0)
                {
                    MessageBox.Show("Пользователя не существует или данные введены неверно");
                }
                else
                if (accs.FirstOrDefault().Role == "Администратор")
                {
                    AdminForm form = new AdminForm(accs.FirstOrDefault().Name);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    ResearchForm form = new ResearchForm(accs.FirstOrDefault().Name);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
               

            }
        }

    }
}
