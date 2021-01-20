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
using System.Text.RegularExpressions;
using BLAPI;

namespace UI
{
    /// <summary>
    /// Interaction logic for AddStationWindow.xaml
    /// </summary>
    public partial class AddStationWindow : Window
    {
        IBL bl;
        public AddStationWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;

        }

        /// <summary>
        /// function to accept only number in the textBox "Code"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// button add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string codeStr = this.codetxt.Text.ToString();
            string nameStr = this.nametxt.Text.ToString();
            string longitudeStr = this.longitudetxt.Text.ToString();
            string latitudeStr = this.latitudetxt.Text.ToString();

            int.TryParse(codeStr, out int codeInt);
            bool flag = double.TryParse(longitudeStr, out double longitudeDouble);
            bool flag1 = double.TryParse(latitudeStr, out double latitudeDouble);
            if (String.IsNullOrEmpty(codetxt.Text) || String.IsNullOrEmpty(nametxt.Text) || String.IsNullOrEmpty(longitudetxt.Text) || String.IsNullOrEmpty(latitudetxt.Text))
            {
                MessageBox.Show("you didn't fill in a field 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (flag && flag1)
                {
                    if ((longitudeDouble < 34.3 || longitudeDouble > 35.5) || (latitudeDouble < 31 || latitudeDouble > 33.3))
                    {
                        MessageBox.Show("The longitude or/and latitude format is wrong 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        longitudetxt.Clear();
                        latitudetxt.Clear();
                    }
                    else
                    {
                        BO.Station station = new BO.Station()
                        {
                            Code = codeInt,
                            Name = nameStr,
                            Longitude = longitudeDouble,
                            Latitude = latitudeDouble,
                        };
                        try
                        {
                            bl.AddStation(station);
                            StationWindow.myCollection.Add(station);
                            MessageBox.Show("Your station number " + codeInt + " has been added successfully 😀");
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
    }
}
