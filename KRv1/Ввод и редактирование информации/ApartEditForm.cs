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
    public partial class ApartEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public ApartEditForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Apartament";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    sqlDataAdapter.Update(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectQueryString = "SELECT * FROM Apartament";
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
                string s2;
                if (textBox1.TextLength == 0) { s2 = "IS NULL"; }
                else s2 = "= " + textBox1.Text.ToString();
                selectQueryString = "SELECT IdHouse, ApNumber FROM Apartament WHERE IdHouse = " + s1 + " AND ApNumber " + s2;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Такая квартира уже существует!");
                }
                else
                {
                    try
                    {
                        string IdHouse, ApNumber, ApPersons, ApArea;
                        if (comboBox1.SelectedValue.ToString().Length == 0) { IdHouse = "NULL"; }
                        else IdHouse = comboBox1.SelectedValue.ToString();
                        MessageBox.Show(IdHouse);
                        if (textBox1.TextLength == 0) { ApNumber = "NULL"; }
                        else ApNumber = textBox1.Text.ToString();
                        MessageBox.Show(ApNumber);
                        if (textBox2.TextLength == 0) { ApPersons = "NULL"; }
                        else ApPersons = textBox2.Text.ToString();
                        MessageBox.Show(ApPersons);
                        if (textBox3.TextLength == 0) { ApArea = "NULL"; }
                        else ApArea = textBox3.Text.ToString();
                        MessageBox.Show(ApArea);
                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO Apartament(IdHouse, ApNumber, ApPersons, ApArea) VALUES (" + IdHouse + ", " + ApNumber + ", " + ApPersons + ", " + ApArea + ")");
                        querySaveStaff.Connection = sqlConnection;
                        //querySaveStaff.CommandText = "INSERT INTO dbo.Street(StName, StLength, StDescription) VALUES ('" + textBox1.Text + "', " + textBox2.Text + ", '" + textBox3.Text + "')";
                        querySaveStaff.ExecuteNonQuery();

                        //string saveStaff = "INSERT INTO dbo.Street(StName, StLength, StDescription) VALUES ('@Name', @Len, '@Desc')";
                        //using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        //{
                        //    querySaveStaff.Connection = sqlConnection;
                        //    querySaveStaff.CommandText = "INSERT INTO dbo.Street(StName, StLength, StDescription) VALUES ('" + textBox1.Text + "', " + textBox2.Text + ", '" + textBox3.Text + "')";
                        //    querySaveStaff.Parameters.AddWithValue("Name", textBox1.Text);
                        //    querySaveStaff.Parameters.AddWithValue("Length", textBox2.Text);
                        //    querySaveStaff.Parameters.AddWithValue("Desc", textBox3.Text);
                        //    querySaveStaff.ExecuteNonQuery();
                        //}
                        MessageBox.Show("Квартира добавлена!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить квартиру не удалось!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоррекнтый ввод данных!");
            }         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApartEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Apartament". При необходимости она может быть перемещена или удалена.
            this.apartamentTableAdapter1.Fill(this.kRv4DataSet.Apartament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Apartament". При необходимости она может быть перемещена или удалена.
            //this.apartamentTableAdapter.Fill(this.kRv1DataSet.Apartament);

            selectQueryString = "SELECT House.IdHouse, CONCAT(Street.StName, ', ', House.HNumber) FROM Street JOIN House ON Street.IdStreet = House.IdStreet";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();
        }
    }
}
