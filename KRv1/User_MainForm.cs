using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRv1
{
    public partial class User_MainForm : Form
    {
        String Id, Surname, Name;

        private void button2_Click(object sender, EventArgs e)
        {
            Осуществление_запросов.User_ApartRequestForm NewFrom = new Осуществление_запросов.User_ApartRequestForm(Id);
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Формирование_отчетов.User_ApartReportForm NewFrom = new Формирование_отчетов.User_ApartReportForm(Id);
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        public User_MainForm(String Id1, String Surname1, String Name1)
        {
            InitializeComponent();
            Id = Id1;
            Surname = Surname1;
            Name = Name1;
        }

        private void User_MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Пользователь: " + Name + " " + Surname;
        }
    }
}
