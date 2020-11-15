using virtual_receptionist.Repositories;

namespace virtual_receptionist.Controllers
{
    public class LoginController : Controller
    {
        private readonly AccommodationRepository accommodationRepository = new AccommodationRepository();

        public bool EnterApplication(string accommodationId, string password)
        {
            return accommodationRepository.Authentication(accommodationId, password);
        }
    }
}
