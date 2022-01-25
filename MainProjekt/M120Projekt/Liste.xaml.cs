using M120Projekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für Liste.xaml
    /// </summary>
    public partial class Liste : UserControl
    {
        private List<GamesOverview> gameListe;
        public Liste()
        {
            InitializeComponent();
            //daten vorbereiten
            datenRefresh();
        }

        public void datenRefresh()
        {
            List<Games> gameListeDb = Games.LesenAlle();
            gameListe = new List<GamesOverview>();

            foreach (Games game in gameListeDb)
            {
                GamesOverview gameKurz = new GamesOverview();
                gameKurz.SetGamesId(game.GamesId);
                gameKurz.Name = game.Name;
                gameKurz.Konsole = game.Konsole;
                gameKurz.Verfügbar = game.Verfügbar;
                gameListe.Add(gameKurz);

            }
            DataGridGame.ItemsSource = gameListe;

        }
        private void DataGridGame_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataGridGame.SelectedItem != null)
            {
                GamesOverview selectedGame = (GamesOverview)DataGridGame.SelectedItem;

                Window parentWindow = Application.Current.MainWindow;
                var gameDetailGrid = (Grid)parentWindow.FindName("GameDetailGrid");

                GameDetail gameDetail = new GameDetail(selectedGame.GetGamesId(), this);
                gameDetailGrid.Visibility = Visibility.Visible;
                gameDetailGrid.Children.Clear();
                gameDetailGrid.Children.Add(gameDetail);
            }
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            GamesOverview selectedGame = (GamesOverview)DataGridGame.SelectedItem;


            if (e.Key == Key.Subtract & selectedGame != null)
            {
                Games selectedGameId = Games.LesenID(selectedGame.GetGamesId());
                MessageBoxResult wirklichLöschen = MessageBox.Show("Wollen sie dieses Game wirklich löschen?", "Löschen", MessageBoxButton.YesNo);

                if (wirklichLöschen == MessageBoxResult.Yes)
                {
                    selectedGameId.Loeschen();
                    datenRefresh();
                    MessageBox.Show("Game wurde gelöscht");
                }
            }
        }
        private void DataGridGame_KeyDown(object sender, KeyEventArgs e)
        {
            GamesOverview selectedGame = (GamesOverview)DataGridGame.SelectedItem;

            if (e.Key == Key.Space)
            {
                Window parentWindow = Application.Current.MainWindow;
                var gameDetailGrid = (Grid)parentWindow.FindName("GameDetailGrid");

                GameDetail gameDetail = new GameDetail(selectedGame.GetGamesId(), this);
                gameDetailGrid.Children.Clear();
                gameDetailGrid.Children.Add(gameDetail);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(DataGridGame.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    GamesOverview p = o as GamesOverview;
                    if (t.Name == "txtId")
                        return (p.GamesId == Convert.ToInt32(filter));
                    return (p.Name.ToUpper().StartsWith(filter.ToUpper()));
                };
            }
        }
        private void menuItemDetails_Click(object sender, RoutedEventArgs e)
        {
            GamesOverview selectedGame = (GamesOverview)DataGridGame.SelectedItem;
            if (selectedGame == null) return;

            Window parentWindow = Application.Current.MainWindow;
            var gameDetailGrid = (Grid)parentWindow.FindName("GameDetailGrid");

            GameDetail gameDetail = new GameDetail(selectedGame.GetGamesId(), this);
            gameDetailGrid.Children.Clear();
            gameDetailGrid.Children.Add(gameDetail);
        }

        private void menuItemLöschen_Click(object sender, RoutedEventArgs e)
        {
            GamesOverview selectedGame = (GamesOverview)DataGridGame.SelectedItem;
            if (selectedGame == null) return;

            MessageBoxResult wirklichLöschen = MessageBox.Show("Wollen sie dieses Game wirklich löschen?", "Löschen", MessageBoxButton.YesNo);
            if (wirklichLöschen == MessageBoxResult.Yes)
            {
                Games game = Games.LesenID(selectedGame.GetGamesId());
                game.Loeschen();
                datenRefresh();

                MessageBox.Show("Game wurde gelöscht");
            }
        }
    }
}


