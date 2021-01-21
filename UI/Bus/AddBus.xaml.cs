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
using BLAPI;

namespace UI
{
    /// <summary>
    /// Logique d'interaction pour AddBus.xaml
    /// </summary>
    public partial class AddBus : Window
    {
        private BO.Bus myBus2;
        private readonly IBL bl;

        public AddBus(IBL _bl, BO.Bus baba)
        {
            InitializeComponent();
            bl = _bl;
            myBus2 = baba;
        }

        private void kmForTheTrip_TextChanged(object sender, TextChangedEventArgs e)
        {}

        private void kmForTheTrip_KeyDown(object sender, KeyEventArgs e)
        {
           myBus2 = bl.GetBus(myBus2.License);



            if (e.Key == Key.Return)
            {
                string kilometer = this.kmForTheTrip.Text.ToString();
                bool flag = int.TryParse(kilometer, out int kmFTT);




                DateTime date1 = DateTime.Now;
                DateTime date2 = myBus2.FromDate;
                 TimeSpan t = date1 - date2;

                if (String.IsNullOrEmpty(kilometer)) // si l'entree est false
                {
                    MessageBox.Show("you didn't fill in a field 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }


                if (flag)
                {

                    if (myBus2.FuelRemain + kmFTT > 1200)// si ca depasse les 1200 
                    {
                        myBus2.Status = BO.BusStatus.NeedToRefuel;
                        MessageBox.Show("ERROR: Must fill the gas tank", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }


                    else if ((myBus2.TotalTrip + kmFTT > 20000) || Math.Round(t.TotalDays) > 375)
                    {
                        myBus2.Status = BO.BusStatus.NeedVerification;
                        MessageBox.Show("ERROR : You need to do Technical Verification", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                    }


                    else if (myBus2.FuelRemain + kmFTT > 1200 && myBus2.TotalTrip + kmFTT + kmFTT > 20000)
                    {
                        myBus2.Status = BO.BusStatus.NeedVerification;
                        MessageBox.Show("ERROR : You need to do Technical Verification", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }




                    else
                    {

                        myBus2.Status = BO.BusStatus.OnTheRoad;


                        new Thread(() =>
                        {
                            Random rr = new Random(DateTime.Now.Millisecond);

                            int speed = rr.Next(20, 50);
                            int tiime = (kmFTT / speed) * 6000 + (kmFTT % speed) * 100;
                            Thread.Sleep(5000 / tiime * 60 );
                        }).Start();



                        myBus2.TotalTrip = myBus2.TotalTrip + kmFTT; 




                        myBus2.GasolineLevel = ((1200 - myBus2.FuelRemain) * 100) / 1200;
                        MessageBox.Show("New Itinary has been uptaded successfully for: " + kmFTT + " kms", "Important Message");

                        kmForTheTrip.Clear();
                        bl.UpdateBus(myBus2);


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