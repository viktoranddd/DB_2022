using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KRv1
{
    public partial class Kvit : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand sqlCommand = null; 
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataReader Reader = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public Kvit()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Payment";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            //dataGridView1.DataSource = bindingSource;

            InitializeComponent();   
        }

        private void Kvit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.PaymentType". При необходимости она может быть перемещена или удалена.
            this.paymentTypeTableAdapter1.Fill(this.kRv4DataSet.PaymentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter1.Fill(this.kRv4DataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.PaymentType". При необходимости она может быть перемещена или удалена.
            //this.paymentTypeTableAdapter.Fill(this.kRv1DataSet.PaymentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Payment". При необходимости она может быть перемещена или удалена.
            //this.paymentTableAdapter.Fill(this.kRv1DataSet.Payment);

            selectQueryString = "SELECT Apartament.IdApartament, CONCAT(Street.StName, ', дом ', House.HNumber, ', кв. ', Apartament.ApNumber) FROM (Street JOIN House ON Street.IdStreet = House.IdStreet) JOIN Apartament ON House.IdHouse = Apartament.IdHouse";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s1 = comboBox1.SelectedValue.ToString();
                string s2;
                if (maskedTextBox1.TextLength == 0) { s2 = "IS NULL"; }
                else s2 = "= '01." + maskedTextBox1.Text.ToString() + "'";
                //MessageBox.Show(s2);
                selectQueryString = "SELECT IdApartament FROM PaymentInfo WHERE IdApartament = " + s1 + " AND PIPeriod " + s2 + " AND PIStatus = 'C'";
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Для выбранной квартиры нет неоплаченных платежей за выбранный месяц!");
                }
                else
                {
                    try
                    {
                        string dop;

                        selectQueryString = "SELECT * FROM Payment WHERE IdApartament = " + s1 + " AND PPeriod " + s2;
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        bindingSource = new BindingSource();
                        bindingSource.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource;

                        label1.Text = "Количество платежей: " + dataTable.Rows.Count;

                        selectQueryString = "SELECT SUM(PAccural), SUM(PBenefit), SUM(PTotal) FROM Payment WHERE IdApartament = " + s1 + " AND PPeriod " + s2;
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        //MessageBox.Show("ТЕСТ");
                        Reader = sqlCommand.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса
                        //MessageBox.Show("ТЕСТ2");
                        //MessageBox.Show(Reader.GetDouble(0).ToString());
                        //MessageBox.Show("ТЕСТ3");

                        if (Reader.GetDouble(0) == Reader.GetDouble(2)) { dop = "0"; }
                        else dop = Reader.GetDouble(1).ToString();

                        label3.Text = "Подитог: " + Reader.GetDouble(0).ToString() + " руб.";
                        label4.Text = "Льгота: " + dop + " руб.";
                        label5.Text = "Итог: " + Reader.GetDouble(2).ToString() + " руб.";

                        Reader.Close();
                        MessageBox.Show("Квитанция составлена!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Составить квитанцию не удалось!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоррекнтый ввод данных!");
            }
        }
    }
}
