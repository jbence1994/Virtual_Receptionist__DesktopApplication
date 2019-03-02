namespace virtual_receptionist.Model.ORM
{
    /// <summary>
    /// Ország egyed modell osztálya
    /// </summary>
    public class Country
    {
        #region Adattagok

        /// <summary>
        /// Ország neve
        /// </summary>
        private string name;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Country osztály konstruktora
        /// </summary>
        /// <param name="name">Ország neve</param>
        public Country(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Country osztály üres konstruktora
        /// </summary>
        public Country()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Ország neve
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Country osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Country típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name}";
        }

        #endregion
    }
}
