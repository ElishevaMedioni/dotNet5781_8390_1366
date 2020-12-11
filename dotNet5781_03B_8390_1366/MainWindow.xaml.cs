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
        public static ObservableCollection<Bus> myCollection = new ObservableCollection<Bus>(buses);
        private DispatcherTimer timer = new DispatcherTimer();
       

        public MainWindow()
        {
            Program.InitializeBus(buses);
            InitializeComponent();
             myListView.ItemsSource = buses;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
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

            current.Status = "On Refueling";
            new Thread(() =>
            {


                MessageBox.Show("On refueling", "Important Message");
                Thread.Sleep(2 * 3600 * 100);// 2h in second*(ms==>s)
                MessageBox.Show("The Refueling Was Successfully Completed", "Important Message");
                current.Status = "Available";
                current.GetKmNumGas = 0;
            }).Start();
          
            myListView.Items.Refresh();
            
        }
    }
}