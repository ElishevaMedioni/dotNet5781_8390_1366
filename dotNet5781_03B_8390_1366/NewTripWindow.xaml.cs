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
    /// Interaction logic for NewTripWindow.xaml
    /// </summary>
    public partial class NewTripWindow : Window
    {
        Bus newTripForThisBus;
        public NewTripWindow(Bus myBus)
        {
            InitializeComponent();
            newTripForThisBus = myBus;
           // kmForTheTrip.KeyDown += new KeyEventHandler(kmForTheTrip_KeyDown);
        }

        

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
                    MessageBox.Show("ERROR YOU NEED TO FILL OIL", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    newTripForThisBus.Status = "On refueling";

                }
                else if ((newTripForThisBus.GetNumTechnicalControl + kmFTT > 20000) || Math.Round(t.TotalDays) > 375)
                {
                    MessageBox.Show("YOU NEED TO DO TECHNICAL VERIFICATION", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                    newTripForThisBus.Status = "in traitement";

                }

                else if (newTripForThisBus.GetKmNumGas + kmFTT > 1200 && newTripForThisBus.GetNumTechnicalControl + kmFTT > 20000)
                    newTripForThisBus.Status = "in traitement";

                else
                {
                    newTripForThisBus.Status = "On the road";
                    newTripForThisBus.GetNumTechnicalControl += kmFTT;
                    newTripForThisBus.GetKmNumGas += kmFTT;
                    MessageBox.Show("THE NEW ITINERARY OF THE BUS HAS BEEN UPDATED SUCCESSFULLY FOR " + kmFTT + " kms","Important Message");
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
