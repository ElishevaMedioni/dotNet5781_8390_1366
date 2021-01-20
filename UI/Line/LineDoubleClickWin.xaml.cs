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

namespace UI.Line
{
    /// <summary>
    /// Interaction logic for LineDoubleClickWin.xaml
    /// </summary>
    /// 

    public partial class LineDoubleClickWin : Window
    {


        IBL bl;
        BO.Line myLine;


        public LineDoubleClickWin(IBL _bl, BO.Line line)
        {
            InitializeComponent();
            bl = _bl;
            myLine = line;

            grid1.DataContext = myLine;
           
            listOfStationsInThisLineListBox.ItemsSource = myLine.ListOfStationsInThisLine;
            List <Double> listDistance = bl.GetDistanceStationList(myLine.ListOfStationsInThisLine);
            lstDistance.ItemsSource = listDistance;
            lstTime.ItemsSource = bl.GetTimeStationList(listDistance);
            
        }






    }
}
