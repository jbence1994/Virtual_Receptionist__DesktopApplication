using System;
using virtual_receptionist.Models;

namespace virtual_receptionist.Validation
{
    public static class BookingCapacityValidation
    {
        public static void ValidateBookingCapacity(Booking booking)
        {
            if (booking.NumberOfGuests > booking.Room.Capacity)
                throw new Exception(
                    "A vendégek száma nem lehet nagyobb, mint a kiválasztott szoba maximális férőhelye!");
        }
    }
}
