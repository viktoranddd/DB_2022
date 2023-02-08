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
    public partial class HouseEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public HouseEditForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM House";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void HouseEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Street". При необходимости она может быть перемещена или удалена.
            this.streetTableAdapter1.Fill(this.kRv4DataSet.Street);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter1.Fill(this.kRv4DataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Street". При необходимости она может быть перемещена или удалена.
            //this.streetTableAdapter.Fill(this.kRv1DataSet.Street);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.House". При необходимости она может быть перемещена или удалена.
            //this.houseTableAdapter.Fill(this.kRv1DataSet.House);

            selectQueryString = "SELECT IdStreet, StName FROM Street";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s1 = comboBox1.SelectedValue.ToString();
                string s2;
                if (textBox1.TextLength == 0) { s2 = "IS NULL"; }
                else s2 = "= '" + textBox1.Text.ToString() + "'";
                selectQueryString = "SELECT IdStreet, HNumber FROM House WHERE IdStreet = " + s1 + " AND HNumber " + s2;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Такой дом уже существует!");
                }
                else
                {
                    try
                    {
                        string IdStreet, HNumber, HLevels, HDescription;
                        if (comboBox1.SelectedValue.ToString().Length == 0) { IdStreet = "NULL"; }
                        else IdStreet = comboBox1.SelectedValue.ToString();
                        if (textBox1.TextLength == 0) { HNumber = "NULL"; }
                        else HNumber = "'" + textBox1.Text.ToString() + "'";
                        //MessageBox.Show(comboBox1.SelectedValue.ToString());
                        if (textBox2.TextLength == 0) { HLevels = "NULL"; }
                        else HLevels = textBox2.Text.ToString();
                        //MessageBox.Show(StName);
                        if (textBox3.TextLength == 0) { HDescription = "NULL"; }
                        else HDescription = "'" + textBox3.Text.ToString() + "'";
                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO House(IdStreet, HNumber, HLevels, HDescription) VALUES (" + IdStreet + ", " + HNumber + ", " + HLevels + ", " + HDescription + ")");
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
                        MessageBox.Show("Дом добавлен!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить дом не удалось!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!");
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectQueryString = "SELECT * FROM House";
            //sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
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

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
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
    }
}
