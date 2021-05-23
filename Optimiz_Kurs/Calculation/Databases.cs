using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimiz_Kurs.Calculation
{
    class Databases
    {
        public void AddTask(int Variant, string Function, string TaskText, double MinT1, double MaxT1, double MinT2, double MaxT2, string ConditionSecType, double Accuracy)
        {
            using (TaskContext db = new TaskContext()) 
            {
                try {
                    Task task = new Task() { Id = Variant, Variant = Variant, Function = Function, TaskText = TaskText, MinT1 = MinT1, MaxT1 = MaxT1, MinT2 = MinT2, MaxT2 = MaxT2, ConditionsSecType = ConditionSecType, Accuracy = Accuracy };
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    MessageBox.Show("Успешно сохранено");

           
                    db.SaveChanges();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
            }
        }

        public void AddAccount(string Login, string Password, string Name, string Role)
        {
            using (AccountContext db = new AccountContext())
            {
                try
                {
                    Account account = new Account() { Id = 1, Login = Login, Password = Password, Name = Name, Role = Role};
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    MessageBox.Show("Успешно сохранено");


                    db.SaveChanges();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");
                }
            }
        }

    }


    public class TaskContext : DbContext 
    {
        public TaskContext()
            : base("DBConnection") 
        { }

        public DbSet<Task> Tasks { get; set; } 
    }

    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("DBConnection")
        { }

        public DbSet<Account> Accounts { get; set; }
    }


    public class Task
    {
        public int Id { get; set; } 
        public int Variant { get; set; }
        public string Function { get; set; }
        public string TaskText { get; set; }
        public double MinT1 { get; set; }
        public double MaxT1 { get; set; }
        public double MinT2 { get; set; }
        public double MaxT2 { get; set; }
        public string ConditionsSecType { get; set; }
        public double Accuracy { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
