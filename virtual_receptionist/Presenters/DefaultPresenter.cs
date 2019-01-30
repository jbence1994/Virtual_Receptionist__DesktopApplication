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

        #region Általános nézetfrissítések

        /// <summary>
        /// Főmenübe visszalépésre szolgáló metódus
        /// </summary>
        /// <param name="form">Ablak, amely bezárásra kerül</param>
        public void BackToMainMenu(Form form)
        {
            DialogResult backToMainMenu =
                MessageBox.Show("Nem mentett változásai vannak! Biztosan visszalép a főmenübe?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (backToMainMenu == DialogResult.Yes)
            {
                form.Close();
            }
        }

        /// <summary>
        /// Metódus, amely beállítja az adószám szövegmező írhatóságát, attól függően, hogy a vállalati ügyfél checkbox be van-e pipálva
        /// </summary>
        /// <param name="checkBoxCorporateGuest">Vállalati ügyfél checkbox</param>
        /// <param name="textBoxVatNumber">Adószám szövegmező</param>
        public void SetCorporateGuest(CheckBox checkBoxCorporateGuest, TextBox textBoxVatNumber)
        {
            if (checkBoxCorporateGuest.Checked)
            {
                textBoxVatNumber.ReadOnly = false;
            }
            else
            {
                textBoxVatNumber.Clear();
                textBoxVatNumber.ReadOnly = true;
            }
        }

        /// <summary>
        /// Metódus, amely beállítja a legördülő lista forrásának az országok listját
        /// </summary>
        /// <param name="comboBoxCountry">Országok listáját tartalmazó legördülő menü</param>
        public void InitializeComboBoxWithCountryList(ComboBox comboBoxCountry)
        {
            comboBoxCountry.DataSource = dataRepository.GetCountries();
        }

        #endregion
    }
}
