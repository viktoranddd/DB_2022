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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            SqlConnection conn = new SqlConnection(ConnString.GetConnString());
            try
            {
                conn.Open();
                //MessageBox.Show("Успешно!");
                try
                {
                    string sql = "SELECT UUsername, UPassword FROM Users WHERE UUsername LIKE '" + username + "' AND UPassword LIKE '" + password + "'"; // Строка запроса
                    //string sql = "SELECT IdPayer,PayerSurname,PayerName FROM Payer WHERE IdPayer LIKE " + Id + " AND PayerSurname LIKE [" + Surname + "]"; // Строка запроса
                    SqlCommand logCom = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(logCom);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                    if (table.Rows.Count != 0)
                    {
                        
                        SqlDataReader Reader = logCom.ExecuteReader(); //ридер запроса
                        Reader.Read(); // Чтение 1й строки запроса
                        if (Reader.GetString(0) == "admin")
                        {
                            conn.Close();
                            Admin_MainForm NewFrom = new Admin_MainForm();
                            NewFrom.Show();
                            this.Hide();

                        }
                        else if (Reader.GetString(0) == "employee")
                        {
                            conn.Close();
                            Employee_MainForm NewFrom = new Employee_MainForm();
                            NewFrom.Show();
                            this.Hide();

                        }
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
                        conn.Close();
                        MessageBox.Show("Пользователь не найден!");
                    }
                }
                catch
                {
                    conn.Close();
                    MessageBox.Show("Некорректный ввод данных!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия базы данных! (Обратитесь к администратору)");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
