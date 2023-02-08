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

namespace KRv1.Формирование_отчетов
{
    public partial class AdminEmpl_ApartReportForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand sqlCommand = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataReader Reader = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public AdminEmpl_ApartReportForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void AdminEmpl_ApartReportForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            sqlConnection.Open();

            selectQueryString = "SELECT Apartament.IdApartament, CONCAT(Street.StName, ', дом ', House.HNumber, ', кв. ', Apartament.ApNumber) FROM (Street JOIN House ON Street.IdStreet = House.IdStreet) JOIN Apartament ON House.IdHouse = Apartament.IdHouse";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int v;
                string s = comboBox1.SelectedValue.ToString();

                selectQueryString = "SELECT COUNT(IdPayment) FROM Payment WHERE IdApartament = " + s;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                Reader = sqlCommand.ExecuteReader(); //ридер запроса
                Reader.Read(); // Чтение 1й строки запроса
                v = Reader.GetInt32(0);

                label2.Text = "Количество назначенных платежей: " + v.ToString();

                Reader.Close();

                if (v == 0)
                {
                    MessageBox.Show("У квартиры нет назначенных платежей!");
                    label3.Text = "Средняя стоимость коммунальных услуг за месяц: 0 руб.";
                    label4.Text = "Процент оплаты коммунальных платежей: 0";
                    label5.Text = "Общая сумма задолженностей: 0 руб.";

                }

                else
                {
                    selectQueryString = "SELECT Payment.IdPayment FROM (Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) WHERE Payment.IdApartament = " + s;
                    sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                    sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                    sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("У квартиры нет платажей или информации о платежах!");
                        label3.Text = "Средняя стоимость коммунальных услуг за месяц: 0 руб.";
                        label4.Text = "Процент оплаты коммунальных платежей: 0";
                        label5.Text = "Общая сумма задолженностей: 0 руб.";
                    }

                    else
                    {
                        selectQueryString = "SELECT SUM(PTotal)/COUNT(DISTINCT IdPaymentInfo) FROM (Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) WHERE Payment.IdApartament = " + s;
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        Reader = sqlCommand.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса

                        label3.Text = "Средняя стоимость коммунальных услуг за месяц: " + Reader.GetValue(0).ToString() + " руб.";

                        Reader.Close();
                                                
                        selectQueryString = "SELECT COUNT(PIStatus) FROM (Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) WHERE Payment.IdApartament = " + s;
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 0)
                        {
                            label4.Text = "Процент оплаты коммунальных платежей: 0";
                        }
                        else
                        {
                            int d1, d2;

                            Reader = sqlCommand.ExecuteReader(); //ридер запроса
                            Reader.Read(); // Чтение 1й строки запроса                

                            d1 = Reader.GetInt32(0);

                            Reader.Close();

                            selectQueryString = "SELECT COUNT(PIStatus) FROM (Payment JOIN PaymentInfo ON Payment.IdApartament = PaymentInfo.IdApartament AND Payment.PPeriod = PaymentInfo.PIPeriod) WHERE PIStatus = 'P' AND Payment.IdApartament = " + s;
                            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                            sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                            dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);

                            Reader = sqlCommand.ExecuteReader(); //ридер запроса
                            Reader.Read(); // Чтение 1й строки запроса

                            d2 = Reader.GetInt32(0);

                            Reader.Close();

                            label4.Text = "Процент оплаты коммунальных платежей: " + ((Math.Round((double)d2 / d1, 2)) * 100).ToString() + "%";
                        }

                        selectQueryString = "SELECT SUM(PTotal) FROM Payment WHERE IdApartament = " + s + " AND PPeriod IN (SELECT PIPeriod FROM PaymentInfo WHERE PaymentInfo.IdApartament = " + s + " AND PIStatus = 'C')";
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommand = new SqlCommand(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        Reader = sqlCommand.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса
                        
                        try
                        {
                            label5.Text = "Общая сумма задолженностей: " + Reader.GetDouble(0).ToString() + " руб.";
                        }
                        catch
                        {
                            label5.Text = "Общая сумма задолженностей: 0 руб.";
                        }
                        
                        Reader.Close();
                        MessageBox.Show("Отчет составлен!");
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
