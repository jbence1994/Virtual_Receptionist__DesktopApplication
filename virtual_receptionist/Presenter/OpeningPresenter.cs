using System;
using virtual_receptionist.View;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Nyitóablak prezentere
    /// </summary>
    public class OpeningPresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Bejelentkező ablak egy példánya
        /// </summary>
        private FormLogin formLogin;

        /// <summary>
        /// Nyitóablak egy példánya
        /// </summary>
        private FormOpening formOpening;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Nyitóablak prezenter konstruktora
        /// </summary>
        /// <param name="formOpening">Alkalmazás nyitóablaka</param>
        public OpeningPresenter(FormOpening formOpening)
        {
            formLogin = new FormLogin();
            this.formOpening = formOpening;
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
