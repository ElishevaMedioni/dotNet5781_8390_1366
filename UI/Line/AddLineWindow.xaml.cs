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
    /// Interaction logic for AddLineWindow.xaml
    /// </summary>
    public partial class AddLineWindow : Window
    {

        IBL bl;
        public AddLineWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;

            
            areaComboBox.ItemsSource = Enum.GetValues(typeof(BO.Areas));
            firstStationComboBox.ItemsSource = bl.GetAllStations();
            lastStationComboBox.ItemsSource = bl.GetAllStations();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string codeStr = codeTextBox.Text.ToString();
            BO.Areas areaSelected = (BO.Areas)areaComboBox.SelectedItem;
            BO.Station firstS = (BO.Station)firstStationComboBox.SelectedItem;
            BO.Station lastS = (BO.Station)lastStationComboBox.SelectedItem;

            int.TryParse(codeStr, out int codeInt);
            if (String.IsNullOrEmpty(codeTextBox.Text) || firstS == null || lastS == null)
            {
                MessageBox.Show("you didn't fill in a field 🥺", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                
                BO.Line lineToAdd = new BO.Line
                {
                    Code = codeInt,
                    Area = areaSelected,
                    FirstStation = firstS.Code,
                    LastStation = lastS.Code
                };

                try
                {
                  int id = bl.AddLine(lineToAdd);
                    lineToAdd.Id = id;
                    bl.AddFirstAndLastStation(lineToAdd, firstS, lastS);
                    lineToAdd.ListOfStationsInThisLine = bl.GetAllStationsInThisLine(lineToAdd);
                    LineWindow.myCollection.Add(lineToAdd);
                    this.Close();
                }
                catch (BO.BadLineException ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}
