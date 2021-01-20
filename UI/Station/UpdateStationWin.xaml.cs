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

namespace UI.Station
{
    /// <summary>
    /// Interaction logic for UpdateStationWin.xaml
    /// </summary>
    public partial class UpdateStationWin : Window
    {
        IBL bl;
       
        BO.Station myStation;
        public UpdateStationWin(IBL _bl, BO.Station station)
        {
            InitializeComponent();
            bl = _bl;
            myStation = station;
            gridStation.DataContext = myStation;
            codeTextBlock.Text = myStation.Code.ToString();
            nameTextBox.Text = myStation.Name;
            latitudeTextBox.Text = myStation.Latitude.ToString();
            longitudeTextBox.Text = myStation.Longitude.ToString();
            linesPassingAtThisStationListBox.ItemsSource = myStation.LinesPassingAtThisStation;
        }

        

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string nameStr = this.nameTextBox.Text;

            string longitudeStr = this.longitudeTextBox.Text.ToString();
            string latitudeStr = this.latitudeTextBox.Text.ToString();

            bool flag = double.TryParse(longitudeStr, out double longitudeDouble);
            bool flag1 = double.TryParse(latitudeStr, out double latitudeDouble);

            if(!(flag && flag1))
            {
                MessageBox.Show("The longitude or/and latitude format is wrong 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                longitudeTextBox.Clear();
                latitudeTextBox.Clear();
            }
            else if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(latitudeTextBox.Text)|| String.IsNullOrEmpty(longitudeTextBox.Text))
            {
                MessageBox.Show("you didn't fill in a field 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                BO.Station stationToUpdate = new BO.Station
                {
                    Code = myStation.Code,
                    Name = nameStr,
                    Latitude = latitudeDouble,
                    Longitude = longitudeDouble,
                    LinesPassingAtThisStation = myStation.LinesPassingAtThisStation
                };

                try
                {
                    bl.UpdateStation(stationToUpdate);
                    this.Close();
                }
                catch (BO.BadStationException ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
