using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        string connectionString = "server=31.31.198.99; user=u1736187_mbc; password=Fire22gzorge; database=u1736187_mydb";

        private void button1_Click_1(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;


            if (login != string.Empty || password != string.Empty)
            {
                string expression = "SELECT * FROM `USERS` " +
                        "WHERE `UserName`=@UN";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(expression, connection);
                MySqlParameter p = new MySqlParameter("@UN", login);
                cmd.Parameters.Add(p);          

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    reader.Close();
                    MessageBox.Show("Данный логин занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();
                    expression = "INSERT INTO `USERS` (`UserName`, `Password`) VALUES (@UN,@Pass)";
                    cmd = new MySqlCommand(expression, connection);

                    cmd.Parameters.AddWithValue("@UN", login);
                    cmd.Parameters.AddWithValue("@Pass", password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Учетная запись создана. Авторизуйтесь", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthorizationForm authorizationForm = new AuthorizationForm();
                    authorizationForm.Location = this.Location;
                    authorizationForm.Show();
                    this.Hide();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Поля логина и пароля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Location = this.Location;
            this.Hide();
            authorizationForm.Show();
            
        }
    }
}

