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


namespace dotNet5781_03B_8390_1366
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
         
    {
        public static List<Bus> buses = new List<Bus>();
        //static ListBuses buses = new ListBuses();
        public ObservableCollection<Bus> myCollection = new ObservableCollection<Bus>(buses);

        //
        public MainWindow()
        {
            Program.InitializeBus(buses);
            InitializeComponent();
            //cbBusLines.ItemsSource = buses;
            //cbBusLines.DisplayMemberPath = " GetBusLineNum ";
            //cbBusLines.SelectedIndex = 0;
            
            myListBox.ItemsSource = buses;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowToAddANewBus secondWindow = new WindowToAddANewBus(); 
            secondWindow.Show();

        }
    }
}