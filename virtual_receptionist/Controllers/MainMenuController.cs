using virtual_receptionist.Repositories;
using virtual_receptionist.Views;

namespace virtual_receptionist.Controllers
{
    public class MainMenuController : Controller
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();

        public string SetMainMenuHeader()
        {
            var accommodation = accommodationRepository.GetAccomodation();
            return $"{accommodation.AccomodationName} ({accommodation.VATNumber})";
        }

        public string[] GetAccommodationInfo()
        {
            var accommodation = accommodationRepository.GetAccomodation();

            var accommodationInfo = new string[8];
            accommodationInfo[0] = accommodation.AccomodationName;
            accommodationInfo[1] = accommodation.CompanyName;
            accommodationInfo[2] = accommodation.Contact;
            accommodationInfo[3] = accommodation.VATNumber;
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
