namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Szobakategória modell osztálya
    /// </summary>
    public class RoomCategory
    {
        #region Adattagok

        /// <summary>
        /// Szobakategória elnevezése
        /// </summary>
        private string name;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// RoomCategory osztály konstruktora
        /// </summary>
        /// <param name="name">Szobakategória neve</param>
        public RoomCategory(string name)
        {
            this.name = name;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Szobakategória neve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// RoomCategory osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Room típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name}";
        }

        #endregion
    }
}
