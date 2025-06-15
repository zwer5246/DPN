using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace test
{
    public partial class MainForm : Form
    {
        // Глобальные переменные
        int Number_of_users_global;
        List<string> persons = new List<string>();
        SqlConnection connection_main;
        bool redact = false;
        string current_cell_value, selected_date;
        string inads;

        //int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
        //int columnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
        // Конец поля глобальных переменных

        // Переменные содержащие настраиваемые из программы настройки

        /* НЕ ИСПОЛЬЗУЕТСЯ! */

        // Конец переменных ручной настройки

        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        string getStatTable(string date)
        {
            string command = "";
            for (int i = 1; i <= Number_of_users_global; i++)
            {
                command = command + "select test.Фамилия, Person" + i + ".[1-пара], Person" + i + ".[2-пара], Person" + i + ".[3-пара], Person" + i + ".[4-пара] from test, Person" + i + " where Person" + i + ".Дата = " + "'" + date + "'" + " and test.Фамилия = 'Person" + i + "' \n";
                if (i != Number_of_users_global)
                {
                    command = command + " union \n";
                }
            }
            return command;
        }
        void end_redact()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            выпоонитьToolStripMenuItem.Enabled = true;
            menu1ToolStripMenuItem.Enabled = true;
            treeView1.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
        }
        void start_redact()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            выпоонитьToolStripMenuItem.Enabled = false;
            menu1ToolStripMenuItem.Enabled = false;
            treeView1.Enabled = false;
            button6.Enabled = true;
            button5.Enabled = true;
        }
        private void SqlConnectionReturn(string connection_string, int number_of_users)
        {
            connection_main = new SqlConnection(connection_string);
            Number_of_users_global = number_of_users;
            connection_main.Open();
            if (connection_main.State == ConnectionState.Open)
            {
                connection_main.Close();
                label1.Text = "Вход выполнен.";
                getTree_stat();
                getTree_stat2();
                label1.ForeColor = Color.Green;
                EnableButtons();
            }
        }
        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            treeView1.Enabled = true;
            fillerToolStripMenuItem.Enabled = true;
            статистикаПодключенияToolStripMenuItem.Enabled = true;
            menu1ToolStripMenuItem.Enabled = false;
        }
        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            treeView1.Enabled = false;
            fillerToolStripMenuItem.Enabled = false;
            статистикаПодключенияToolStripMenuItem.Enabled = false;
            menu1ToolStripMenuItem.Enabled = true;
        }
        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form newForm = new login_form(new MyDelegate1(SqlConnectionReturn), new MyDelegate2(EnableButtons));
            newForm.ShowDialog();
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_main.Rows.Add();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Данное действие полностью отключит вас от сервера баз данных. Для повторного входа потребуется повторная авторизация.", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                loading_form loadingForm = new loading_form("Выход из системы...", 1, false);
                loadingForm.ShowDialog();
                dataGridView_main.Rows.Clear();
                DisableButtons();
                label1.Text = "Сессия завершена";
                Number_of_users_global = 0;
                treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
                treeView1.CollapseAll();
                dataGridView_main.Columns.Clear();
                label1.ForeColor = Color.Black;
                connection_main = null;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            start_redact();
            dataGridView_main.ReadOnly = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            end_redact();
            dataGridView_main.ReadOnly = true;
            dataGridView_main.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            dataGridView_main.Rows.Clear();
            Thread.Sleep(500);
            displayTable_mainTable("SELECT Count(*) FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = 'Person1'", "SELECT Count(*) FROM Person1", "select * from Person1");
            button1.Enabled = true;
        }
        private void displayTable_mainTable(string firstSQLQuery, string secondSQLQuery, string readerSQLQuery)
        {
            int counter_of_columns = 0, counter_of_rows = 0;
            if (connection_main == null)
            {
                MessageBox.Show("Невозможно запросить данные, так как отсутствет подключение к серверу баз данных. ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmdCount;
                connection_main.Open();

                using (cmdCount = new SqlCommand(firstSQLQuery, connection_main))
                {
                    counter_of_columns = (int)cmdCount.ExecuteScalar();
                }
                SqlCommand command = new SqlCommand(readerSQLQuery, connection_main);
                SqlDataReader reader = command.ExecuteReader();
                dataGridView_main.Columns.Clear();
                for (int i = 0; i < counter_of_columns - 1; i++)
                {
                    string column = reader.GetName(i);
                    if (column == "1-пара" || column == "2-пара" || column == "3-пара" || column == "4-пара") // Создание колонок
                    {
                        dataGridView_main.Columns.Add("Column" + i, column);
                        dataGridView_main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else if (i == 0)
                    {
                        dataGridView_main.Columns.Add("Column" + i, column);
                        dataGridView_main.Columns[i].ReadOnly = true;
                    }
                    else
                    {
                        dataGridView_main.Columns.Add("Column" + i, column);
                    }
                }

                foreach (DataGridViewColumn column in dataGridView_main.Columns) // Запрет каждому стобцу на сортировку
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                using (cmdCount = new SqlCommand(secondSQLQuery, connection_main))
                {
                    counter_of_rows = (int)cmdCount.ExecuteScalar();
                }
                for (int i = 0; i < counter_of_rows; i++)
                {
                    reader.Read();
                    dataGridView_main.Rows.Add();
                    for (int j = 0; j < counter_of_columns; j++)
                    {
                        if (j == 0)
                        {
                            DateTime date = (DateTime)reader.GetValue(j);
                            dataGridView_main.Rows[i].Cells[j].Value = date.ToString("yyyy.MM.dd");
                            dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView_main.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            if (reader.IsDBNull(j))
                            {
                                dataGridView_main.Rows[i].Cells[j].Value = "Неизвестно";
                                dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                            }
                            else
                            {
                                if ((string)reader.GetValue(j) == "УП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "УП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.BlueViolet;
                                }
                                else if ((string)reader.GetValue(j) == "НП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "НП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                                }
                                else if ((string)reader.GetValue(j) == "ПП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "ПП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                }
                connection_main.Close();
            }
        }
        private void getTree_stat()
        {
            int counter_of_columns;
            SqlCommand cmdCount;
            connection_main.Open();
            using (cmdCount = new SqlCommand("SELECT Count(*) FROM Person1", connection_main))
            {
                counter_of_columns = (int)cmdCount.ExecuteScalar();
            }
            SqlCommand cmd = new SqlCommand("select Дата from Person1", connection_main);
            SqlDataReader reader = cmd.ExecuteReader();

            for (int i = 0; i < counter_of_columns; i++)
            {
                reader.Read();
                DateTime date = (DateTime)reader.GetValue(0);
                treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(date.ToString("yyyy.MM.dd"));
            }
            connection_main.Close();
        }
        private void getTree_stat2()
        {
            int counter_of_columns;
            SqlCommand cmdCount;
            connection_main.Open();
            using (cmdCount = new SqlCommand("SELECT Count(*) FROM test", connection_main))
            {
                counter_of_columns = (int)cmdCount.ExecuteScalar();
            }
            SqlCommand cmd = new SqlCommand("select Фамилия from test", connection_main);
            SqlDataReader reader = cmd.ExecuteReader();

            for (int i = 0; i < counter_of_columns; i++)
            {
                reader.Read();
                string phamilia = (string)reader.GetValue(0);
                persons.Add(phamilia);
                treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(phamilia);
            }
            connection_main.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            redact = false;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            button4.Enabled = true;
            dataGridView_main.Columns.Clear();
            dataGridView_main.Rows.Clear();
            if (date_test(treeView1.SelectedNode.Text))
            {
                connection_main.Open();
                SqlCommand command = new SqlCommand(getStatTable(treeView1.SelectedNode.Text), connection_main);
                SqlDataReader reader = command.ExecuteReader();
                dataGridView_main.Columns.Clear();
                for (int i = 0; i < 5; i++)
                {
                    string column = reader.GetName(i);
                    dataGridView_main.Columns.Add("Column" + i, column);
                    dataGridView_main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                for (int i = 0; i < Number_of_users_global; i++)
                {
                    reader.Read();
                    dataGridView_main.Rows.Add();
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 0)
                        {
                            dataGridView_main.Rows[i].Cells[j].Value = reader.GetValue(j);
                            dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView_main.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            if (reader.IsDBNull(j))
                            {
                                dataGridView_main.Rows[i].Cells[j].Value = "Неизвестно";
                                dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                            }
                            else
                            {
                                if ((string)reader.GetValue(j) == "УП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "УП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.BlueViolet;
                                }
                                else if ((string)reader.GetValue(j) == "НП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "НП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                                }
                                else if ((string)reader.GetValue(j) == "ПП")
                                {
                                    dataGridView_main.Rows[i].Cells[j].Value = "ПП";
                                    dataGridView_main.Rows[i].Cells[j].Style.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                }
                selected_date = treeView1.SelectedNode.Text;
            }
            else if (phamilia_test(treeView1.SelectedNode.Text))
            {
                button4.Enabled = false;
                dataGridView_main.Rows.Clear();
                displayTable_mainTable("SELECT Count(*) FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" + treeView1.SelectedNode.Text + "'", "SELECT Count(*) FROM " + treeView1.SelectedNode.Text, "select * from " + treeView1.SelectedNode.Text);
            }
            connection_main.Close();
        }
        bool date_test(string tester_date)
        {
            bool result = false;
            if (DateTime.TryParse(tester_date, out DateTime date))
            {
                result = true;
            }
            return result;
        }
        bool phamilia_test(string phamilia)
        {
            foreach (string s in persons)
            {
                if (s == phamilia)
                {
                    return true;
                }
            }
            return false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            end_redact();
            dataGridView_main.ReadOnly = true;
            redact = true;
        }
        private void статистикаПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stats_form statsForm = new stats_form();
            statsForm.ShowDialog();
        }
        private void dataGridView_main_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView_main.SelectedCells[0].ColumnIndex;
            int rowIndex = dataGridView_main.SelectedCells[0].RowIndex;
            if (columnIndex == 0)
            {

            }
            else
            {
                if ((string)dataGridView_main.CurrentCell.Value != "УП" && (string)dataGridView_main.CurrentCell.Value != "НП" && (string)dataGridView_main.CurrentCell.Value != "ПП") 
                {
                    MessageBox.Show("Установленно неверное значение. Допускается использование только след. параметров: \"УП\",\"НП\",\"ПП\".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView_main.CurrentCell.Value = current_cell_value;
                }
                else
                {
                    dataGridView_main.CurrentCell.Style.BackColor = Color.Yellow;
                    string column_header = (string)dataGridView_main.Rows[rowIndex].Cells[0].Value;
                    string columns_HeaderText = "[" + dataGridView_main.Columns[columnIndex].HeaderText + "]";
                    changeCommand("UPDATE " + column_header + " SET " + columns_HeaderText + " = N'" + dataGridView_main.CurrentCell.Value + "' WHERE Дата = '" + selected_date + "'");
                }
            }
        }
        private void dataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            current_cell_value = (string)dataGridView_main.CurrentCell.Value;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_form newForm = new about_form();
            newForm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            diagrama diag_form = new diagrama(dataGridView_main);
            diag_form.ShowDialog();
        }

        private void changeCommand(string commadlet)
        {
            connection_main.Open();
            SqlCommand command = new SqlCommand(commadlet, connection_main);
            command.ExecuteNonQuery();
            connection_main.Close();
        }
    }
}
