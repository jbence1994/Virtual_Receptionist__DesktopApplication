using System;
using System.Data;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Controllers
{
    public class BookingController : Controller
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();

        public DataTable GetBookingsByArrivalDate(DateTime arrivalDate)
        {
            var arrival = arrivalDate.ToString("yyyy-MM-dd");
            var bookingsByArrival = bookingRepository.GetBookingsByArrivalDate(arrival);

            DataTable bookingsDataTableByArrival = new DataTable();
            bookingsDataTableByArrival.Columns.Add("ID", typeof(int));
            bookingsDataTableByArrival.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByArrival.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByArrival.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByArrival.Columns.Add("ArrivalDate", typeof(string));
            bookingsDataTableByArrival.Columns.Add("DepartureDate", typeof(string));
            bookingsDataTableByArrival.Columns.Add("Paid", typeof(bool));

            foreach (var booking in bookingsByArrival)
            {
                bookingsDataTableByArrival.Rows.Add(booking.Id, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.IsPaid);
            }

            return bookingsDataTableByArrival;
        }

        public DataTable GetBookingsByDepartureDate(DateTime departureDate)
        {
            var departure = departureDate.ToString("yyyy-MM-dd");
            var bookingsByDeparture = bookingRepository.GetGuestBookingsByDepartureDate(departure);

            var bookingsDataTableByDeparture = new DataTable();
            bookingsDataTableByDeparture.Columns.Add("ID", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("GuestName", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTableByDeparture.Columns.Add("ArrivalDate", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("DepartureDate", typeof(string));
            bookingsDataTableByDeparture.Columns.Add("Paid", typeof(bool));

            foreach (var booking in bookingsByDeparture)
            {
                bookingsDataTableByDeparture.Rows.Add(booking.Id, booking.Guest.Name, booking.Room.Number,
                    booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.IsPaid);
            }

            return bookingsDataTableByDeparture;
        }

        public void AddBooking(params object[] bookingParameters)
        {
            var guest = new Guest
            {
                Name = bookingParameters[0].ToString()
            };

            var room = new Room
            {
                Number = Convert.ToInt32(bookingParameters[1])
            };

            var numberOfGuests = Convert.ToInt32(bookingParameters[2]);

            var arrivalDate = Convert.ToDateTime(bookingParameters[3]).ToString("yyyy-MM-dd");

            var departureDate = Convert.ToDateTime(bookingParameters[4]).ToString("yyyy-MM-dd");

            const bool paid = false;

            var booking = new Booking
            {
                Guest = guest,
                Room = room,
                NumberOfGuests = numberOfGuests,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                IsPaid = paid
            };

            bookingRepository.AddBooking(booking);
        }

        public void DeleteBooking(params object[] bookingParameters)
        {
            var id = Convert.ToInt32(bookingParameters[0]);

            var guest = new Guest
            {
                Name = bookingParameters[1].ToString()
            };

            var room = new Room
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            var numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            var arrivalDate = Convert.ToDateTime(bookingParameters[4].ToString()).ToString("yyyy-MM-dd");

            var departureDate = Convert.ToDateTime(bookingParameters[5].ToString()).ToString("yyyy-MM-dd");

            var booking = new Booking
            {
                Id = id,
                Guest = guest,
                Room = room,
                NumberOfGuests = numberOfGuests,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate
            };

            bookingRepository.DeleteBooking(booking);
        }

        public void UpdateBooking(params object[] bookingParameters)
        {
            var id = Convert.ToInt32(bookingParameters[0]);

            var guest = new Guest
            {
                Name = bookingParameters[1].ToString()
            };

            var room = new Room
            {
                Number = Convert.ToInt32(bookingParameters[2])
            };

            var numberOfGuests = Convert.ToInt32(bookingParameters[3]);

            var arrivalDate = Convert.ToDateTime(bookingParameters[4]).ToString("yyyy-MM-dd");

            var departureDate = Convert.ToDateTime(bookingParameters[5]).ToString("yyyy-MM-dd");

            var booking = new Booking
            {
                Id = id,
                Guest = guest,
                Room = room,
                NumberOfGuests = numberOfGuests,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate
            };

            bookingRepository.UpdateBooking(booking);
        }

        public void BookingDateValidator(DateTime arrivalDate, DateTime departureDate)
        {
            var booking = new Booking
            {
                ArrivalDate = arrivalDate.ToString(),
                DepartureDate = departureDate.ToString()
            };

            BookingDateValidation.ValidateBookingDate(booking);
        }

        public void BookingCapacityValidator(decimal numberOfGuests, int roomNumber)
        {
            var room = new Room
            {
                Capacity = bookingRepository.GetRoomCapacity(roomNumber)
            };

            var booking = new Booking
            {
                NumberOfGuests = Convert.ToInt32(numberOfGuests),
                Room = room
            };

            BookingCapacityValidation.ValidateBookingCapacity(booking);
        }

        public void FreeRoomCapacityValidator(DateTime arrivalDate, int roomNumber)
        {
            var room = new Room
            {
                Number = roomNumber
            };

            var booking = new Booking
            {
                Room = room,
                ArrivalDate = arrivalDate.ToString("yyyy-MM-dd")
            };

            bookingRepository.ValidateFreeRoomCapacityOnSpecifiedArrivalDate(booking);
        }
    }
}
