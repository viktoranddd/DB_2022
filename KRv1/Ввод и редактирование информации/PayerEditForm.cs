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
    public partial class PayerEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public PayerEditForm()
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

        private void PayerEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Payer". При необходимости она может быть перемещена или удалена.
            this.payerTableAdapter1.Fill(this.kRv4DataSet.Payer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.Payer". При необходимости она может быть перемещена или удалена.
            //this.payerTableAdapter.Fill(this.kRv1DataSet.Payer);
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

        private void button2_Click(object sender, EventArgs e)
        {
            selectQueryString = "SELECT * FROM Payer";
            //sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
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
                string PayerSurname, PayerName, PayerPatronymic, PayerPhone, PayerEmail;
                if (textBox1.TextLength == 0) { PayerSurname = "IS NULL"; }
                else PayerSurname = "= '" + textBox1.Text.ToString() + "'";
                if (textBox2.TextLength == 0) { PayerName = "IS NULL"; }
                else PayerName = "= '" + textBox2.Text.ToString() + "'";
                if (textBox3.TextLength == 0) { PayerPatronymic = "IS NULL"; }
                else PayerPatronymic = "= '" + textBox3.Text.ToString() + "'";
                if (textBox4.TextLength == 0) { PayerPhone = "IS NULL"; }
                else PayerPhone = "= '" + textBox4.Text.ToString() + "'";
                if (textBox5.TextLength == 0) { PayerEmail = "IS NULL"; }
                else PayerEmail = "= '" + textBox5.Text.ToString() + "'";
                selectQueryString = "SELECT PayerSurname, PayerName, PayerPatronymic, PayerPhone, PayerEmail FROM Payer WHERE PayerSurname " + PayerSurname + " AND PayerName " + PayerName + " AND PayerPatronymic " + PayerPatronymic + " AND PayerPhone " + PayerPhone + " AND PayerEmail " + PayerEmail;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Такой плательщик уже существует!");
                }
                else
                {
                    try
                    {
                        if (textBox1.TextLength == 0) { PayerSurname = "NULL"; }
                        else PayerSurname = "'" + textBox1.Text.ToString() + "'";
                        if (textBox2.TextLength == 0) { PayerName = "NULL"; }
                        else PayerName = "'" + textBox2.Text.ToString() + "'";
                        if (textBox3.TextLength == 0) { PayerPatronymic = "NULL"; }
                        else PayerPatronymic = "'" + textBox3.Text.ToString() + "'";
                        if (textBox4.TextLength == 0) { PayerPhone = "NULL"; }
                        else PayerPhone = "'" + textBox4.Text.ToString() + "'";
                        if (textBox5.TextLength == 0) { PayerEmail = "NULL"; }
                        else PayerEmail = "'" + textBox5.Text.ToString() + "'";
                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO Payer(PayerSurname, PayerName, PayerPatronymic, PayerPhone, PayerEmail) VALUES (" + PayerSurname + ", " + PayerName + ", " + PayerPatronymic + ", " + PayerPhone + ", " + PayerEmail + ")");
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
                        MessageBox.Show("Плательщик добавлен!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить плательщика не удалось!");
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
