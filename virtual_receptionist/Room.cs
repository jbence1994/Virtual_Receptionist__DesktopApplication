using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
    public class Room
    {
        #region Adattagok

        /// <summary>
        /// Szoba elnevezése/fantázianeve
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

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Room osztály konstruktora
        /// </summary>
        /// <param name="name">Szoba elnevezése/fantázianeve</param>
        /// <param name="number">Szobaszám</param>
        /// <param name="category">Szobakategória</param>
        public Room(string name, int number, string category)
        {
            this.number = number;
            this.category = category;
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

        #endregion

        #region Metódusok

        /// <summary>
        /// Room osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Room típusú objektumot string típusra alakítva</returns>
        public override string ToString()
        {
            return name + " " + number + " " + category;
        }

        #endregion

    }
}
