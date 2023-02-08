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
    public partial class PaymentEditForm : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;

        public PaymentEditForm()
        {
            sqlConnection = new SqlConnection(ConnString.GetConnString());
            selectQueryString = "SELECT * FROM Payment";
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            InitializeComponent();
        }

        private void PaymentEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter1.Fill(this.kRv4DataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRv4DataSet.PaymentType". При необходимости она может быть перемещена или удалена.
            this.paymentTypeTableAdapter1.Fill(this.kRv4DataSet.PaymentType);
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

            selectQueryString = "SELECT IdPaymentType, PTName FROM PaymentType";
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = dataTable.Columns[1].ColumnName.ToString();
            comboBox2.ValueMember = dataTable.Columns[0].ColumnName.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectQueryString = "SELECT * FROM Payment";
            //sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            //this.paymentBindingSource = bindingSource;
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
                string s3 = comboBox2.SelectedValue.ToString();
                selectQueryString = "SELECT IdApartament, IdPaymentType FROM Payment WHERE IdApartament = " + s1 + " AND PPeriod " + s2 + " AND IdPaymentType = " + s3;
                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Такой платеж уже существует!");
                }
                else
                {
                    try
                    {
                        string IdApartament, PPeriod, IdPaymentType, PAmount, PTariff, PAccural, PBenefit, PTotal;
                        if (comboBox1.SelectedValue.ToString().Length == 0) { IdApartament = "NULL"; }
                        else IdApartament = comboBox1.SelectedValue.ToString();
                        if (maskedTextBox1.TextLength == 0) { PPeriod = "NULL"; }
                        else PPeriod = "'01." + maskedTextBox1.Text.ToString() + "'";
                        if (comboBox2.SelectedValue.ToString().Length == 0) { IdPaymentType = "NULL"; }
                        else IdPaymentType = comboBox2.SelectedValue.ToString();
                        if (textBox1.TextLength == 0) { PAmount = "NULL"; }
                        else PAmount = textBox1.Text.ToString();
                        if (textBox2.TextLength == 0) { PTariff = "NULL"; }
                        else PTariff = textBox2.Text.ToString();
                        PAccural = (Math.Round(double.Parse(PAmount) * double.Parse(PTariff), 2)).ToString();
                        if (textBox3.TextLength == 0)
                        {
                            PBenefit = "NULL";
                            PTotal = PAccural;
                        }
                        else
                        {
                            PBenefit = textBox3.Text.ToString();
                            double PTotalD;
                            PTotalD = Math.Round(double.Parse(PAccural) - double.Parse(PBenefit), 2);
                            PBenefit = PBenefit.Replace(',', '.');
                            if (PTotalD < 0) { PTotal = "0"; }
                            else { PTotal = PTotalD.ToString(); }
                        }
                        PAmount = PAmount.Replace(',', '.');
                        PTariff = PTariff.Replace(',', '.');
                        PAccural = PAccural.Replace(',', '.');
                        PTotal = PTotal.Replace(',', '.');
                        //MessageBox.Show(PAmount);
                        //MessageBox.Show(PTariff);
                        //MessageBox.Show(PAccural);
                        //MessageBox.Show(PBenefit);
                        //MessageBox.Show(PTotal);

                        SqlCommand querySaveStaff = new SqlCommand("INSERT INTO Payment(IdApartament, PPeriod, IdPaymentType, PAmount, PTariff, PAccural, PBenefit, PTotal) VALUES (" + IdApartament + ", " + PPeriod + ", " + IdPaymentType + ", " + PAmount + ", " + PTariff + ", " + PAccural + ", " + PBenefit + ", " + PTotal + ")");
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

                        string s1dop = comboBox1.SelectedValue.ToString();
                        string s2dop;
                        if (maskedTextBox1.TextLength == 0) { s2dop = "IS NULL"; }
                        else s2dop = "= '01." + maskedTextBox1.Text.ToString() + "'";
                        selectQueryString = "SELECT IdApartament FROM PaymentInfo WHERE IdApartament = " + s1dop + " AND PIPeriod " + s2dop;
                        sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                        sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count == 0)
                        {
                            SqlCommand newQuerySaveStaff = new SqlCommand("INSERT INTO PaymentInfo(IdApartament, PIPeriod, PIStatus) VALUES (" + IdApartament + ", " + PPeriod + ", 'C')");
                            newQuerySaveStaff.Connection = sqlConnection;
                            newQuerySaveStaff.ExecuteNonQuery();
                        }

                        MessageBox.Show("Платеж добавлен!");
                        //this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить платеж не удалось!");
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
