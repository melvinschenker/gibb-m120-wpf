using System;
using System.Windows;
using System.Windows.Controls;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für GameDetail.xaml
    /// </summary>
    public partial class GameDetail : UserControl
    {
        Data.Games selectedGame;
        Liste gameListe;

        public GameDetail()
        {
            InitializeComponent();
        }

        public GameDetail(Int64 gameId, Liste gameListe)
        {
            InitializeComponent();

            this.gameListe = gameListe;

            selectedGame = Data.Games.LesenID(gameId);

            GameDetailsGameName.Text = selectedGame.Name;
            GameDetailJahr.Text = selectedGame.Erscheinungsjahr.Year.ToString();
            GameDetailGenre.Text = selectedGame.Genre;
            GameDetailKonsole.Text = selectedGame.Konsole;

            if (selectedGame.Verfügbar)
            {
                VerfügbarRadioButton.IsChecked = true;
            }
            else
            {
                NichtVerfügbarRadioButton.IsChecked = true;
            }

            switch (selectedGame.Zustand)
            {
                case "Neu":
                    GameDetailZustand.SelectedIndex = 0;
                    break;
                case "Einwandfrei":
                    GameDetailZustand.SelectedIndex = 1;
                    break;
                case "leichte Gebrauchsspuren":
                    GameDetailZustand.SelectedIndex = 2;
                    break;
                case "starke Gebrauchsspuren":
                    GameDetailZustand.SelectedIndex = 3;
                    break;
                case "beschädigt":
                    GameDetailZustand.SelectedIndex = 4;
                    break;
                default:
                    break;
            }

            GameDetailKommentar.Text = selectedGame.Kommentar;

        }

        private void ÄnderungenSpeichernButton_click(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex yearCheckRegex = new System.Text.RegularExpressions.Regex(@"^\d\d\d\d$");


            bool nameCorrect = false;
            bool yearCorrect = false;
            bool genreCorrect = false;
            bool konsoleCorrect = false;

            if (!string.IsNullOrWhiteSpace(GameDetailsGameName.Text)) nameCorrect = true;
            if (yearCheckRegex.IsMatch(GameDetailJahr.Text)) yearCorrect = true;
            if (!string.IsNullOrWhiteSpace(GameDetailGenre.Text)) genreCorrect = true;
            if (!string.IsNullOrWhiteSpace(GameDetailKonsole.Text)) konsoleCorrect = true;

            if (nameCorrect & yearCorrect & genreCorrect & konsoleCorrect & selectedGame != null)
            {
                selectedGame.Name = GameDetailsGameName.Text;
                selectedGame.Erscheinungsjahr = new DateTime(int.Parse(GameDetailJahr.Text), 1, 1);
                selectedGame.Genre = GameDetailGenre.Text;
                selectedGame.Konsole = GameDetailKonsole.Text;
                selectedGame.Verfügbar = VerfügbarRadioButton.IsChecked == true ? true : false;
                selectedGame.Zustand = GameDetailZustand.Text;
                selectedGame.Kommentar = GameDetailKommentar.Text;
                selectedGame.Aktualisieren();

                MessageBox.Show("Änderungen gespeichert!");
                gameListe.datenRefresh();

            }
            else
            {
                string nameIncorrect = "";
                string yearIncorrect = "";
                string genreIncorrect = "";
                string konsoleIncorrect = "";

                if (!nameCorrect) nameIncorrect = "Name fehlt";
                if (!yearCorrect) yearIncorrect = "Erscheinungsjahr fehlt (YYYY)";
                if (!genreCorrect) genreIncorrect = "Genre fehlt";
                if (!konsoleCorrect) konsoleIncorrect = "Konsole fehlt";

                MessageBox.Show($"{nameIncorrect}\n{yearIncorrect}\n{genreIncorrect}\n{konsoleIncorrect}");
            }
        }
    }
}
