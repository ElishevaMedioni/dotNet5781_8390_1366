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

//                    <GridViewColumn x:Name="TimerColumn" Header="Timer:"  DisplayMemberBinding="{Binding TargetNullValue}" Width="100"/>
namespace dotNet5781_03B_8390_1366
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    
    public partial class MainWindow : Window
         
    {
        Bus current;
        public static List<Bus> buses = new List<Bus>();
        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer tiimer = new DispatcherTimer();
        public static ObservableCollection<Bus> myCollection { get; set; } = new ObservableCollection<Bus>(buses);


        public MainWindow()
        {
            InitializeBus(myCollection);
            InitializeComponent();
            myListView.ItemsSource = myCollection;
         
            

            myListView.ItemsSource = myCollection;
           
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

         

        }

        /// <summary>
        /// function to initialise 10 buses
        /// </summary>
        /// <param name="collection"></param>
        public void InitializeBus(ObservableCollection<Bus> collection)
        {
            DateTime date1 = new DateTime(1993, 06, 01);
            DateTime date2 = new DateTime(2019, 06, 02);
            DateTime date3 = new DateTime(2020, 7, 03);
            DateTime date4 = new DateTime(2020, 8, 04);
            DateTime date5 = new DateTime(2020, 9, 05);
            DateTime date6 = new DateTime(2020, 10, 06);
            DateTime date7 = new DateTime(2020, 11, 07);
            DateTime date8 = new DateTime(2020, 5, 08);
            DateTime date9 = new DateTime(2020, 4, 09);
            DateTime date10 = new DateTime(2020, 3, 10);

            Bus bus1 = new Bus(33333333, date2, 1190, 1000);
            Bus bus2 = new Bus(22222222, date3, 888, 19990);
            Bus bus3 = new Bus(1111111, date1, 888, 9990);
            Bus bus4 = new Bus(44444444, date4, 111, 1111);
            Bus bus5 = new Bus(55555555, date5, 1234, 12345);
            Bus bus6 = new Bus(66666666, date6, 1990, 10456);
            Bus bus7 = new Bus(77777777, date7, 1098, 9670);
            Bus bus8 = new Bus(88888888, date8, 1678, 17563);
            Bus bus9 = new Bus(99999999, date9, 234, 8976);
            Bus bus10 = new Bus(1234567, date10, 987, 99);

            collection.Add(bus1);
            collection.Add(bus2);
            collection.Add(bus3);
            collection.Add(bus4);
            collection.Add(bus5);
            collection.Add(bus6);
            collection.Add(bus7);
            collection.Add(bus8);
            collection.Add(bus9);
            collection.Add(bus10);
        }
       
        
        void timer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            lblTime.Content = DateTime.Now.ToLongTimeString();

        }





        /// <summary>
        /// button to add a new bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowToAddANewBus secondWindow = new WindowToAddANewBus(); 
            secondWindow.Show();

        }


        /// <summary>
        /// double click on each bus to see all the details of the bus
        /// it is open a new window ViewItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) //doubleclick sur chaque bus, affiche fenetre ac pratim du bus
        {
            
            current = (Bus)myListView.SelectedItem;
            ViewItem secondWindow = new ViewItem(current);
            secondWindow.Show();
            myListView.Items.Refresh();
        }

        /// <summary>
        /// function to checks the status
        /// </summary>
        /// <returns></returns>
        private bool CheckStatusForTravel()
        {

            if ((current.Status == "On Refueling"))
            {
                MessageBox.Show("You can't travelled, the bus is on refueling");
                return false;
            }




            else if ((current.Status == "On Verification"))
            {
                MessageBox.Show("You can't travelled, the bus is on verification");
                return false;
            }


            else if ((current.Status == "On the road"))
            {
                MessageBox.Show("You can't travelled, the bus is on the road again");
                return false;

            }
            

              else if ((current.Status == "must refull"))
            {
                MessageBox.Show("You can't travel, the bus has to be refulled");
                return false;
            }

            else if ((current.Status == "must technical verification"))
            {
                MessageBox.Show("You can't travel, the bus has to do technical verification ");
                return false;
            }
            return true;
        }

        private bool CheckStatusForRefuel()
        {

            if ((current.Status == "On Refueling"))
            {
                MessageBox.Show("ERROR: The bus is already on refueling");
                return false;
            }

            else if ((current.Status == "must technical verification"))
            {
                MessageBox.Show("You can't refuel, the bus has to do a technical verification before");
                return false;
            }



            else if ((current.Status == "On Verification"))
            {
                MessageBox.Show("You can't refuel, the bus is on verification");
                return false;
            }


            else if ((current.Status == "On the road"))
            {
                MessageBox.Show("You can't refuel, the bus is on the road again");
                return false;

            }
            return true;
        }

        /// <summary>
        /// button New Trip for each bus
        /// Opens a new window NewTrip if the status of the bus is available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e) //boutton nouveau trajet a cote de chaque bus
        {

            if (sender != null && sender is Button btn)
                current = (Bus)btn.DataContext;


            if (CheckStatusForTravel())
            {
                NewTripWindow secondWindow = new NewTripWindow(current);
                secondWindow.Show();
                myListView.Items.Refresh();
            }

           
        }


        /// <summary>
        /// button refuel to each bus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click_2(object sender, RoutedEventArgs e) //bouton refuel a cote de chaque bus
        {
            if (sender != null && sender is Button btn)
                current = (Bus)btn.DataContext;
            
            
                
            if (CheckStatusForRefuel())
            {
                current.Status = "On Refueling";
                new Thread(() =>
                {



                    Thread.Sleep(2 * 3600 * 100);// 2h in second*(ms==>s)
                    MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
                    current.Status = "Available";
                    current.GetKmNumGas = 0;

                }).Start();
                current.GasolineLevel = 100;

                myListView.Items.Refresh();
            }


            
           
        }
    }
}