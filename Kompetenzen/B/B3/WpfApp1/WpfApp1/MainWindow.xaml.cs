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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(homeUC);

            GridContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0,255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
            ButtonContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(newsUC);

            GridContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
            ButtonContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
        }

        private void MusicButton_Click(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(musicUC);

            GridContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
            ButtonContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
        }

        private void GamesButton_Click(object sender, RoutedEventArgs e)
        {
            setActiveUserControl(gamesUC);

            GridContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
            ButtonContainer.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255)), Convert.ToByte(rnd.Next(0, 255))));
        }
        public void setActiveUserControl (UserControl control)
        {
            //COLAPSE ALL UCs
            homeUC.Visibility = Visibility.Collapsed;
            newsUC.Visibility = Visibility.Collapsed;
            musicUC.Visibility = Visibility.Collapsed;
            gamesUC.Visibility = Visibility.Collapsed;

            //SHOW CURRENT UC
            control.Visibility = Visibility.Visible;
        }
    }
}
