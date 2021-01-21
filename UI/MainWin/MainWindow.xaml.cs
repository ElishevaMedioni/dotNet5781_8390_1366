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
using BLAPI;

using System.Text.RegularExpressions;


namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBL bl = BLFactory.GetBL("1");
        readonly System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MainWindow()
        {

            InitializeComponent();
            player.SoundLocation = @"C:\Users\keren\source\repos\ElishevaMedioni\dotNet5781_8390_1366\UI\MainWin\Aluph3.wav"; 


        }


        private void TabItem_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            //Content = ;
        }

        private void ListViewBus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewStation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            StationWindow secondWindow = new StationWindow(bl);
            secondWindow.Show();


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            LineWindow thirdWindows = new LineWindow(bl);
            thirdWindows.Show();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FirstWindow fiveWindow = new FirstWindow(bl);
            fiveWindow.Show();


        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            BusWindow1 fouthWindows = new BusWindow1(bl);
            fouthWindows.Show();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/keren-samama-aa9a28180");
        }

        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://linkedin.com/in/elisheva-medioni-0b2b871b3");
        }
    }
}
