
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

namespace dotNet5781_03A_8390_1366
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BusLine currentDisplayBusLine;
        static Random r = new Random();
        ListOfBusLines busLst = new ListOfBusLines();
        ListOfBusStation stationLst = new ListOfBusStation();
        
        public MainWindow()
        {
         
            Program.initialyseAddressAndBuses(stationLst, busLst);
        
            InitializeComponent();
            cbBusLines.ItemsSource = busLst;
            cbBusLines.DisplayMemberPath = " BusLineNum ";
            cbBusLines.SelectedIndex = 0;
        }

        private void cbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowBusLine((cbBusLines.SelectedValue as BusLine).GetBusLineNum);
        }

        private void ShowBusLine(int index)
        {
            currentDisplayBusLine = busLst.GetFirstBus();
            UpGrid.DataContext = currentDisplayBusLine;
            lbBusLineStations.DataContext = currentDisplayBusLine.GetBusStationLst;
        }

    }
}
