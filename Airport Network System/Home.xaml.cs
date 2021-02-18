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
using System.Windows.Shapes;

namespace Airport_Network_System
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closingbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void detailsbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Details dt = new Details();
            dt.Show();
        }

        private void bookbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Booking bk = new Booking();
            bk.ShowDialog();
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Cancelling can = new Cancelling();
            can.Show();
        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }


        

    }
}
