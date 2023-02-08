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
    public partial class Employee_MainForm : Form
    {
        public Employee_MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentEditForm NewFrom = new PaymentEditForm();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kvit NewFrom = new Kvit();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEmpl_RequestSelectionForm NewFrom = new AdminEmpl_RequestSelectionForm();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Формирование_отчетов.AdminEmpl_ReportSelectionForm NewFrom = new Формирование_отчетов.AdminEmpl_ReportSelectionForm();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }
    }
}
