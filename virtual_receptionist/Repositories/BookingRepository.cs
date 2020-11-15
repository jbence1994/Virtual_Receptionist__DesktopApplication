using System.Collections.Generic;
using System;
using System.Data;
using System.Linq;
using virtual_receptionist.Models;
using virtual_receptionist.MySQLConnection;

namespace virtual_receptionist.Repositories
{
    public class BookingRepository
    {
        private readonly Database database = Database.GetDatabaseInstance();
        private readonly List<Booking> bookings;

        public BookingRepository()
        {
            bookings = new List<Booking>();
        }

        private void UploadBookingsList()
        {
            const string sql =
                "SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.Paid FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID";

            var dt = database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt32(row["ID"]);

                var guest = new Guest()
                {
                    Name = row["Name"].ToString()
                };

                var room = new Room()
                {
                    Number = Convert.ToInt32(row["Number"])
                };

                var numberOfGuests = Convert.ToInt32(row["NumberOfGuests"]);
                var arrival = Convert.ToDateTime(row["ArrivalDate"]).ToString("yyyy-MM-dd");
                var departure = Convert.ToDateTime(row["DepartureDate"]).ToString("yyyy-MM-dd");
                var paid = Convert.ToBoolean(row["Paid"]);

                var booking = new Booking
                {
                    Id = id,
                    Guest = guest,
                    Room = room,
                    NumberOfGuests = numberOfGuests,
                    ArrivalDate = arrival,
                    DepartureDate = departure,
                    IsPaid = paid
                };

                bookings.Add(booking);
            }
        }

        public void ValidateFreeRoomCapacityOnSpecifiedArrivalDate(Booking booking)
        {
            if (bookings.Any(b => booking.ArrivalDate == b.ArrivalDate && booking.Room.Number == b.Room.Number))
            {
                throw new Exception();
            }
        }

        public void AddBooking(Booking booking)
        {
            var sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate, Paid) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), \"{booking.NumberOfGuests}\", \"{booking.ArrivalDate}\", \"{booking.DepartureDate}\", \"{booking.IsPaid}\");";

            database.Dml(sql);
        }

        public void DeleteBooking(int id)
        {
            var sql = $"DELETE FROM booking WHERE booking.ID = \"{id}\"";
            database.Dml(sql);
        }

        public void UpdateBooking(Booking booking)
        {
            var sql =
                $"UPDATE booking SET booking.GuestID = (SELECT guest.ID FROM guest WHERE guest.Name = \"{booking.Guest.Name}\"), booking.RoomID = (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), NumberOfGuests = \"{booking.NumberOfGuests}\", ArrivalDate = \"{booking.ArrivalDate}\", DepartureDate = \"{booking.DepartureDate}\" WHERE booking.ID = \"{booking.Id}\"";
            database.Dml(sql);
        }

        public List<Booking> GetBookingsByArrivalDate(string arrivalDate)
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => booking.ArrivalDate == arrivalDate).ToList();
        }

        public List<Booking> GetGuestBookingsByDepartureDate(string departureDate)
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => booking.DepartureDate == departureDate).ToList();
        }

        public List<Booking> GetUnpaidBookings()
        {
            bookings.Clear();
            UploadBookingsList();

            return bookings.Where(booking => !booking.IsPaid).ToList();
        }
    }
}
