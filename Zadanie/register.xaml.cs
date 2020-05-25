using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Zadanie
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (txtPasswor.Password == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (txtCpnfirmPasswor.Password == "")
            {
                MessageBox.Show("Повторите пароль");
                return;
            }

            if (cheekUser())
            {
                return;
            }

            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-L2ILJV8; Initial Catalog=LoginDB; Integrated Security=True");
                String query = "INSERT INTO tblUser (UserName, Password) VALUES (@log, @pass)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@log", SqlDbType.NVarChar).Value = txtUsername.Text;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtPasswor.Password;
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = txtCpnfirmPasswor.Password;
                sqlCon.Open();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");
                sqlCon.Close();
        }


        public Boolean cheekUser()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-L2ILJV8; Initial Catalog=LoginDB; Integrated Security=True");
            String query = "SELECT * FROM tblUser WHERE Username=@Username";
            SqlCommand command = new SqlCommand(query, sqlCon);
            command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
                return false;
        }
    }
}
