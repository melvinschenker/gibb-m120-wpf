using M120Projekt.Data;
using System.Windows;
using System.Windows.Input;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Aufruf diverse APIDemo Methoden
            APIDemo.DemoACreate();
            APIDemo.DemoACreateKurz();
            APIDemo.DemoARead();
            APIDemo.DemoAUpdate();
            APIDemo.DemoARead();
            APIDemo.DemoADelete();

            GameDetail gameDetail = new GameDetail();
            Thickness margin = gameDetail.Margin;
            margin.Left = 5;
            gameDetail.Margin = margin;

            GameDetailGrid.Children.Add(gameDetail);
        }

        private void helpButton_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hinzufügen: Öffnet Fenster zum Erstellen neuer Games \nLöschen: Game anklicken, danach auf den Löschen-Knopf klicken \nDetails: Doppelklick um detailierte Angaben zum Game zu sehen. Angaben können auch verändert werden.\n\nTastaturkürzel:\n+: Hinzufügen\n-: Löschen\nS: Refresh\nSpace: (als Doppelklick) detailierte Angaben zum Game zu sehen", "Help");
        }

        private void addGameButton_click(object sender, RoutedEventArgs e)
        {
            Hinzufuegen addGameWindow = new Hinzufuegen(GameListe);
            addGameWindow.Show();
        }

        private void löschenButton_click(object sender, RoutedEventArgs e)
        {
            GamesOverview clickedGame = (GamesOverview)GameListe.DataGridGame.SelectedItem;
            if (clickedGame == null) return;

            MessageBoxResult wirklichLöschen = MessageBox.Show("Wollen sie dieses Game wirklich löschen?", "Löschen", MessageBoxButton.YesNo);
            if (wirklichLöschen == MessageBoxResult.Yes)
            {
                Games game = Games.LesenID(clickedGame.GetGamesId());

                game.Loeschen();
                GameListe.datenRefresh();

                MessageBox.Show("Game wurde gelöscht");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            GameListe.datenRefresh();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Add & !GameListe.searchbox.IsFocused)
            {
                Hinzufuegen addGameWindow = new Hinzufuegen(GameListe);
                addGameWindow.Show();
            }
            if (e.Key == Key.S & !GameListe.searchbox.IsFocused)
            {
                GameListe.datenRefresh();
            }
            if (e.Key == Key.F1)
            {
                MessageBox.Show("Hinzufügen: Öffnet Fenster zum Erstellen neuer Games \nLöschen: Game anklicken, danach auf den Löschen-Knopf klicken \nDetails: Doppelklick um detailierte Angaben zum Game zu sehen. Angaben können auch verändert werden.\n\nTastaturkürzel:\n+: Hinzufügen\n-: Löschen\nS: Refresh\nSpace: (als Doppelklick) detailierte Angaben zum Game zu sehen", "Help");
            }
        }
    }
}
