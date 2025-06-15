using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Properties;

namespace test
{
    public partial class login_form : Form
    {
        string connection_data;
        static bool succsess_connect1 = false;
        static int number_of_users;
        private MyDelegate1 SqlConnectionReturN;
        private MyDelegate2 EnableButtons;
        private void loading_start() // Анимация подключения к серверу
        {
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox2.Enabled = false;
            Thread.Sleep(1000);
            loading_form loadingForm = new loading_form("Попытка подключения к серверу...", 2, true);
            loading_form.RetriveSQlConnection(connection_data);
            loadingForm.ShowDialog();
        }
        private void loading_end() // Завершение Анимации подключения к серверу
        {
            button1.Enabled = true;
            button2.Enabled = true;
            pictureBox2.Enabled = true;
        }

        /// <summary>
        /// Заполняет форму если данные были предварительно сохранены (При первой авторизации был выбран параметр "Запомнить авторизационные данные")
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sender2"></param>
        public login_form(MyDelegate1 sender, MyDelegate2 sender2) // Конструктор формы
        {
            InitializeComponent();
            SqlConnectionReturN = sender;
            EnableButtons = sender2;

            if (Settings.Default["RememberPassword"].ToString() == "true")
            {
                checkBox1.Checked = true;
                textBox1.Text = Program.Decrypt(Settings.Default["SQL_DB_Address"].ToString(), "Qn8myrz");
                textBox2.Text = Program.Decrypt(Settings.Default["SQL_DB_Login"].ToString(), "Qn8myrz");
                textBox3.Text = "skajhdfkjahdjw";

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e) // Проверка именни и пользователя
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty) // Валидация полей
            {
                MessageBox.Show("Одно или несколько из полей ввода авторизационных данных содержит недопустимые значения или они вовсе отсутствуют.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else // Првоерка правильности авторизационных данных
            {
                string SQL_server_address = textBox1.Text;
                string SQL_DB_name = textBox4.Text;
                string SQL_DB_login = textBox2.Text;
                string SQL_DB_password = textBox3.Text;
                if (Settings.Default["RememberPassword"].ToString() == "true")
                {
                    SQL_DB_password = Program.Decrypt(Settings.Default["SQL_DB_Password"].ToString(), "Qn8myrz");
                    connection_data = "Server=" + Program.Decrypt(Settings.Default["SQL_DB_Address"].ToString(), "Qn8myrz") + ";Database=" + SQL_DB_name + ";User Id=" + Program.Decrypt(Settings.Default["SQL_DB_Login"].ToString(), "Qn8myrz") + ";Password=" + Program.Decrypt(Settings.Default["SQL_DB_Password"].ToString(), "Qn8myrz") + ";Encrypt = false;MultipleActiveResultSets=True";
                }
                else
                {
                    connection_data = "Server=" + SQL_server_address + ";Database=" + SQL_DB_name + ";User Id=" + SQL_DB_login + ";Password=" + SQL_DB_password + ";Encrypt = false;MultipleActiveResultSets=True";
                }
                loading_start();
                if (succsess_connect1 == true)
                {
                    loading_end();
                    if (checkBox1.Checked == true)
                    {
                        Settings.Default["SQL_DB_Address"] = Program.Encrypt(SQL_server_address, "Qn8myrz");
                        Settings.Default["SQL_DB_Login"] = Program.Encrypt(SQL_DB_login, "Qn8myrz");
                        Settings.Default["SQL_DB_Password"] = Program.Encrypt(SQL_DB_password, "Qn8myrz");
                        Settings.Default["RememberPassword"] = "true";
                        Settings.Default.Save();
                    }
                    SqlConnectionReturN(connection_data, number_of_users);
                    this.Close();
                }
                else
                {
                    loading_end();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void SqlConnectionStatus(bool succsess_connect, int number)
        {
            succsess_connect1 = succsess_connect;
            number_of_users = number;
        }
        public static void SqlConnectionStatus(bool succsess_connect)
        {
            succsess_connect1 = succsess_connect;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Блокировка полей, в случаее если логин и пароль были сохранены
        {
            if (checkBox1.Checked == false)
            {
                if (Settings.Default["RememberPassword"].ToString() == "true")
                {
                    Settings.Default["RememberPassword"] = "false";
                    Settings.Default["SQL_DB_Address"] = null;
                    Settings.Default["SQL_DB_Login"] = null;
                    Settings.Default["SQL_DB_Password"] = null;
                    Settings.Default.Save();
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                }
            }
        }
    }
}
