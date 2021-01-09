using GMap.NET.MapProviders;
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
    /// Interaction logic for mapWindow.xaml
    /// </summary>
    public partial class mapWindow : Window
    {
        BO.Station myStation;
        public mapWindow(BO.Station station)
        {
            InitializeComponent();
            myStation = station;
            

            StationCode.Text = myStation.Code.ToString();
            StationName.Text = myStation.Name;
            map.DragButton = MouseButton.Left;

            map.MapProvider = GMapProviders.GoogleMap;

            map.Position = new GMap.NET.PointLatLng(myStation.Latitude, myStation.Longitude);
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 15;
        }

        

        
    }
}
