using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {

        private string connectionString = "server=31.31.198.99; user=u1736187_mbc; password=Fire22gzorge; database=u1736187_mydb; charset=utf8;";

        private MySqlConnection connection;

        private MySqlCommandBuilder cmdBuilder;

        private MySqlDataAdapter adapter;

        private DataSet ds;

        private string NameOfDT = "`INGRIDIENTS`";

        private string expr = "";

        private bool newRowAdding;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.Columns.Clear();
                CBfilling();

                string expression = "SELECT * , \"Delete\" as `Delete` FROM " + NameOfDT + expr;

                connection = new MySqlConnection(connectionString);

                adapter = new MySqlDataAdapter(expression, connection);

                cmdBuilder = new MySqlCommandBuilder(adapter);

                cmdBuilder.GetInsertCommand();
                cmdBuilder.GetUpdateCommand();
                cmdBuilder.GetDeleteCommand();

                ds = new DataSet();

                adapter.Fill(ds, NameOfDT);

                dataGridView1.DataSource = ds.Tables[NameOfDT];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell LC = new DataGridViewLinkCell();

                    dataGridView1[dataGridView1.Columns.Count - 1, i] = LC;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReLoadData()
        {
            try
            {
                CBfilling();
                ds.Clear();

                adapter.Fill(ds, NameOfDT);

                dataGridView1.DataSource = ds.Tables[NameOfDT];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {                   
                    DataGridViewLinkCell LC = new DataGridViewLinkCell();
       
                    dataGridView1[dataGridView1.Columns.Count - 1, i] = LC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            connection.Open();

            LoadData();

            CBfilling();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ReLoadData();
            CBfilling();
        }

        private void CBfilling()
        {
            comboBox1.Items.Clear();
            using (connection = new MySqlConnection(connectionString))
            {
                string expression = "SELECT `NAME` FROM " + NameOfDT +
                    " ORDER BY `NAME`";
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
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount - 1].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int RowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(RowIndex);

                            ds.Tables[NameOfDT].Rows[RowIndex].Delete();

                            adapter.Update(ds, NameOfDT);
                        }
                    }
                    else if (task == "Insert")
                    {
                        int RowIndex = e.RowIndex;

                        DataRow row = ds.Tables[NameOfDT].NewRow();

                        for (int i = 1; i < dataGridView1.ColumnCount - 1; i++)
                        {
                            row[i] = dataGridView1.Rows[RowIndex].Cells[i].Value;
                        }

                        ds.Tables[NameOfDT].Rows.Add(row);

                        ds.Tables[NameOfDT].Rows.RemoveAt(ds.Tables[NameOfDT].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount - 1].Value = "Delete";

                        adapter.Update(ds, NameOfDT);

                        newRowAdding = false;

                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                        {
                            ds.Tables[NameOfDT].Rows[r][i] = dataGridView1.Rows[r].Cells[i].Value;
                        }

                        adapter.Update(ds, NameOfDT);

                        dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.ColumnCount - 1].Value = "Delete";
                    }
                    LoadData();
                    comboBox1.Items.Clear();
                    CBfilling();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[dataGridView1.ColumnCount - 2, lastRow] = linkCell;

                    row.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[dataGridView1.ColumnCount - 1, rowIndex] = linkCell;

                    editingRow.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ячейка прихода не может быть пустой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int addValue = int.Parse(textBox2.Text);
                string name = comboBox1.Text;

                using (connection = new MySqlConnection(connectionString))
                {
                    string expression = "UPDATE " + NameOfDT +
                        " SET `VALUE`=`VALUE`+@addVal, " +
                        "`DATEOFDELIVERY`=CURRENT_TIMESTAMP() " +
                        "WHERE `NAME`=@N ";
                    using (MySqlCommand command = new MySqlCommand(expression, connection))
                    {
                        connection.Open();

                        MySqlParameter p1 = new MySqlParameter("@addVal", addValue);
                        MySqlParameter p2 = new MySqlParameter("@N", name);

                        command.Parameters.Add(p1);
                        command.Parameters.Add(p2);

                        int execute = command.ExecuteNonQuery();

                        MessageBox.Show("таблица обновлена!, обновлено строк: " + execute, "обнновление таблицы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                }
            }
            comboBox1.Text = "";
            textBox2.Text = "";
            ReLoadData();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            this.Hide();
            AuthorizationForm au = new AuthorizationForm();
            au.Show();
            au.Location = this.Location;
        }


        private void названиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expr = " ORDER BY `NAME`";
            LoadData();
        }

        private void колличествуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expr = " ORDER BY `VALUE`";
            LoadData();
        }

        private void датеЗавозаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expr = " ORDER BY `DATEOFDELIVERY`";
            LoadData();
        }

        private void расходныеМатериаллыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameOfDT = "`GOODS`";
            LoadData();
        }

        private void ингридиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameOfDT = "`INGRIDIENTS`";
            LoadData();
        }

        private void сиропыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameOfDT = "`SYRUP`";
            LoadData();
        }

        private void чайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameOfDT = "`TEA`";
            LoadData();
        }

        private void рецептыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameOfDT = "`COFRECIPES`";
            LoadData();
        }
    }
}
