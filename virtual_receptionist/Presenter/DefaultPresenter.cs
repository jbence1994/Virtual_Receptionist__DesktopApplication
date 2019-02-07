using System.Windows.Forms;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Az alkalmazás prezentere, amely modell kezelésért és nézet frissítésért felel
    /// </summary>
    public class DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        protected DataRepository dataRepository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás prezenter konstruktora
        /// </summary>
        public DefaultPresenter()
        {
            dataRepository = new DataRepository();
        }

        #endregion
    }
}
