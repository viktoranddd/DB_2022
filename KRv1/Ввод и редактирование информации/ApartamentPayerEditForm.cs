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
    public partial class ApartamentPayerEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public ApartamentPayerEditForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM ApartamentPayer";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void ApartamentPayerEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.ApartamentPayer". При необходимости она может быть перемещена или удалена.
            this.apartamentPayerTableAdapter1.Fill(this.kRv4DataSet.ApartamentPayer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.ApartamentPayer". При необходимости она может быть перемещена или удалена.
            //this.apartamentPayerTableAdapter.Fill(this.kRv1DataSet.ApartamentPayer);

            selectQueryString = "SELECT Apartament.IdApartament, CONCAT(Street.StName, ', дом ', House.HNumber, ', кв. ', Apartament.ApNumber) FROM (Street JOIN House ON Street.IdStreet = House.IdStreet) JOIN Apartament ON House.IdHouse = Apartament.IdHouse";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();

            selectQueryString = "SELECT IdPayer, CONCAT('ID: ', IdPayer,  '; ', PayerSurname, ' ', PayerName) FROM Payer";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox2.ValueMember = dataTable.Columns[0].ColumnName.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter.Update(dataTable);
            }
            catch
            {
                MessageBox.Show("Не удалось изменить запись!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        sqlDataAdapter.Update(dataTable);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось удалить запись!");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectQueryString = "SELECT * FROM ApartamentPayer";
            //sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s1 = comboBox1.SelectedValue.ToString();
                string s2 = comboBox2.SelectedValue.ToString();
                selectQueryString = "SELECT IdApartament, IdPayer FROM ApartamentPayer WHERE IdApartament = " + s1 + " AND IdPayer = " + s2;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Данной квартире уже назначен данный плательщик уже существует!");
                }
                else
                {
                    try
                    {
                        string IdApartament, IdPayer;
                        if (comboBox1.SelectedValue.ToString().Length == 0) { IdApartament = "NULL"; }
                        else IdApartament = comboBox1.SelectedValue.ToString();
                        if (comboBox2.SelectedValue.ToString().Length == 0) { IdPayer = "NULL"; }
                        else IdPayer = comboBox2.SelectedValue.ToString();

                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO ApartamentPayer(IdApartament, IdPayer) VALUES (" + IdApartament + ", " + IdPayer + ")");
                        querySaveStaff.Connection = sqlConnection;
                        //querySaveStaff.CommandText = "INSERT INTO dbo.Street(StName, StLength, StDescription) VALUES ('" + textBox1.Text + "', " + textBox2.Text + ", '" + textBox3.Text + "')";
                        querySaveStaff.ExecuteNonQuery();

                        MessageBox.Show("Плательщик добавлен!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить квартире плательщика не удалось!");
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
