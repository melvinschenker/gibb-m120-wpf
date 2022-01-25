namespace M120Projekt
{
    static class APIDemo
    {
        #region GamesA
        // Create
        public static void DemoACreate()
        {
            //Debug.Print("--- DemoACreate ---");
            //// GamesA
            //Data.Games gamesA1 = new Data.Games();
            //gamesA1.Name = "Test1";
            //gamesA1.Genre = "Genre1";
            //gamesA1.Erscheinungsjahr = DateTime.Now;
            //gamesA1.Konsole = "Konsole 1";
            //gamesA1.Zustand = "Zustand 1";
            //gamesA1.Kommentar = "Kommentar 1";
            //Int64 gamesA1Id = gamesA1.Erstellen();
            //Debug.Print("Artikel erstellt mit Id:" + gamesA1Id);
        }
        public static void DemoACreateKurz()
        {
            //Data.Games gamesA2 = new Data.Games { Name = "Game 2", Genre = "Artikel 2", Verfügbar = true, Erscheinungsjahr = DateTime.Today, Konsole = "Konsole 2", Zustand = "Zustand 2", Kommentar = "Kommentar 2" };
            //Int64 gamesA2Id = gamesA2.Erstellen();
            //Debug.Print("Artikel erstellt mit Id:" + gamesA2Id);
        }
        // Read
        public static void DemoARead()
        {
            //Debug.Print("--- DemoARead ---");
            //// Demo liest alle
            //foreach (Data.Games gamesA in Data.Games.LesenAlle())
            //{
            //    Debug.Print("Game Id:" + gamesA.GamesId + " Name:" + gamesA.Genre);
            //}
        }
        // Update
        public static void DemoAUpdate()
        {
            //Debug.Print("--- DemoAUpdate ---");
            // GamesA ändert Attribute
            //Data.Games gamesA1 = Data.Games.LesenID(1);
            //gamesA1.Genre = "Game 1 nach Update";
            //gamesA1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            //Debug.Print("--- DemoADelete ---");
            //Data.Games.LesenID(2).Loeschen();
            //Debug.Print("Game mit Id 2 gelöscht");
        }
        #endregion
    }
}
