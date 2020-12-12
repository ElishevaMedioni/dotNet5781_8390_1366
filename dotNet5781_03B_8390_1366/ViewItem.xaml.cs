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
using System.Windows.Threading;
using System.Threading;

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



            if (myBus.Status == "On Verification")
            {
                MessageBox.Show("ERROR: The bus is already in verification");
            }
            else
            {
                myBus.Status = "On Verification";
                new Thread(() =>
                {

                    MessageBox.Show("On Verification... please wait");
                    Thread.Sleep(24 * 3600 * 100);// 24hin second*(ms==>s)
                MessageBox.Show("The Verification fully Completed", "Important Message");
                    myBus.Status = "Available";
                    myBus.DateOfTheLastTechnicalControl = DateTime.Now;
                    myBus.GetNumTechnicalControl = 0;

                }).Start();


            }
            this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//button refuel
        {
            if (myBus.Status == "On Refueling")
            {
                MessageBox.Show("ERROR: The bus is already On Refueling");
            }
            else
            {
                myBus.Status = "On Refueling";
                new Thread(() =>
                {


                    
                    Thread.Sleep(2 * 3600 * 100);// 2h in second*(ms==>s)
                MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
                    myBus.Status = "Available";
                    myBus.GetKmNumGas = 0;
                }).Start();

            }
           
            this.Close();
            
        }
    }
}
