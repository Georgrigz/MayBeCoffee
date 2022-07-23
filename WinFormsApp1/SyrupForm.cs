using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class SyrupForm : Form
    {

        string connectionString = "server=31.31.198.99; user=u1736187_mbc; password=Fire22gzorge; database=u1736187_mydb; charset=utf8;";
        public string order;
        public SyrupForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            order += comboBox1.Text;
            SyrupSize SZ = new SyrupSize();
            SZ.ShowDialog(this);
            ((Coffee)this.Owner).order += " "+order;
            this.Close();
        }

        private void SyrupForm_Load(object sender, EventArgs e)
        {
            CBfilling();
        }

        private void CBfilling()
        {
            comboBox1.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string expression = "SELECT `NAME` From`SYRUP` " +
                    " order by `NAME`";
                using (MySqlCommand command = new MySqlCommand(expression, connection))
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
        }
    }
}
