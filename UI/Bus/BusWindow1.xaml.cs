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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using System.Threading;
using System.Drawing;
using System.ComponentModel;
using BO;
using BLAPI;

namespace UI
{
    /// <summary>
    /// Logique d'interaction pour BusWindow1.xaml
    /// </summary>
    public partial class BusWindow1 : Window
    {
        private readonly IBL bl3;
        BO.Bus myBus2;


        public static ObservableCollection<BO.Bus> myCollection { get; set; }

        public BusWindow1(IBL _bl)
        {
            InitializeComponent();


            bl3 = _bl;
            myCollection = new ObservableCollection<BO.Bus>(bl3.GetAllBus());
            ListViewBus.ItemsSource = myCollection;
            DataContext = ListViewBus;

         }


        private void Button_Click_1(object sender, RoutedEventArgs e)//refuel
        {

            myBus2 = (BO.Bus)ListViewBus.SelectedItem;
            if (sender != null && sender is Button btn)
                myBus2 = (BO.Bus)btn.DataContext;



            if (!CheckStatusForRefuel()) { }
            else
            {
                myBus2.Status = BO.BusStatus.OnRefueling;

                new Thread(() =>
                {



                    Thread.Sleep(5000);
                    MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
                    myBus2.Status = BO.BusStatus.Ready;
                    myBus2.FuelRemain = 0;

                }).Start();


                myBus2.GasolineLevel = 100;
                ListViewBus.Items.Refresh();

            }








        }


        private void Button_Click_2(object sender, RoutedEventArgs e) // verification
        {
            myBus2 = (BO.Bus)ListViewBus.SelectedItem;
            if (sender != null && sender is Button btn)
                myBus2 = (BO.Bus)btn.DataContext;
            ListViewBus.Items.Refresh();


            if (!CheckStatusForTechnicalVerification()) { }

            else
            {
                myBus2.Status = BO.BusStatus.InTraitement;
                new Thread(() =>
                {
                    MessageBox.Show("On Verification... please wait");
                    Thread.Sleep(5000);// 24hin second*(ms==>s)
                    myBus2.Status = BO.BusStatus.Ready;
                    myBus2.FromDate = DateTime.Now;
                    myBus2.TotalTrip = 0;
                }).Start();


                this.Close();
            }




        }







        private void Button_Click_3(object sender, RoutedEventArgs e)//lets start
        {

            if (sender != null && sender is Button btn)
                myBus2 = (BO.Bus)btn.DataContext;
            ListViewBus.Items.Refresh();

            if (!CheckStatusForTravel()) { }

            else
            {

                AddBus sixthWindows = new AddBus(bl3, myBus2);
                sixthWindows.Show();


                ListViewBus.Items.Refresh();
            }

       


        }

        public void RefreshListOfBus()
        {
            ListViewBus.ItemsSource = bl3.GetAllBuses(myBus2);

        }
















        private void ListViewBus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BO.Bus bus = (BO.Bus)ListViewBus.SelectedItem;
            ListViewBus.Items.Refresh();
        }


        private void ListViewBus_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        public bool CheckStatusForRefuel()
        {
            ListViewBus.Items.Refresh();

            if ((myBus2.Status == BO.BusStatus.OnRefueling))
            {
                MessageBox.Show("ERROR: The bus is already on refueling");
                return false;
            }

            else if ((myBus2.Status == BO.BusStatus.NeedVerification))
            {
                MessageBox.Show("You can't refuel, the bus has to do a technical verification before");
                return false;
            }



            else if ((myBus2.Status == BO.BusStatus.InTraitement))
            {
                MessageBox.Show("You can't refuel, the bus is on verification");
                return false;
            }


            else if ((myBus2.Status == BO.BusStatus.OnTheRoad))
            {
                MessageBox.Show("You can't refuel, the bus is on the road again");
                return false;

            }
            return true;
        }



        private bool CheckStatusForTravel()
        {

            if ((myBus2.Status == BO.BusStatus.OnRefueling))
            {
                MessageBox.Show("You can't travelled, the bus is on refueling");
                return false;
            }




            else if ((myBus2.Status == BO.BusStatus.InTraitement))
            {
                MessageBox.Show("You can't travelled, the bus is on verification");
                return false;
            }


            else if ((myBus2.Status == BO.BusStatus.OnTheRoad))
            {
                MessageBox.Show("You can't travelled, the bus is on the road again");
                return false;

            }


            else if ((myBus2.Status == BO.BusStatus.NeedToRefuel))
            {
                MessageBox.Show("You can't travel, the bus has to be refulled");
                return false;
            }

            else if ((myBus2.Status == BO.BusStatus.NeedVerification))
            {
                MessageBox.Show("You can't travel, the bus has to do technical verification ");
                return false;
            }
            return true;
        }

        private bool CheckStatusForTechnicalVerification()
        {

            if ((myBus2.Status == BO.BusStatus.OnRefueling))
            {
                MessageBox.Show("You can't do a technical verification, the bus is on refueling");
                return false;
            }

            else if ((myBus2.Status == BO.BusStatus.NeedToRefuel))
            {
                MessageBox.Show("You can't do a technical verification, the bus has to be refulled");
                return false;
            }


            else if ((myBus2.Status == BO.BusStatus.InTraitement))
            {
                MessageBox.Show("You can't do a technical verification, the bus is already on verification");
                return false;
            }


            else if ((myBus2.Status == BO.BusStatus.OnTheRoad))
            {
                MessageBox.Show("You can't do a technical verification, the bus is on the road again");
                return false;

            }
            return true;
        }








    }
}