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
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Threading;
enum statuss {available, refueling,traitement }
namespace dotNet5781_03B_8390_1366
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        
        private DispatcherTimer timer = new DispatcherTimer();
        public static List<Bus> buses = new List<Bus>();
        //static ListBuses buses = new ListBuses();
        public ObservableCollection<Bus> myCollection = new ObservableCollection<Bus>(buses);
       
        //
        public MainWindow()
        {
            Program.InitializeBus(buses);
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
          
        }
   
        void timer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            lblTime.Content = DateTime.Now.ToLongTimeString();
          
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowToAddANewBus secondWindow = new WindowToAddANewBus();
            secondWindow.Show();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public void Refull()
        {
            if (Bus.status == 1)
            {
                new Thread(
                    () =>
                    {
                        Thread.Sleep(12000);
                        status = "availablzzzzze";
                    }
        ).Start();

            }
        }

    }
}