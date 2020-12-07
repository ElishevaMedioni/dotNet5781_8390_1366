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
using System.Collections.ObjectModel;

namespace dotNet5781_03B_8390_1366
{
    /// <summary>
    /// Interaction logic for WindowToAddANewBus.xaml
    /// </summary>
    public partial class WindowToAddANewBus : Window
    {
       
        public WindowToAddANewBus()
        {
            InitializeComponent();
        }

        //public void myDate(object sender1, SelectionChangedEventArgs e)
        //{
        //    DateTime date = dateOfActivity.SelectedDate.Value;
            
        //}

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string item1 = this.txtLicenseNumber.Text.ToString();

            // DateTime date = myDate(sender, e);

            DateTime date = newDate.SelectedDate.Value;

            if (item1.Length <= 0)
                MessageBox.Show("Please fill the TextBox", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                

                //DateTime date = new DateTime(yearInt, monthInt, dayInt);

                int myLicenseNum = int.Parse(item1);


                if (MainWindow.buses.Exists(x => x.GetLicenseNum == myLicenseNum))
                    MessageBox.Show("This bus is already in the system", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


                else if (date.Year < 2018 && item1.Length == 7)
                {
                    Bus b1 = new Bus(myLicenseNum, date);
                    MainWindow.buses.Add(b1);

                    //ou vider les textBox ou fermer fenetre this.close()
                    this.txtLicenseNumber.Clear();
                    this.txtLicenseNumber.Focus();
                  
                }
                else if (date.Year > 2018 && item1.Length == 8)
                {

                    Bus b2 = new Bus(myLicenseNum, date);
                    MainWindow.buses.Add(b2);
                    this.txtLicenseNumber.Clear();
                    this.txtLicenseNumber.Focus();
                    
                
                }
                else
                { //if the license number format is wrong

                    MessageBox.Show("ERROR THE LICENSE NUMBER YOU ENTERED IS WRONG", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }

        }
    }
}
