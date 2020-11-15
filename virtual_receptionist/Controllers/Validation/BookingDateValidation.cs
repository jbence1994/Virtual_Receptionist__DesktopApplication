using System;
using virtual_receptionist.Models;

namespace virtual_receptionist.Controllers.Validation
{
    public static class BookingDateValidation
    {
        public static void ValidateBookingDate(Booking booking)
        {
            if (Convert.ToDateTime(booking.ArrivalDate) == Convert.ToDateTime(booking.DepartureDate))
                throw new Exception("A távozás dátuma megegyezik az érkezés dátumával!");

            if (Convert.ToDateTime(booking.DepartureDate) < Convert.ToDateTime(booking.ArrivalDate))
                throw new Exception("A távozás dátuma nem lehet hamarabb, mint az érkezés dátuma!");
        }
    }
}
