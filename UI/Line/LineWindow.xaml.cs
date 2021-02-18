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
using System.Windows.Threading;
using System.Threading;
using System.Collections.ObjectModel;


namespace UI
{
    /// <summary>
    /// Interaction logic for LineWindow.xaml
    /// </summary>
    public partial class LineWindow : Window
    {
        IBL bl;
        //BO.Line myLine;
        public static ObservableCollection<BO.Line> myCollection { get; set; }


        public LineWindow(IBL _bl)
        {
            InitializeComponent();
            bl = _bl;

            myCollection = new ObservableCollection<BO.Line>(bl.GetAllLine());
            ListViewLine.ItemsSource = myCollection;

            areaComboBox.ItemsSource = Enum.GetValues(typeof(BO.Areas));
           

        }
        /// <summary>
        /// button update line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BO.Line line = ListViewLine.SelectedItem as BO.Line;

            if (line != null)
            {
                LineViewWindow win = new LineViewWindow(bl, line);
                win.ShowDialog();
            }
        }

        /// <summary>
        /// button delete line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BO.Line line = ListViewLine.SelectedItem as BO.Line;

            if (line != null)
            {
                try
                {
                    bl.DeleteLine(line);
                    myCollection.Remove(line);
                }
                catch (BO.BadLineException ex)
                {
                    MessageBox.Show(ex.Message, "Operation Failure", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        /// <summary>
        /// button add line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddLineWindow win = new AddLineWindow(bl);
            win.Show();
        }

        /// <summary>
        /// when you double click on each item, you open a new window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewLine_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BO.Line line = ListViewLine.SelectedItem as BO.Line;


            if (line != null)
            {
                Line.LineDoubleClickWin win = new Line.LineDoubleClickWin(bl, line);
                win.Show();
            }
           
        }

        private void areaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BO.Areas area = (BO.Areas)areaComboBox.SelectedItem;
            ListViewLine.ItemsSource = bl.ReturnTheLineByArea(area);
        }
    }
}

