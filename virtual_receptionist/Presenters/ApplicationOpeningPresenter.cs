using System.Windows.Forms;
using System;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Nyitóablak prezentere
    /// </summary>
    public class ApplicationOpeningPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        /// <summary>
        /// Nyitóablak egy példánya
        /// </summary>
        private FormApplicationOpening formApplicationOpening;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Nyitóablak prezenter konstruktora
        /// </summary>
        /// <param name="formApplicationOpening"></param>
        public ApplicationOpeningPresenter(FormApplicationOpening formApplicationOpening)
        {
            formLogin = new FormLogin();
            this.formApplicationOpening = formApplicationOpening;
        }

        #endregion

        #region Nyitóablak nézetfrissítései

        /// <summary>
        /// Metódus, amely beállítja az ablakot betöltődéskor
        /// </summary>
        public void ApplicationStarting()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
