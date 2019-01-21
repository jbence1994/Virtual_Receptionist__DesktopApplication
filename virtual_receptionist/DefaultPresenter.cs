using System.Windows.Forms;
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
        public Presenter()
        {
            dataRepository = new DataRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Főmenübe visszalépés
        /// </summary>
        public void BackToMainMenu(Form form)
        {
            if (userIntervention)
            {
                DialogResult backToMainMenu = MessageBox.Show("Nem mentett változásai vannak! Biztosan visszalép a főmenübe?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (backToMainMenu == DialogResult.OK)
                {
                    form.Close();
                }
            }
        }

        #endregion
    }
}
