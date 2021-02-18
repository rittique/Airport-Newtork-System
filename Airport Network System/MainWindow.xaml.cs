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
using MySql.Data.MySqlClient;
using System.Data;

namespace Airport_Network_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginbtn(object sender, RoutedEventArgs e)
        {
            Connect conn = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            string query = "SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = userIDtxtbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordtxtBox.Password;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Home hm = new Home();
                hm.Show();
            }
            else
            {
                if (userIDtxtbox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your User ID to Login", "Empty User ID", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (passwordtxtBox.Password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("This User ID or Password is incorrect", "Wrong Input", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }

        

        

        
    }
}
