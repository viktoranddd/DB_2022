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
    public partial class EditStreetForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        //private String UserLevel

        public EditStreetForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Street";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void EditStreetForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Street". При необходимости она может быть перемещена или удалена.
            this.streetTableAdapter2.Fill(this.kRv4DataSet.Street);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv2DataSet.Street". При необходимости она может быть перемещена или удалена.
            //this.streetTableAdapter1.Fill(this.kRv2DataSet.Street);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Street". При необходимости она может быть перемещена или удалена.
            //this.streetTableAdapter.Fill(this.kRv1DataSet.Street);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                if (textBox1.TextLength == 0) { s = " IS NULL"; }
                else s = "= '" + textBox1.Text.ToString() + "'";
                selectQueryString = "SELECT StName FROM Street WHERE StName " + s;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Улица с таким названием уже существует!");
                }
                else
                {
                    try
                    {
                        string StName, StLength, StDescription;
                        if (textBox1.TextLength == 0) { StName = "NULL"; }
                        else StName = textBox1.Text.ToString();
                        //MessageBox.Show(StName);
                        if (textBox2.TextLength == 0) { StLength = "NULL"; }
                        else StLength = textBox2.Text.ToString();
                        //MessageBox.Show(StName);
                        if (textBox3.TextLength == 0) { StDescription = "NULL"; }
                        else StDescription = "'" + textBox3.Text.ToString() + "'";
                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO dbo.Street(StName, StLength, StDescription) VALUES ('" + StName + "', " + StLength + ", " + StDescription + ")");
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
                        MessageBox.Show("Улица добавлена!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить улицу не удалось!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоррекнтый ввод данных!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Street";
            //sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            //sqlConnection.Close();
            //dataGridView1.Columns[0].Visible = false;
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
