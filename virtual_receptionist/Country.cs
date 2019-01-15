using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region Konstruktor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">Ország kódja</param>
        /// <param name="name">Ország neve</param>
        public Country(string code, string name)
        {
            this.code = code;
            this.name = name;
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

        public override string ToString()
        {
            return $"{code} {name}";
        }

        #endregion
    }
}
