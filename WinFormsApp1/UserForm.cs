using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;	
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        private string connectionString = "server=31.31.198.99; user=u1736187_mbc; password=Fire22gzorge; database=u1736187_mydb ;maximumpoolsize=50 ;charset=utf8";
        public string order = "";
        private decimal price = 0;

        public void coffeecounting()
        {
            List<string> names = new List<string>();
            names.Add("КОФЕ");
            names.Add("МОЛОКО");
            names.Add("СЛИВКИ");
            int[] goods = new int[3];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string expression = "SELECT `КОФЕ`, `МОЛОКО`, `СЛИВКИ` From `COFRECIPES` " +
                        "WHERE `NAME` = @name";
                    string name = listBox1.Items[i].ToString();

                    using (MySqlCommand command = new MySqlCommand(expression, connection))
                    {
                        connection.Open();
                        MySqlParameter p = new MySqlParameter("@name", name);

                        command.Parameters.Add(p);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    goods[0] += reader.GetInt32(0);
                                    goods[1] += reader.GetInt32(1);
                                    goods[2] += reader.GetInt32(2);
                                }
                            }
                        }
                        connection.Close();
                    }
                }
                int k = 0;
                int execute = 0;
                foreach (var item in names)
                {
                    string expression = "UPDATE `INGRIDIENTS`" +
                    " SET `VALUE`=`VALUE`-@addVal " +
                    "WHERE `NAME` =@N ";
                    using (MySqlCommand command = new MySqlCommand(expression, connection))
                    {

                        connection.Open();

                        MySqlParameter p1 = new MySqlParameter("@addVal", goods[k]);
                        MySqlParameter p2 = new MySqlParameter("@N", item);

                        command.Parameters.Add(p1);
                        command.Parameters.Add(p2);
                        command.ExecuteNonQuery();
                        k++;
                        connection.Close();
                    }
                }               
            }
        }

        public void syrupcounting()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                int k = 0;
                int execute = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string name = listBox1.Items[i].ToString();

                    if (name.Contains("Сиропы"))
                    {
                        name = name.Remove(0, 7);
                        if (name.Contains("Большой"))
                        {
                            k = 50;
                            int index = name.IndexOf(" Большой");
                            name = name.Remove(index, 8);
                        }
                        else if (name.Contains("Мальенький"))
                        {
                            k = 25;
                            int index = name.IndexOf(" Мальенький");
                            name = name.Remove(index, 11);
                        }
                        string expression = "UPDATE `SYRUP` SET `VALUE` = `VALUE`-@addVal WHERE `NAME` = @n ";
                        using (MySqlCommand command = new MySqlCommand(expression, connection))
                        {

                            connection.Open();

                            MySqlParameter p1 = new MySqlParameter("@addVal", k);
                            MySqlParameter p2 = new MySqlParameter("@N", name);

                            command.Parameters.Add(p1);
                            command.Parameters.Add(p2);
                            command.ExecuteNonQuery();
                            k++;;
                            connection.Close();
                        }
                    }
                }
            }
        }


        public UserForm()
        {
            InitializeComponent();
            button7.Enabled = false;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        { 
            this.Hide();
            AuthorizationForm au = new AuthorizationForm();
            au.Show();
            au.Location = this.Location;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
        }

        private void reload()
        {
            price = 0;
            Regex regex1 = new Regex(@"Сиропы \w*");

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {             
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string expression = "SELECT VALUE FROM `PRICE` " +
                        "WHERE `NAME`= @name";
                    string name = listBox1.Items[i].ToString();
                  
                    var matches1 = regex1.Matches(name);

                    if(matches1.Count!=0)
                    {
                        name = "Сироп";
                    }

                    using (MySqlCommand command = new MySqlCommand(expression, connection))
                    {
                        connection.Open();
                        MySqlParameter p = new MySqlParameter("@name",name);

                        command.Parameters.Add(p);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    price += reader.GetDecimal(0);
                                }
                            }
                        }                    
                        connection.Close();
                    }                    
                }
                textBox1.Text = price.ToString();
                if(listBox1.Items.Count!=0)
                {
                    button7.Enabled = true;
                    button6.Enabled = true;
                }
                else
                {
                    button7.Enabled = false;
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            coffeecounting();
            syrupcounting();
            listBox1.Items.Clear();
            reload();
            button6.Enabled = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.ShowDialog(this);
            if (order != "")
                listBox1.Items.Add(order);
            order = "";  
            reload();
            button7.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count!=0)
            {
                string index = listBox1.SelectedItem.ToString();
                if (MessageBox.Show("Удалить данный товар? " + listBox1.SelectedItem, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBox1.Items.Remove(index);
                    reload();
                }
            }
            else
            {
                MessageBox.Show("Нет выбранных товаров!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                price -= price / 10;
                textBox1.Text = price.ToString();
                button6.Enabled = false;
            }            
        }
    }
}
