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
using MySql.Data.MySqlClient;
using System.Data;

namespace Airport_Network_System
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        public Booking()
        {
            InitializeComponent();
        }
        passangerbooking panbk = new passangerbooking();

        Connect conn = new Connect();

        public bool insertBooking(String fid, String pname, String passpno, String pdob, String pcon, String pemail, String pgen)
        {
            MySqlCommand command = new MySqlCommand();
            string insertquery = "INSERT INTO `passanger_details`( `flight_id`, `name`, `passport_no`, `date_of_birth`, `contact_no`, `email`, `gender`) VALUES (@fid, @pnm, @pp, @dob, @con, @em, @gen)";
            command.CommandText = insertquery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@fid", MySqlDbType.VarChar).Value = fid;
            command.Parameters.Add("@pnm", MySqlDbType.VarChar).Value = pname;
            command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = passpno;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = pdob;
            command.Parameters.Add("@pcon", MySqlDbType.VarChar).Value = pcon;
            command.Parameters.Add("@pemail", MySqlDbType.VarChar).Value = pemail;
            command.Parameters.Add("@pgen", MySqlDbType.VarChar).Value = pgen;

            try
            {
                conn.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.closeConnection();
            }
            
            
        


            
            
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void detailsbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Details dt = new Details();
            dt.Show();
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Cancelling can = new Cancelling();
            can.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtfid.Text = "";
            txtname.Text = "";
            txtpassport.Text = "";
            txtdob.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtgender.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String fid = txtfid.Text;  
            String pname = txtname.Text;
            String ppno = txtpassport.Text;
            String pdob = txtdob.Text;
            String pcon = txtcontact.Text;
            String pemail = txtemail.Text;
            String pgen = txtgender.Text;

            


            if (pname.Trim().Equals("") || ppno.Trim().Equals("") || pcon.Trim().Equals("") || pemail.Trim().Equals("") || pgen.Trim().Equals(""))
            {
                MessageBox.Show("Recuired Fields - Name, Passport No. , Contact No. , Email, Gender", "Fileds Empty", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    Boolean insertbooking = panbk.insertBooking(fid, pname, ppno, pdob, pcon, pemail, pgen);

                    if (insertbooking)
                    {
                        MessageBox.Show("Flight Booked!", "Passanger Added", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error! Flight was not Booked", "Passanger not Added", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            

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
