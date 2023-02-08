using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRv1.Формирование_отчетов
{
    public partial class AdminEmpl_ReportSelectionForm : Form
    {
        public AdminEmpl_ReportSelectionForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Формирование_отчетов.StreetReportForm NewFrom = new Формирование_отчетов.StreetReportForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Формирование_отчетов.HouseReportForm NewFrom = new Формирование_отчетов.HouseReportForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Формирование_отчетов.AdminEmpl_ApartReportForm NewFrom = new Формирование_отчетов.AdminEmpl_ApartReportForm();
            //conn.Close();
            NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }
    }
}
