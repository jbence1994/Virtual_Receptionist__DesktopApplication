namespace virtual_receptionist.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public int NumberOfGuests { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
