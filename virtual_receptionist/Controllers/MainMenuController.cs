using virtual_receptionist.Repositories;
using virtual_receptionist.Views;

namespace virtual_receptionist.Controllers
{
    public class MainMenuController : Controller
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();

        public string SetMainMenuHeader()
        {
            var accommodation = accommodationRepository.GetAccommodation();
            return $"{accommodation.Name} ({accommodation.VatNumber})";
        }

        public string[] GetAccommodationInfo()
        {
            var accommodation = accommodationRepository.GetAccommodation();

            var accommodationInfo = new string[8];
            accommodationInfo[0] = accommodation.Name;
            accommodationInfo[1] = accommodation.Company;
            accommodationInfo[2] = accommodation.Contact;
            accommodationInfo[3] = accommodation.VatNumber;
            accommodationInfo[4] = accommodation.Headquarters;
            accommodationInfo[5] = accommodation.Site;
            accommodationInfo[6] = accommodation.PhoneNumber;
            accommodationInfo[7] = accommodation.EmailAddress;

            return accommodationInfo;
        }

        public void OpenBooking()
        {
            var formBooking = new FormBooking();
            formBooking.ShowDialog();
        }

        public void OpenBilling()
        {
            var formBilling = new FormBilling();
            formBilling.ShowDialog();
        }

        public void OpenGuestDatabase()
        {
            var formGuestDatabase = new FormGuestDatabase();
            formGuestDatabase.ShowDialog();
        }
    }
}
