namespace virtual_receptionist
{
    /// <summary>
    /// Szoba egyed modell osztálya
    /// </summary>
    public class Room
    {
        #region Adattagok

        /// <summary>
        /// Szoba elnevezése / fantázianeve
        /// </summary>
        private string name;
        /// <summary>
        /// Szobaszám
        /// </summary>
        private int number;
        /// <summary>
        /// Szobakategória
        /// </summary>
        private string category;
        /// <summary>
        /// Szoba kapacitása / maximális férőhelye
        /// </summary>
        private int capacity;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Room osztály konstruktora
        /// </summary>
        /// <param name="name">Szoba elnevezése / fantázianeve</param>
        /// <param name="number">Szobaszám</param>
        /// <param name="category">Szobakategória</param>
        /// <param name="capacity">Szoba kapacitása / maximális férőhelye</param>
        public Room(string name, int number, string category, int capacity)
        {
            this.number = number;
            this.category = category;
            this.capacity = capacity;
        }
        /// <summary>
        /// Room osztály üres konstruktora
        /// </summary>
        public Room()
        {

        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Szoba elnevezése/fantázianeve
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
        /// <summary>
        /// Szobaszám
        /// </summary>
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        /// <summary>
        /// Szobakategória
        /// </summary>
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        /// <summary>
        /// Szoba kapacitása / maximális férőhelye
        /// </summary>
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Room osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Room típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return name + " " + number + " " + category + " " + capacity;
        }

        #endregion
    }
}
