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

namespace UI
{
    /// <summary>
    /// Logique d'interaction pour FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        private readonly IBL bl2 = BLFactory.GetBL("1");

        public FirstWindow(IBL _bl)
        {
            InitializeComponent();
            bl2 = _bl;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}