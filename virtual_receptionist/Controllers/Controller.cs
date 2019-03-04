using virtual_receptionist.Models.Data;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Az alkalmazás vezérlője, amely a nézetek megfelelő előállításáért és az inputok ellenőrzéséért
    /// </summary>
    public class Controller
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példénya
        /// </summary>
        private Repository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Alkalmazás vezérlő konstruktora
        /// </summary>
        public Controller()
        {
            repository = new Repository();
        }

        #endregion
    }
}
