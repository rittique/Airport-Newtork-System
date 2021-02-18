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
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        public Details()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void bookbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Booking bk = new Booking();
            bk.Show();
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Cancelling can = new Cancelling();
            can.Show();
        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void clearbtnfdetails_Click(object sender, RoutedEventArgs e)
        {
            searchboxfdetails.Text = "";
        }

        
        


        
    }
}
