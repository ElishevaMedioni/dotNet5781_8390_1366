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
using BLAPI;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBL bl = BLFactory.GetBL("1");

        public MainWindow()
        {

            InitializeComponent();

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //StationWindow secondWindow = new StationWindow(bl);
            //secondWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //LineWindow thirdWindows = new LineWindow(bl);
            //thirdWindows.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //BusWindow1 fouthWindows = new BusWindow1(bl);
            //fouthWindows.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //FirstWindow fiveWindow = new FirstWindow(bl);
            //fiveWindow.Show();
        }

        private void TabItem_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            //Content = ;
        }

        private void ListViewBus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewStation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            StationWindow secondWindow = new StationWindow(bl);
            secondWindow.Show();

        }

        //private void Button_Click_7(object sender, RoutedEventArgs e)
        //{
        //    BusWindow1 fouthWindows = new BusWindow1(bl);
        //    fouthWindows.Show();
        //}

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FirstWindow fiveWindow = new FirstWindow(bl);
            fiveWindow.Show();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LineWindow sixWindow = new LineWindow(bl);
            sixWindow.Show();
        }
    }
}