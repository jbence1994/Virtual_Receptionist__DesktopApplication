namespace virtual_receptionist.Models
{
    public class Accommodation
    {
        private static readonly Accommodation AccommodationInstance = new Accommodation();

        private Accommodation()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Contact { get; set; }
        public string VatNumber { get; set; }
        public string Headquarters { get; set; }
        public string Site { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AccommodationId { get; set; }
        public string Password { get; set; }

        public static Accommodation GetAccommodation()
        {
            return AccommodationInstance;
        }
    }
}
