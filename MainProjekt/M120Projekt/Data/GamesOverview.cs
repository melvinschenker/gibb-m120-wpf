using System;

namespace M120Projekt.Data
{
    public class GamesOverview
    {
        public Int64 GamesId;
        public String Name { get; set; }
        public String Konsole { get; set; }
        public Boolean Verfügbar { get; set; }

        public void SetGamesId(Int64 id)
        {
            this.GamesId = id;
        }
        public Int64 GetGamesId()
        {
            return this.GamesId;
        }
    }
}
