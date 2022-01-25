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

namespace B2_Kompetenzen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(TextBox1.Text == "")
            {
                Label1.Content = "Es wurde nichts eingegen";
                Label1.Background = new SolidColorBrush(Colors.Red);
                TextBlock1.Text = "Es wurde nichts eingegen";
            }
            else
            {
                Label1.Content = "Es wurde " + TextBox1.Text + " eingegeben";
                Label1.Background = new SolidColorBrush(Colors.Green);
                TextBlock1.Text = "Es wurde " + TextBox1.Text + " eingegeben";
            }
        }
    }
}
