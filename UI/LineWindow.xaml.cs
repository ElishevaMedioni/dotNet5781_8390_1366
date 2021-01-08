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
using System.Collections.ObjectModel;
using System.Windows.Threading;
using System.Threading;
using System.Drawing;
using System.ComponentModel;
using BLAPI;
namespace UI
{
    /// <summary>
    /// Interaction logic for LineWindow.xaml
    /// </summary>
    public partial class LineWindow : Window
    {
        IBL bl = BLFactory.GetBL("1");
        Line current;
        public static List<Line> line = new List<Line>();
        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer tiimer = new DispatcherTimer();
        public static ObservableCollection<Line> myCollection { get; set; } = new ObservableCollection<Line>(line);
      
        public LineWindow()
        {
            InitializeComponent();


            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            List<Line> liine = (List<Line>)bl.GetAllLine();
            foreach (var item in liine)
            {
                myCollection.Add(item);
            }

            myListView.ItemsSource = myCollection;











            void timer_Tick(object sender, EventArgs e)
            {
                Thread.Sleep(1);
                lblTime.Content = DateTime.Now.ToLongTimeString();

            }

















        }
    }

