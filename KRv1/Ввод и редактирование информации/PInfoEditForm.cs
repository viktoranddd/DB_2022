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
    public partial class PInfoEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public PInfoEditForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM PaymentInfo";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void PInfoEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.PaymentInfo". При необходимости она может быть перемещена или удалена.
            this.paymentInfoTableAdapter1.Fill(this.kRv4DataSet.PaymentInfo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv1DataSet.PaymentInfo". При необходимости она может быть перемещена или удалена.
            //this.paymentInfoTableAdapter.Fill(this.kRv1DataSet.PaymentInfo);

            selectQueryString = "SELECT Apartament.IdApartament, CONCAT(Street.StName, ', дом ', House.HNumber, ', кв. ', Apartament.ApNumber) FROM (Street JOIN House ON Street.IdStreet = House.IdStreet) JOIN Apartament ON House.IdHouse = Apartament.IdHouse";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox1.ValueMember = dataTable.Columns[0].ColumnName.ToString();

            comboBox2.Items.Add("Не оплачено");
            comboBox2.Items.Add("Оплачено");
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
                catch
                {
                    MessageBox.Show("Не удалось удалить запись!");
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
            selectQueryString = "SELECT * FROM PaymentInfo";
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
                if (maskedTextBox1.TextLength == 0) { s2 = "IS NULL"; }
                else s2 = "= '01." + maskedTextBox1.Text.ToString() + "'";
                //MessageBox.Show(s2);
                string s3;
                if (comboBox2.Text == "Оплачено") { s3 = "= 'P'"; }
                else if (comboBox2.Text == "Не оплачено") { s3 = "= 'С'"; }
                else { s3 = "IS NULL"; }
                selectQueryString = "SELECT IdApartament FROM PaymentInfo WHERE IdApartament = " + s1 + " AND PIPeriod " + s2 + " AND PIStatus " + s3;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Такая информация об оплате уже существует!");
                }
                else
                {
                    try
                    {
                        string IdApartament, PIPeriod, PIStatus;
                        if (comboBox1.SelectedValue.ToString().Length == 0) { IdApartament = "NULL"; }
                        else IdApartament = comboBox1.SelectedValue.ToString();
                        if (maskedTextBox1.TextLength == 0) { PIPeriod = "NULL"; }
                        else PIPeriod = "'01." + maskedTextBox1.Text.ToString() + "'";
                        if (comboBox2.Text == "Оплачено") { PIStatus = "'P'"; }
                        else if (comboBox2.Text == "Не оплачено") { PIStatus = "'С'"; }
                        else { PIStatus = "NULL"; }

                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO PaymentInfo(IdApartament, PIPeriod, PIStatus) VALUES (" + IdApartament + ", " + PIPeriod + ", " + PIStatus + ")");
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
                        MessageBox.Show("Информация об оплате добавлена!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить информацию об оплате не удалось!");
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
