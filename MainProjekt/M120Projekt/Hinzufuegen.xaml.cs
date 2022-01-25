using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;


namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für Hinzufuegen.xaml
    /// </summary>
    public partial class Hinzufuegen : Window
    {
        Liste liste;
        public Hinzufuegen(Liste liste)
        {
            InitializeComponent();
            this.liste = liste;
        }

        private void cancelButton_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addGameButton_click(object sender, RoutedEventArgs e)
        {
            bool nameCorrect = false;
            bool yearCorrect = false;
            bool genreCorrect = false;
            bool konsoleCorrect = false;
            bool verfügbarkeitCorrect = false;
            bool zustandCorrect = false;

            Regex yearCheckRegex = new Regex(@"^\d\d\d\d$");

            //IF-ELSE Check Input on btn-click
            #region
            if (string.IsNullOrWhiteSpace(NameGame.Text) | NameGame.Text == "Feld ist leer!")
            {
                NameGame.Background = new SolidColorBrush(Colors.PaleVioletRed);
            }
            else
            {
                nameCorrect = true;
                NameGame.Background = new SolidColorBrush(Colors.White);
            }

            if (string.IsNullOrWhiteSpace(Erscheinungsjahr.Text) | !(yearCheckRegex.IsMatch(Erscheinungsjahr.Text)))
            {
                Erscheinungsjahr.Background = new SolidColorBrush(Colors.PaleVioletRed);
            }
            else
            {
                yearCorrect = true;
                Erscheinungsjahr.Background = new SolidColorBrush(Colors.White);
            }

            if (string.IsNullOrWhiteSpace(Genre.Text) | Genre.Text == "Feld ist leer!")
            {
                Genre.Background = new SolidColorBrush(Colors.PaleVioletRed);
            }
            else
            {
                genreCorrect = true;
                Genre.Background = new SolidColorBrush(Colors.White);
            }
            if (string.IsNullOrWhiteSpace(Konsole.Text) | Konsole.Text == "Feld ist leer!")
            {
                Konsole.Background = new SolidColorBrush(Colors.PaleVioletRed);
            }
            else
            {
                konsoleCorrect = true;
                Konsole.Background = new SolidColorBrush(Colors.White);
            }
            if (VerfügbarRadioButton.IsChecked == false && NichtVerfügbarRadioButton.IsChecked == false)
            {
                VerfügbarkeitError.Visibility = Visibility.Visible;
            }
            else
            {
                verfügbarkeitCorrect = true;
                VerfügbarkeitError.Visibility = Visibility.Hidden;
            }
            if (Zustand.SelectedIndex < 0)
            {
                ZustandError.Visibility = Visibility.Visible;
            }
            else
            {
                zustandCorrect = true;
                ZustandError.Visibility = Visibility.Hidden;
            }
            #endregion


            if (nameCorrect & yearCorrect & genreCorrect & konsoleCorrect & verfügbarkeitCorrect & zustandCorrect)
            {
                MessageBox.Show(NameGame.Text + " hinzugefügt");

                //CREATE
                #region
                Data.Games game = new Data.Games();
                game.Name = NameGame.Text;
                game.Erscheinungsjahr = new DateTime(int.Parse(Erscheinungsjahr.Text), 1, 1);
                game.Genre = Genre.Text;
                game.Konsole = Konsole.Text;
                game.Verfügbar = VerfügbarRadioButton.IsChecked == true ? true : false;
                game.Zustand = Zustand.Text;
                game.Kommentar = Kommentar.Text;
                game.Erstellen();
                #endregion

                //RESET
                #region       
                NameGame.Foreground = new SolidColorBrush(Colors.Black);
                NameGame.Background = new SolidColorBrush(Colors.White);
                Erscheinungsjahr.Foreground = new SolidColorBrush(Colors.Black);
                Erscheinungsjahr.Background = new SolidColorBrush(Colors.White);
                Genre.Foreground = new SolidColorBrush(Colors.Black);
                Genre.Background = new SolidColorBrush(Colors.White);
                Konsole.Foreground = new SolidColorBrush(Colors.Black);
                Konsole.Background = new SolidColorBrush(Colors.White);

                VerfügbarkeitError.Visibility = Visibility.Hidden;
                ZustandError.Visibility = Visibility.Hidden;

                NameGame.Text = "";
                Erscheinungsjahr.Text = "";
                Genre.Text = "";
                Konsole.Text = "";
                VerfügbarRadioButton.IsChecked = false;
                NichtVerfügbarRadioButton.IsChecked = false;
                Zustand.SelectedItem = "";
                Kommentar.Text = "";
                #endregion

                liste.datenRefresh();
            }
            else
            {
                MessageBox.Show("Siehe Fehlermeldungen");
                nameCorrect = false;
                yearCorrect = false;
                genreCorrect = false;
                konsoleCorrect = false;
                verfügbarkeitCorrect = false;
                zustandCorrect = false;
            }
        }
        //FOCUS-events
        #region
        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameGame.Text == "")
            {
                NameGame.Text = "Feld ist leer!";
                NameGame.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameGame.Text == "Feld ist leer!")
            {
                NameGame.Text = "";
                NameGame.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
        private void Erscheinungsjahr_LostFocus(object sender, RoutedEventArgs e)
        {
            Regex yearCheckRegex = new Regex(@"^\d\d\d\d$");
            if (!(yearCheckRegex.IsMatch(Erscheinungsjahr.Text)))
            {
                Erscheinungsjahr.Text = "Kein gültiges Format! (yyyy)";
                Erscheinungsjahr.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
        private void Erscheinungsjahr_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Erscheinungsjahr.Text == "Kein gültiges Format! (yyyy)")
            {
                Erscheinungsjahr.Text = "";
                Erscheinungsjahr.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void Genre_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Genre.Text == "")
            {
                Genre.Text = "Feld ist leer!";
                Genre.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void Genre_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Genre.Text == "Feld ist leer!")
            {
                Genre.Text = "";
                Genre.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void Zustand_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Zustand.SelectedIndex < 0)
            {
                ZustandError.Visibility = Visibility.Visible;
            }
        }

        private void Zustand_GotFocus(object sender, RoutedEventArgs e)
        {
            ZustandError.Visibility = Visibility.Hidden;
        }

        private void Konsole_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Konsole.Text == "")
            {
                Konsole.Text = "Feld ist leer!";
                Konsole.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void Konsole_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Konsole.Text == "Feld ist leer!")
            {
                Konsole.Text = "";
                Konsole.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
        #endregion

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                this.Close();
            }
        }
    }
}
