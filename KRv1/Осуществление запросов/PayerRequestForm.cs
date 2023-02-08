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
    public partial class PayerRequestForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommand sqlCommand = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataReader Reader = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public PayerRequestForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Payer";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void PayerRequestForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Payer". При необходимости она может быть перемещена или удалена.
            this.payerTableAdapter1.Fill(this.kRv4DataSet.Payer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Payer". При необходимости она может быть перемещена или удалена.
            //this.payerTableAdapter.Fill(this.kRv1DataSet.Payer);

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
                string s1 = comboBox1.SelectedValue.ToString();
                selectQueryString = "SELECT IdConnection FROM ApartamentPayer WHERE IdApartament = " + s1;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("У данной квартиры нет плательщиков!");
                }
                else
                {
                    try
                    {
                        selectQueryString = "SELECT * FROM Payer WHERE IdPayer IN (SELECT IdPayer FROM ApartamentPayer WHERE IdApartament = " + s1 + ")";
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        bindingSource = new BindingSource();
                        bindingSource.DataSource = dataTable;
                        dataGridView1.DataSource = bindingSource;

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
