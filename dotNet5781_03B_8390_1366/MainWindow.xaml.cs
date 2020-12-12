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


namespace dotNet5781_03B_8390_1366
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
         
    {
        Bus current;
       
        public static List<Bus> buses = new List<Bus>(); 
        public static ObservableCollection<Bus> myCollection { get; set; } = new ObservableCollection<Bus>(buses);
        private DispatcherTimer timer = new DispatcherTimer();
        
        public MainWindow()
        {
            InitializeBus(myCollection) ;
            InitializeComponent();
         
            myListView.ItemsSource = myCollection;


            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

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

        private void Button_Click(object sender, RoutedEventArgs e)//button to add a new bus
        {
            WindowToAddANewBus secondWindow = new WindowToAddANewBus(); 
            secondWindow.Show();

        }

       

        private void myListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) //doubleclick sur chaque bus, affiche fenetre ac pratim du bus
        {
            //if (myListView.SelectedItems.Count > 0)
            //    MessageBox.Show(myListView.SelectedItems[0].ToString());
            current = (Bus)myListView.SelectedItem;

            ViewItem secondWindow = new ViewItem(current);
            secondWindow.Show();
            
            myListView.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //boutton nouveau trajet a cote de chaque bus
        {
            if (sender != null && sender is Button btn)
                current = (Bus)btn.DataContext;
            //current = (Bus)myListView.SelectedItem;
            NewTripWindow secondWindow = new NewTripWindow(current);
            secondWindow.Show();
            myListView.Items.Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //bouton refuel a cote de chaque bus
        {
            if (sender != null && sender is Button btn)
                current = (Bus)btn.DataContext;
           // current = (Bus)myListView.SelectedItem;
            current.GetKmNumGas = 0;

            MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
            myListView.Items.Refresh();
            
        }
    }
}