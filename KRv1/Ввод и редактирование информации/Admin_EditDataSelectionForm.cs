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
    public partial class Admin_EditDataSelectionForm : Form
    {
        public Admin_EditDataSelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditStreetForm NewFrom = new EditStreetForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void Admin_EditDataSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HouseEditForm NewFrom = new HouseEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApartEditForm NewFrom = new ApartEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayerEditForm NewFrom = new PayerEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PTypeEditForm NewFrom = new PTypeEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PaymentEditForm NewFrom = new PaymentEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PInfoEditForm NewFrom = new PInfoEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ApartamentPayerEditForm NewFrom = new ApartamentPayerEditForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }
    }
}
