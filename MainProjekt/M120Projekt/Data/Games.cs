using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace M120Projekt.Data
{
    public class Games
    {
        #region Datenbankschicht
        [Key]
        public Int64 GamesId { get; set; }
        [Required]
        public String Genre { get; set; }
        [Required]
        public DateTime Erscheinungsjahr { get; set; }
        [Required]
        public Boolean Verfügbar { get; set; }
        [Required]
        public String Konsole { get; set; }
        [Required]
        public String Zustand { get; set; }
        public String Kommentar { get; set; }
        [Required]
        public String Name { get; set; }
        #endregion
        #region Applikationsschicht
        public Games() { }
        [NotMapped]
        public String BerechnetesAttribut
        {
            get
            {
                return "Im Getter kann Code eingefügt werden für berechnete Attribute";
            }
        }
        public static List<Games> LesenAlle()
        {
            using (var db = new Context())
            {
                return (from record in db.Games select record).ToList();
            }
        }
        public static Games LesenID(Int64 gamesAId)
        {
            using (var db = new Context())
            {
                return (from record in db.Games where record.GamesId == gamesAId select record).FirstOrDefault();
            }
        }
        public static List<Games> LesenAttributGleich(String suchbegriff)
        {
            using (var db = new Context())
            {
                return (from record in db.Games where record.Genre == suchbegriff select record).ToList();
            }
        }
        public static List<Games> LesenAttributWie(String suchbegriff)
        {
            using (var db = new Context())
            {
                return (from record in db.Games where record.Genre.Contains(suchbegriff) select record).ToList();
            }
        }
        public Int64 Erstellen()
        {
            //if (this.Genre == null || this.Genre == "") this.Genre = "leer";
            //if (this.Erscheinungsjahr == null) this.Erscheinungsjahr = DateTime.MinValue;
            using (var db = new Context())
            {
                db.Games.Add(this);
                db.SaveChanges();
                return this.GamesId;
            }
        }
        public Int64 Aktualisieren()
        {
            using (var db = new Context())
            {
                db.Entry(this).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return this.GamesId;
            }
        }
        public void Loeschen()
        {
            using (var db = new Context())
            {
                db.Entry(this).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public override string ToString()
        {
            return GamesId.ToString(); // Für bessere Coded UI Test Erkennung
        }
        #endregion        
    }
}
