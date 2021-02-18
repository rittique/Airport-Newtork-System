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
    /// Interaction logic for Cancelling.xaml
    /// </summary>
    public partial class Cancelling : Window
    {
        public Cancelling()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            this.Show();
        }

        private void detailsbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Details dt = new Details();
            dt.Show();
        }

        private void bookbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Booking bk = new Booking();
            bk.Show();
        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void closingbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
