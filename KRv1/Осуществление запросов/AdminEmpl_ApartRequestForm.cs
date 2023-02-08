﻿using System;
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
    public partial class AdminEmpl_ApartRequestForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand sqlCommand = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataReader Reader = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public AdminEmpl_ApartRequestForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Payment WHERE IdPayment IN (SELECT IdPayment FROM Payment JOIN PaymentInfo ON Payment.PPeriod = PaymentInfo.PIPeriod AND Payment.IdApartament = PaymentInfo.IdApartament WHERE PIStatus = 'C')";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            InitializeComponent();
        }

        private void AdminEmpl_ApartRequestForm_Load(object sender, EventArgs e)
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
                selectQueryString = "SELECT IdPaymentInfo FROM PaymentInfo WHERE PaymentInfo.IdApartament = " + s1 + " AND PIStatus = 'C'";
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("У данной квартиры нет задолженностей!");
                }
                else
                {
                    try
                    {
                        selectQueryString = "SELECT * FROM Payment WHERE IdApartament = " + s1 + " AND PPeriod IN (SELECT PIPeriod FROM PaymentInfo WHERE PaymentInfo.IdApartament = " + s1 + " AND PIStatus = 'C')";
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        bindingSource = new BindingSource();
                        bindingSource.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource;

                        selectQueryString = "SELECT SUM(PTotal) FROM Payment WHERE IdApartament = " + s1 + " AND PPeriod IN (SELECT PIPeriod FROM PaymentInfo WHERE PaymentInfo.IdApartament = " + s1 + " AND PIStatus = 'C')";
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
