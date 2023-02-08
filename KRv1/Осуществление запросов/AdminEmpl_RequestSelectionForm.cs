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
    public partial class AdminEmpl_RequestSelectionForm : Form
    {
        public AdminEmpl_RequestSelectionForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Осуществление_запросов.StreetRequestForm NewFrom = new Осуществление_запросов.StreetRequestForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Осуществление_запросов.HouseRequestForm NewFrom = new Осуществление_запросов.HouseRequestForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Осуществление_запросов.AdminEmpl_ApartRequestForm NewFrom = new Осуществление_запросов.AdminEmpl_ApartRequestForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Осуществление_запросов.PayerRequestForm NewFrom = new Осуществление_запросов.PayerRequestForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }
    }
}
