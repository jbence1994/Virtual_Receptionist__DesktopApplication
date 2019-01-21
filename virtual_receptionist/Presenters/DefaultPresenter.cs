using System.Windows.Forms;
using virtual_receptionist.Model;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// Az alkalmazás prezenter osztálya, amely modell kezelésért és nézet frissítésért felel
    /// </summary>
    public class DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Adattár osztály egy példánya
        /// </summary>
        protected DataRepository dataRepository;

        /// <summary>
        /// Formon felhasználói módosítást tároló logikai változó 
        /// </summary>
        protected bool userIntervention;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor
        /// </summary>
        public DefaultPresenter()
        {
            dataRepository = new DataRepository();
        }

        #endregion

        #region Általános nézetfrissítések

        /// <summary>
        /// Főmenübe visszalépés
        /// </summary>
        public void BackToMainMenu(Form form)
        {
            if (userIntervention)
            {
                DialogResult backToMainMenu =
                    MessageBox.Show("Nem mentett változásai vannak! Biztosan visszalép a főmenübe?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (backToMainMenu == DialogResult.OK)
                {
                    form.Close();
                }
            }
        }

        #endregion
    }
}
