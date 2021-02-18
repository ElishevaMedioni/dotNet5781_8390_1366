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
using GMap.NET.MapProviders;
using BLAPI;

namespace UI
{
    /// <summary>
    /// Interaction logic for StationViewWindow.xaml
    /// </summary>
    public partial class StationViewWindow : Window
    {
        BO.Station myStation;
        IBL bl;

        public StationViewWindow(IBL _bl, BO.Station sta)
        {
            InitializeComponent();
            bl = _bl;
            myStation = sta;

            codeTextBlock.Text = myStation.Code.ToString();
            latitudeTextBlock.Text = myStation.Latitude.ToString();
            longitudeTextBlock.Text = myStation.Longitude.ToString();
            nameTextBlock.Text = myStation.Name;
            
            myStation.LinesPassingAtThisStation = bl.GetAllLinesPassingAtThisStation(myStation);
            
            grid1.DataContext = myStation.LinesPassingAtThisStation;
            

            map.DragButton = MouseButton.Left;

            map.MapProvider = GMapProviders.GoogleMap;

            map.Position = new GMap.NET.PointLatLng(myStation.Latitude, myStation.Longitude);
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 15;



        }

       
    }
}
