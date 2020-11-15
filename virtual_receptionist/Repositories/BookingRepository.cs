using System.Collections.Generic;
using System;
using System.Data;
using System.Linq;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    public class BookingRepository : Repository
    {
        private readonly List<Room> rooms;
        private readonly List<Booking> bookings;

        public BookingRepository()
        {
            rooms = new List<Room>();
            bookings = new List<Booking>();
        }

        private void UploadRoomsList()
        {
            const string sql =
                "SELECT room.ID, room.Name, room.Number, billing_item.BillingItemName, room.Capacity FROM room, billing_item WHERE room.Category = billing_item.ID ORDER BY room.Number ASC";

            var dt = Database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt32(row["ID"]);
                var name = row["Name"].ToString();
                var number = Convert.ToInt32(row["Number"]);
                var category = row["BillingItemName"].ToString();
                var capacity = Convert.ToInt32(row["Capacity"]);

                var room = new Room
                {
                    Id = id,
                    Name = name,
                    Number = number,
                    Category = category,
                    Capacity = capacity
                };

                rooms.Add(room);
            }
        }

        private void UploadBookingsList()
        {
            const string sql =
                "SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate, booking.Paid FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID";

            var dt = Database.Dql(sql);

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

        public List<Room> GetRooms()
        {
            if (rooms.Count == 0)
                UploadRoomsList();

            return rooms;
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

            Database.Dml(sql);
        }

        public void DeleteBooking(Booking booking)
        {
            var sql = $"DELETE FROM booking WHERE booking.ID = \"{booking.Id}\"";
            Database.Dml(sql);
        }

        public void UpdateBooking(Booking booking)
        {
            var sql =
                $"UPDATE booking SET booking.GuestID = (SELECT guest.ID FROM guest WHERE guest.Name = \"{booking.Guest.Name}\"), booking.RoomID = (SELECT room.ID FROM room WHERE room.Number = \"{booking.Room.Number}\"), NumberOfGuests = \"{booking.NumberOfGuests}\", ArrivalDate = \"{booking.ArrivalDate}\", DepartureDate = \"{booking.DepartureDate}\" WHERE booking.ID = \"{booking.Id}\"";
            Database.Dml(sql);
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

        public int GetRoomCapacity(int roomNumber)
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            return (from room in rooms where room.Number == roomNumber select room.Capacity).FirstOrDefault();
        }
    }
}
