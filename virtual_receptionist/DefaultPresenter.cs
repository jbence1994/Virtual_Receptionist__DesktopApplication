using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using virtual_receptionist.View;
using virtual_receptionist.Model;

namespace virtual_receptionist.SupervisingController
{
    /// <summary>
    /// Az alkalmazás prezenter osztálya, amely modell kezelésért és nézet frissítésért felel
    /// </summary>
    public partial class Presenter
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        private DataRepository dataRepository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Presenter()
        {
            dataRepository = new DataRepository();
        }

        #endregion
    }
}
