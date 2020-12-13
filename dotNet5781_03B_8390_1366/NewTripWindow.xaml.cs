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
using System.Windows.Navigation;
using System.Collections.ObjectModel;


namespace dotNet5781_03B_8390_1366
{
    /// <summary>
    /// Interaction logic for NewTripWindow.xaml
    /// </summary>
    /// 


    public partial class NewTripWindow : Window
    {
        Bus newTripForThisBus;
        
        public NewTripWindow(Bus myBus)
        {
            InitializeComponent();
            newTripForThisBus = myBus;
            
        }


       
       
        /// <summary>
        /// event when the user taps a km for the trip and taps enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kmForTheTrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {




                string item = this.kmForTheTrip.Text.ToString();

                DateTime date1 = DateTime.Now;
                DateTime date2 = newTripForThisBus.DateOfTheLastTechnicalControl;
                TimeSpan t = date1 - date2;



                bool flag = int.TryParse(item, out int kmFTT);

                if (flag)
                {


                    


                     if (newTripForThisBus.GetKmNumGas + kmFTT > 1200)
                    {
                        newTripForThisBus.Status = "must refull";
                        MessageBox.Show("ERROR: Must fill the gas tank", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);



                    }


                    else if ((newTripForThisBus.GetNumTechnicalControl + kmFTT > 20000) || Math.Round(t.TotalDays) > 375)
                    {
                        newTripForThisBus.Status = "must technical verification";
                        MessageBox.Show("ERROR : You need to do Technical Verification", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);


                    }


                    else if (newTripForThisBus.GetKmNumGas + kmFTT > 1200 && newTripForThisBus.GetNumTechnicalControl + kmFTT > 20000)
                    {
                        newTripForThisBus.Status = " You need to do technical verification";
                    }

                    

                    else
                    {

                        newTripForThisBus.Status = "On the road";

                        new Thread(() =>
                        {
                            Random rr = new Random(DateTime.Now.Millisecond);

                            int speed = rr.Next(20, 50);
                            int tiime = (kmFTT / speed) * 6000 + (kmFTT % speed) * 100;
                            Thread.Sleep(tiime * 60);// *3600 to convert in second, *100 sleep is in ms and we want seconds
                            newTripForThisBus.Status = "Available";

                        }).Start();


                        newTripForThisBus.GetNumTechnicalControl += kmFTT;
                        newTripForThisBus.GetKmNumGas += kmFTT;
                        newTripForThisBus.GasolineLevel = ((1200 - newTripForThisBus.GetKmNumGas) * 100) / 1200;
                        MessageBox.Show("New Itinary has been uptaded successfully for: " + kmFTT + " kms", "Important Message");
                        
                        kmForTheTrip.Clear();

                    }

                }


                else
                {
                    MessageBox.Show("Wrong format for the number of km", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                

                this.Close();

            }

        }

    }
}

