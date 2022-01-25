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

namespace AB120_03_Container
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_Canvas wmc1 = new Beispiele.Window_mit_Canvas();
            wmc1.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_WrapPanel wmwp1 = new Beispiele.Window_mit_WrapPanel();
            wmwp1.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_StackPanel wmsp1 = new Beispiele.Window_mit_StackPanel();
            wmsp1.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_Dockpanel wmdp1 = new Beispiele.Window_mit_Dockpanel();
            wmdp1.Show();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_Grid wmg1 = new Beispiele.Window_mit_Grid();
            wmg1.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Beispiele2.Window_Grid_1Stern wmgr1 = new Beispiele2.Window_Grid_1Stern();
            wmgr1.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Beispiele2.Window_Grid_2Sterne wmgr2 = new Beispiele2.Window_Grid_2Sterne();
            wmgr2.Show();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Beispiele2.Window_Grid_Auto wmga = new Beispiele2.Window_Grid_Auto();
            wmga.Show();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_ViewBox_Fill wvbs = new Beispiele.Window_mit_ViewBox_Fill();
            wvbs.Show();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_ViewBox_Uniform wvbu = new Beispiele.Window_mit_ViewBox_Uniform();
            wvbu.Show();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            Beispiele.Window_mit_ViewBox_Uniform_to_fill wvbun = new Beispiele.Window_mit_ViewBox_Uniform_to_fill();
            wvbun.Show();
        }
    }
}
