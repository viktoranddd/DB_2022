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

namespace KRv1.Осуществление_запросов
{
    public partial class StreetRequestForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand sqlCommand = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataReader Reader = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public StreetRequestForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Apartament WHERE IdApartament IN (SELECT IdApartament FROM PaymentInfo WHERE PIStatus = 'C')";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
                        
            InitializeComponent();
        }

        private void StreetRequestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter1.Fill(this.kRv4DataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Apartament". При необходимости она может быть перемещена или удалена.
            this.apartamentTableAdapter1.Fill(this.kRv4DataSet.Apartament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.House". При необходимости она может быть перемещена или удалена.
            //this.houseTableAdapter.Fill(this.kRv1DataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Apartament". При необходимости она может быть перемещена или удалена.
            //this.apartamentTableAdapter.Fill(this.kRv1DataSet.Apartament);

            selectQueryString = "SELECT IdStreet, StName FROM Street";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();

            selectQueryString = "SELECT SUM(PTotal) FROM Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod WHERE PIStatus = 'C'";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            Reader = sqlCommand.ExecuteReader(); //ридер запроса
            Reader.Read(); // Чтение 1й строки запроса

            try
            {
                label3.Text = "Общая сумма долга: " + Reader.GetDouble(0).ToString() + " руб.";
            }
            catch
            {
                label3.Text = "Общая сумма долга: 0 руб.";
            }

            Reader.Close(); 
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
                selectQueryString = "SELECT DISTINCT(House.IdHouse) FROM (Apartament JOIN PaymentInfo ON Apartament.IdApartament = PaymentInfo.IdApartament) JOIN House ON Apartament.IdHouse = House.IdHouse WHERE House.IdStreet = " + s1 + " AND PIStatus = 'C'";
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("У данной улицы нет задолженностей!");
                }
                else
                {
                    try
                    {
                        selectQueryString = "SELECT * FROM Apartament WHERE IdApartament IN (SELECT DISTINCT(Apartament.IdApartament) FROM ((Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) JOIN Apartament ON Payment.IdApartament = Apartament.IdApartament) JOIN House ON Apartament.IdHouse = House.IdHouse WHERE House.IdStreet = " + s1 + " AND PIStatus = 'C')";
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        bindingSource = new BindingSource();
                        bindingSource.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource;

                        selectQueryString = "SELECT SUM(PTotal) FROM Payment WHERE IdApartament IN (SELECT DISTINCT(Apartament.IdApartament) FROM ((Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) JOIN Apartament ON Payment.IdApartament = Apartament.IdApartament) JOIN House ON Apartament.IdHouse = House.IdHouse WHERE House.IdStreet = " + s1 + " AND PIStatus = 'C')";
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        Reader = sqlCommand.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса

                        try
                        {
                            label3.Text = "Общая сумма долга: " + Reader.GetDouble(0).ToString() + " руб.";
                        }
                        catch
                        {
                            label3.Text = "Общая сумма долга: 0 руб.";
                        }

                        Reader.Close();
                        MessageBox.Show("Запрос выполнен!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Выполнить запрос не удалось!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!");
            }
        }
    }
}
