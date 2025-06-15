using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace test
{
    public partial class loading_form : Form
    {
        bool auth = false, complete = false;
        int max, tmp = 0;
        static SqlConnection connection_check;
        public loading_form(string stat, int time, bool auth)
        {
            InitializeComponent();
            label1.Text = stat; // Что происходит на экранне загрузки
            max = time; // Длительность загрузки
            this.auth = auth; // Требуется ли какая-либо авторизация
        }
        public void loading_form_easy(string stat)
        {
            InitializeComponent();
            label1.Text = stat; // Что происходит на экранне загрузки
        }
        public static void RetriveSQlConnection(string connection_string)
        {
            connection_check = new SqlConnection(connection_string);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tmp++;
            if (tmp % 2 == 0)
            {
                pictureBox1.Image = test.Properties.Resources.loading_DB_medium.ToBitmap();
            }
            else
            {
                pictureBox1.Image = test.Properties.Resources.loading_DB2.ToBitmap();
            }
            if (tmp == max)
            {
                if (this.auth == true)
                {
                    loading_SqlConnection();
                }
                else
                {
                    loading_done();
                    this.Close();
                }
            }
            else if (complete == true)
            {
                this.Close();
            }
        }

        private void loading_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //}
        }

        private async void loading_SqlConnection() // Првоерка подключения к MSSQL Server (базе данных)
        {
            try // Обработка исключений при подключении к БД
            {
                int counter_users;
                await connection_check.OpenAsync();
                pictureBox1.Image = test.Properties.Resources.done_medium.ToBitmap();
                label1.Text = "Готово!";
                using (SqlCommand cmdCount = new SqlCommand("select count(*) from test", connection_check)) // Сама функция свзяи с БД
                {
                    counter_users = (int)cmdCount.ExecuteScalar();
                }
                login_form.SqlConnectionStatus(true, counter_users); // Утсановка статуса подключения
                complete = true;
            }
            catch (SqlException ex)
            {
                label1.Text = "Ошибка!";
                pictureBox1.Image = test.Properties.Resources.error_medium.ToBitmap();
                timer1.Enabled = false;
                MessageBox.Show("Не удалось установить соеденение с базой данных. Ниже приведенны подробности: \n\n" + ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                if (connection_check.State == ConnectionState.Open)
                {
                    connection_check.Close();
                }
                login_form.SqlConnectionStatus(false);
                this.Close();
            }
        }
        private void loading_done()
        {
            pictureBox1.Image = test.Properties.Resources.done_medium.ToBitmap();
            label1.Text = "Готово!";
        }
    }
}
