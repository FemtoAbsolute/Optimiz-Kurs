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
    public partial class AdminForm : Form
    {
        public string name;
        public AdminForm(string name)
        {
            InitializeComponent();
            this.name = name;
            label1.Text = "С возвращением, " + name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  

        private void AddUsersButton_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
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

        private void OpenResearchForm_Click(object sender, EventArgs e)
        {
            ResearchForm form = new ResearchForm(name);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
