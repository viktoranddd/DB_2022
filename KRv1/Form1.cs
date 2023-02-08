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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Surname, Name, Id;
            Surname = textBox1.Text;
            Name = textBox2.Text;
            Id = textBox3.Text;
            SqlConnection conn = new SqlConnection(ConnString.GetConnString());
            //MessageBox.Show(Id, Surname);
            try
            {
                conn.Open();
                //MessageBox.Show("Успешно!");
                try
                {
                    string sql = "SELECT IdPayer,PayerSurname,PayerName FROM Payer WHERE IdPayer LIKE " + Id + " AND PayerSurname LIKE '" + Surname + "' AND PayerName LIKE '" + Name + "'"; // Строка запроса
                    //string sql = "SELECT IdPayer,PayerSurname,PayerName FROM Payer WHERE IdPayer LIKE " + Id + " AND PayerSurname LIKE [" + Surname + "]"; // Строка запроса
                    SqlCommand logCom = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(logCom);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    conn.Close();
                    if (table.Rows.Count != 0)
                    {
                        //conn.Close();
                        User_MainForm NewFrom = new User_MainForm(Id, Surname, Name);
                        //NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                        NewFrom.Show();
                        this.Hide();
                        // MessageBox.Show("Успешный вход!");
                        //SqlDataReader Reader = logCom.ExecuteReader(); //ридер запроса
                        //Reader.Read(); // Чтение 1й строки запроса

                        //if (Reader.GetString(0) == "Admin") // Ссылка на 0 столбец запроса 
                        //{
                        //    Admin_MainForm NewFrom = new Admin_MainForm(Reader.GetString(1), conn);
                        //    conn.Close();
                        //    NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                        //    NewFrom.Show();
                        //    this.Hide();

                        //}
                        //else if (Reader.GetString(0) == "SudUser")
                        //{

                        //    SudUser NewFrom = new SudUser(Reader.GetString(1), conn);
                        //    conn.Close();
                        //    NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                        //    NewFrom.Show();
                        //    this.Hide();

                        //}
                        //else if (Reader.GetString(0) == "PSUser")
                        //{

                        //    PSUserFrom NewFrom = new PSUserFrom(Reader.GetString(1), conn);
                        //    conn.Close();
                        //    NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                        //    NewFrom.Show();
                        //    this.Hide();

                        //}
                        //else if (Reader.GetString(0) == "AUser")
                        //{

                        //    ArchiveForm NewFrom = new ArchiveForm(Reader.GetString(1), conn);
                        //    conn.Close();
                        //    NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
                        //    NewFrom.Show();
                        //    this.Hide();

                        //}
                        //else
                        //{
                        //    MessageBox.Show("Вам не назначена роль, обратитесь к администратору!");
                        //}
                    }
                    else
                    {
                        //conn.Close();
                        MessageBox.Show("Пользователь не найден!");
                    }
                }
                catch
                {
                    //conn.Close();
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Открытия базы данных! (Обратитесь к администратору)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 NewFrom = new Form2();
            //conn.Close();
            //NewFrom.FormClosed += (object s, FormClosedEventArgs args) => { this.Show(); };
            NewFrom.Show();
            this.Hide();
        }
    }
}
