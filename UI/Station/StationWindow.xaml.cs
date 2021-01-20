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
        public static ObservableCollection<BO.Station> myCollection { get; set; } 

        public StationWindow(IBL _bl)
        {
            InitializeComponent();

           
            bl = _bl;
            myCollection = new ObservableCollection<BO.Station>(bl.GetAllStations());
            
            ListViewStation.ItemsSource = myCollection;
           
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
            myStation = (BO.Station)ListViewStation.SelectedItem;
            StationViewWindow secondWindow = new StationViewWindow(bl,myStation);
            secondWindow.Show();
           
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
        /// button to see in the map a station
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

        private void btnUpdateS_Click(object sender, RoutedEventArgs e)
        {
            myStation = ListViewStation.SelectedItem as BO.Station;

            if (myStation != null)
            {
                Station.UpdateStationWin win = new Station.UpdateStationWin(bl, myStation);
                win.Show();
            }
        }



        /// <summary>
        /// button to delete a station from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelS_Click(object sender, RoutedEventArgs e)
        {

            myStation = ListViewStation.SelectedItem as BO.Station;

            if (myStation != null)
            {
                MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to delete station " + myStation.Name + " ?" , "Sure?", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    
                    try
                    {
                        bl.DeleteStationInAllTheLines(myStation.Code);
                        myCollection.Remove(myStation);
                    }
                    catch (BO.BadStationException ex)
                    {
                        MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else if (dialogResult == MessageBoxResult.No)
                {
                    //do something else
                }
               
            }

            
        }
    }
}
