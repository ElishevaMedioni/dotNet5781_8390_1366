
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

        

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string item1 = this.txtLicenseNumber.Text.ToString();

           

            DateTime date = newDate.SelectedDate.Value;
            bool flag = int.TryParse(item1, out int myLicenseNum);

            if (flag==false)
            {
                MessageBox.Show("The License Number Format Is Wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.txtLicenseNumber.Clear();
            }
               
            else
            {
                
                if (MainWindow.buses.Exists(x => x.LicenseNum == myLicenseNum))
                    MessageBox.Show("This bus is already in the system", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


                else if (date.Year < 2018 && item1.Length == 7)
                {
                    Bus b1 = new Bus(myLicenseNum, date);
                    MainWindow.myCollection.Add(b1);
                    //MainWindow.buses.Add(b1);

                    //ou vider les textBox ou fermer fenetre this.close()
                    this.txtLicenseNumber.Clear();
                    this.txtLicenseNumber.Focus();
                  
                }
                else if (date.Year > 2018 && item1.Length == 8)
                {

                    Bus b2 = new Bus(myLicenseNum, date);
                    MainWindow.myCollection.Add(b2);
                    this.txtLicenseNumber.Clear();
                    this.txtLicenseNumber.Focus();
                    
                
                }
                else
                { //if the license number format is wrong

                    MessageBox.Show("ERROR: License number wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }

        }
    }
}
