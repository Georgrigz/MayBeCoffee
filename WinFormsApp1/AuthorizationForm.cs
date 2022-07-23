
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class AuthorizationForm : Form
    {
        string connectionString = "server=31.31.198.99; user=u1736187_mbc; password=Fire22gzorge; database=u1736187_mydb ;maximumpoolsize=50 ;charset=utf8";
        public AuthorizationForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            string expression = "SELECT * FROM `USERS`" +
                    "WHERE `UserName`=@UN AND `Password`=@Pass";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using(MySqlCommand cmd = new MySqlCommand(expression, connection))
                {
                    connection.Open();
                    MySqlParameter p1 = new MySqlParameter("@UN", login);
                    MySqlParameter p2 = new MySqlParameter("@Pass", password);


                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bool status = reader.GetBoolean(3);
                                if (status)
                                {
                                    this.Hide();
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.ShowDialog();

                                }
                                else
                                {
                                    this.Hide();
                                    UserForm userForm = new UserForm();
                                    userForm.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    connection.Close();
                }
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm RF = new RegistrationForm();
            RF.Show();
            RF.Location = this.Location;
            this.Hide();

        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}   