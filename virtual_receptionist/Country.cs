namespace virtual_receptionist.Model
{
    /// <summary>
    /// Országok modell osztálya
    /// </summary>
    public class Country
    {
        #region Adattagok

        /// <summary>
        /// Ország kódja
        /// </summary>
        private string code;
        /// <summary>
        /// Ország neve
        /// </summary>
        private string name;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Country osztály konstruktora
        /// </summary>
        /// <param name="code">Ország kódja</param>
        /// <param name="name">Ország neve</param>
        public Country(string code, string name)
        {
            this.code = code;
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
        /// Ország kódja
        /// </summary>
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        /// <summary>
        /// Ország neve
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Country osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Country típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{code} {name}";
        }

        #endregion
    }
}
