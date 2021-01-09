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
using BLAPI;

namespace UI
{
    /// <summary>
    /// Interaction logic for StationWindow.xaml
    /// </summary>
    /// 
    public partial class StationWindow : Window
    {

        IBL bl;
        BO.Station myStation;

        public StationWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;

            ListViewStation.ItemsSource = bl.GetAllStations().ToList();
        }



        /// <summary>
        /// Button to add a station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStationWindow secondWindow = new AddStationWindow(bl);
            secondWindow.Show();
        }

        /// <summary>
        /// double click on station to see the details of the station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewStation_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        /// <summary>
        /// button to delete a station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// button to update a station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            myStation = (BO.Station)ListViewStation.SelectedItem;
            if (sender != null && sender is Button btn)
                myStation = (BO.Station)btn.DataContext;
            mapWindow secondWindow = new mapWindow(myStation);
            secondWindow.Show();
        }
    }
}
