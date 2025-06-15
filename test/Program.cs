using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static string Encrypt(string plainText, string password,
            string salt = "Kosher", string hashAlgorithm = "SHA1",
            int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
            int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }


        // Дешифрование
        public static string Decrypt(string cipherText, string password,
               string salt = "Kosher", string hashAlgorithm = "SHA1",
               int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
               int keySize = 256)
        {
            if (string.IsNullOrEmpty(cipherText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
    }
    public delegate void MyDelegate1(string connection_string, int number_of_users);
    public delegate void MyDelegate2();
}


//if (reader.HasRows)
//{
//    for (int i = 0; i < Number_of_users_inDB; i++)
//    {
//        Number_of_users_global = Number_of_users_inDB;
//        dataGridView_main.Rows.Add();
//        reader.Read();

//        for (int j = 0; j < 6; j++)
//        {
//            if (reader.IsDBNull(j))
//            {
//                dataGridView_main.Rows[i].Cells[j].Value = "NULL";
//                dataGridView_main.Rows[i].Cells[j].Style.BackColor = DB_Null_color;
//            }
//            else
//            {
//                dataGridView_main.Rows[i].Cells[j].Value = reader.GetValue(j);
//            }
//        }
//    }
//}
//else
//{
//    MessageBox.Show("Не удалось получить данные с таблицы. Возможно она пуста.",
//    "Ошибка",
//    MessageBoxButtons.OK,
//    MessageBoxIcon.Error);
//}


//if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
//{
//    MessageBox.Show("Одно или несколько из полей ввода авторизационных данных содержит недопустимые значения или они вовсе отсутствуют.", 
//        "Ошибка",
//        MessageBoxButtons.OK,
//        MessageBoxIcon.Error);
//}
//else
//{


//loading_start();
//string SQL_DB_login = textBox2.Text;
//string SQL_DB_password = textBox3.Text;
//string SQL_server_address = textBox1.Text;
//string SQL_DB_name = textBox4.Text;
//string connection_data = "Server=" + SQL_server_address + ";Database=" + SQL_DB_name + ";User Id=" + SQL_DB_login + ";Password=" + SQL_DB_password + ";Encrypt = false;MultipleActiveResultSets=True";
//string connection_data = "Server=185.125.203.94;Database=Standart_BD;User Id=user1;Password=yt65sa%Poiwy;Encrypt=false;MultipleActiveResultSets=True";
//SqlConnection connection = new SqlConnection(connection_data);
//string sqlExpression = "SELECT * FROM test";
//try
//{
//    connection.Open();
//    SqlCommand commandGetTable = new SqlCommand(sqlExpression, connection), commandGetCountOfUsers = new SqlCommand("select count(Фамилия) from test", connection);
//    SqlDataReader reader = commandGetTable.ExecuteReader();
//    //SqlAcceptReturN(reader,(int)commandGetCountOfUsers.ExecuteScalar());
//    reader.Close();
//    EnableButtons();
//    loading_end();
//    connection.Close();
//    this.Close();
//}
//catch (SqlException ex)
//{
//    MessageBox.Show("Не удалось установить соеденение с базой данных. Ниже приведенны подробности: \n\n" + ex.Message,
//    "Ошибка",
//    MessageBoxButtons.OK,
//    MessageBoxIcon.Error);
//}
//finally
//{
//    if (connection.State == ConnectionState.Open)
//    {
//        connection.Close();
//        loading_end();
//    }
//}
//}