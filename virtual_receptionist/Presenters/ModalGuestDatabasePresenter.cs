using virtual_receptionist.Model;
using System.Windows.Forms;

namespace virtual_receptionist.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public class ModalGuestDatabasePresenter : DefaultPresenter
    {
        #region Adattagok

        /// <summary>
        /// Guest objektum
        /// </summary>
        private Guest guest;

        #endregion

        #region Konstruktor

        /// <summary>
        /// 
        /// </summary>
        public ModalGuestDatabasePresenter(Guest guest, params Control[] controls)
        {
            this.guest = guest;
        }

        #endregion

        #region Nézetfrissítések


        #endregion

        public void ReturnInpit()
        {
            guest.Name = textBoxName.Text;
            guest.Country = comboBoxCountry.Text;
            guest.ZipCode = textBoxZipCode.Text;
            guest.City = textBoxCity.Text;
            guest.Address = textBoxAddress.Text;
            guest.PhoneNumber = textBoxPhoneNumber.Text;
            guest.EmailAddress = textBoxEmailAddress.Text;

            if (radioButtonNational.Checked)
            {
                guest.Nationality = "belföldi";
            }
            else if (radioButtonForeign.Checked)
            {
                guest.Nationality = "külföldi";
            }

            if (checkBoxCorporateGuest.Checked)
            {
                guest.VatNumber = textBoxVatNumber.Text;
            }
        }
    }
}
