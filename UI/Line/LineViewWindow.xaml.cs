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
using System.Collections.ObjectModel;

namespace UI
{
    /// <summary>
    /// Interaction logic for LineViewWindow.xaml
    /// </summary>
    public partial class LineViewWindow : Window
    {
        IBL bl;
        BO.Line myLine;
        BO.Station myStation;
        public static ObservableCollection<BO.Station> myCollection { get; set; }

        public LineViewWindow(IBL _bl, BO.Line line)
        {
            InitializeComponent();
            bl = _bl;
            myLine = line;
            grid1Line.DataContext = myLine;
            areaComboBox.ItemsSource = Enum.GetValues(typeof(BO.Areas));

            myCollection = new ObservableCollection<BO.Station>(bl.GetAllStationsInThisLine(myLine));

            myLine.ListOfStationsInThisLine = bl.GetAllStationsInThisLine(myLine);
            
            listOfStationsInThisLineListBox.ItemsSource = myCollection;

            firstStationComboBox.ItemsSource = myLine.ListOfStationsInThisLine;
            firstStationComboBox.SelectedIndex = 0;

            lastStationComboBox.ItemsSource = myLine.ListOfStationsInThisLine;
            lastStationComboBox.SelectedIndex = myLine.ListOfStationsInThisLine.Count() - 1;

            listBoxStation.ItemsSource = bl.GetAllStations();
        }


        void RefreshListOfStationInThisLine(BO.Line line)
        {
            
            listOfStationsInThisLineListBox.ItemsSource = bl.GetAllStationsInThisLine(line);
        }

        private void addStation_Click(object sender, RoutedEventArgs e)
        {
           
            listBoxStation.Visibility = Visibility.Visible;
            btnAddThisStation.Visibility = Visibility.Visible;
            lblHide.Visibility = Visibility.Visible;
            
        }

        private void deleteStation_Click(object sender, RoutedEventArgs e)
        {
            BO.Station stationToDel = (BO.Station) listOfStationsInThisLineListBox.SelectedItem;
            try
            {
                bl.DeleteStationInALine(stationToDel.Code, myLine);
                
                RefreshListOfStationInThisLine(myLine);
            }
            catch (BO.BadStationException ex)
            {
                MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Failure ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
        /// <summary>
        /// add a station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BO.Station stationPrev = (BO.Station)listOfStationsInThisLineListBox.SelectedItem;
            myStation = (BO.Station)listBoxStation.SelectedItem;

            if (myStation == null || stationPrev == null)
            {
                MessageBox.Show("you didn't choose a station ☹️", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                try
                {
                    bl.AddAStationInALine(myStation, myLine, stationPrev);
                    
                    RefreshListOfStationInThisLine(myLine);


                    listBoxStation.Visibility = Visibility.Hidden;
                    btnAddThisStation.Visibility = Visibility.Hidden;
                    lblHide.Visibility = Visibility.Hidden;

                }
                catch (BO.BadStationException ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (BO.StationsInThisLine ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }

        private void updateLine_Click(object sender, RoutedEventArgs e)
        {
            string codeStr = this.codeTextBox.Text.ToString();

            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("you didn't fill in a field 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int.TryParse(codeStr, out int codeInt);


                BO.Station fS = (BO.Station)firstStationComboBox.SelectedItem;
                BO.Station lS = (BO.Station)lastStationComboBox.SelectedItem;

                BO.Line lineToUpdate = new BO.Line
                {
                    Id = myLine.Id,
                    Code = codeInt,
                    Area = (BO.Areas)areaComboBox.SelectedItem,
                    FirstStation = fS.Code,
                    LastStation = lS.Code,
                   // ListOfStationsInThisLine = myLine.ListOfStationsInThisLine
                };

                myLine = lineToUpdate;

                try
                {
                    bl.UpdateLine(myLine);
                    bl.UpdateFirstStation(myLine, fS);
                    bl.UpdateLastStation(myLine, lS);
                    RefreshListOfStationInThisLine(myLine);
                }
                catch (BO.BadLineException ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }
    }
}
