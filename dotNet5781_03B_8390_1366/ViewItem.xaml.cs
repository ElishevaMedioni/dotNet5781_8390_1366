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

namespace dotNet5781_03B_8390_1366
{
    /// <summary>
    /// Interaction logic for ViewItem.xaml
    /// </summary>
    public partial class ViewItem : Window
    {
        public Bus myBus;
        public ViewItem(Bus busClicked)
        {
            InitializeComponent();
            
            BusDetails.Text = busClicked.ToString();
            myBus = busClicked;
        }

        private void Button_Click(object sender, RoutedEventArgs e) //event of technical control button
        {

            //ici  on fait fonctionner la fonction pour faire le controle technique


            //NewTripWindow secondWindow = new NewTripWindow(myBus);
            //secondWindow.Show();
            //this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//button refuel
        {
            myBus.GetKmNumGas = 0;
            MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
            this.Close();
            
        }
    }
}
