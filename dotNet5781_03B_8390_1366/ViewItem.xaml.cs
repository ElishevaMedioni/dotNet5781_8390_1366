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
using System.Drawing;
using System.ComponentModel;

namespace dotNet5781_03B_8390_1366
{
    /// <summary>
    /// Interaction logic for ViewItem.xaml
    /// </summary>
    public partial class ViewItem : Window
    {
        public Bus myBus;
        private DispatcherTimer tiimer = new DispatcherTimer();

        //tiimer.Interval = TimeSpan.FromSeconds(1);
        //    tiimer.Tick += timer_Tick;
        //    tiimer.Start();
        public ViewItem(Bus busClicked)
        {
            InitializeComponent();
            
            BusDetails.Text = busClicked.ToString();
            myBus = busClicked;
            pbStatus.Value = myBus.GasolineLevel;
            
        }

        private bool CheckStatusForTechnicalVerification()
        {

            if ((myBus.Status == "On Refueling"))
            {
                MessageBox.Show("You can't do a technical verification, the bus is on refueling");
                return false;
            }

            else if ((myBus.Status == "must refull"))
            {
                MessageBox.Show("You can't do a technical verification, the bus has to be refulled");
                return false;
            }

           
            else if ((myBus.Status == "On Verification"))
            {
                MessageBox.Show("You can't do a technical verification, the bus is already on verification");
                return false;
            }


            else if ((myBus.Status == "On the road"))
            {
                MessageBox.Show("You can't do a technical verification, the bus is on the road again");
                return false;

            }
            return true;
        }
        /// <summary>
        /// button technical control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e) 
        {
           if(!CheckStatusForTechnicalVerification())
            {

            }

            else
            {
                myBus.Status = "On Verification";
                new Thread(() =>
                {
                    MessageBox.Show("On Verification... please wait");
                    Thread.Sleep(24 * 3600 * 100);// 24hin second*(ms==>s)
                    myBus.Status = "Available";
                    myBus.DateOfTheLastTechnicalControl = DateTime.Now;
                    myBus.GetNumTechnicalControl = 0;
                }).Start();
            }
                

                this.Close();


        }

        /// <summary>
        /// button refuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
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

                    myBus.Status = "Available";
                    myBus.GetKmNumGas = 0;
                }).Start();

                myBus.GasolineLevel = 100;

            }
            

            this.Close();
            
        }
    }
}
