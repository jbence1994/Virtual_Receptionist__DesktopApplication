using System.Windows.Forms;
using System.Threading;
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
        /// 
        /// </summary>
        private FormLogin formLogin;
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public void ApplicationStarting()
        {

        }

        #endregion
    }
}
