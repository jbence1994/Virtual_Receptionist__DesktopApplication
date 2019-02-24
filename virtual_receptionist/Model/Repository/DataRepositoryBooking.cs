using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Interfaces;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository : IManipulable<Booking>
    {
        #region Foglalási napló modul üzleti logika

        /// <summary>
        /// Új foglalás felvétele adatbázisba
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Create(Booking booking)
        {
            string sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number LIKE \"{booking.Room.Number}\"), {booking.NumberOfGuests}, {booking.ArrivalDate}, {booking.DepartureDate});";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás törlése adatbázisból
        /// </summary>
        /// <param name="booking">Booking objektum</param>>
        public void Delete(Booking booking)
        {
            string sql = $"DELETE FROM booking WHERE ";
            database.DML(sql);
        }

        /// <summary>
        /// Meglévő foglalás módosítása adatbázisban
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Update(Booking booking)
        {
            string sql = $"UPDATE room SET WHERE";
            database.DML(sql);
        }

        ///// <summary>
        ///// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        ///// </summary>
        ///// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        //public DataTable GetRooms()
        //{
        //    DataTable roomsDataTable = new DataTable();
        //    roomsDataTable.Columns.Add("Name", typeof(string));
        //    roomsDataTable.Columns.Add("Number", typeof(int));
        //    roomsDataTable.Columns.Add("CategoryName", typeof(string));
        //    roomsDataTable.Columns.Add("Capacity", typeof(int));

        //    foreach (Room room in rooms)
        //    {
        //        roomsDataTable.Rows.Add(room.Name, room.Number, room.Category, room.Capacity);
        //    }

        //    return roomsDataTable;
        //}

        ///// <summary>
        ///// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait érkezés dátuma szerint egy adattáblában
        ///// </summary>
        ///// <param name="arrivalDate">Érkezés dátuma</param>
        ///// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        //public DataTable GetBookingsByArrivalDate(string arrivalDate)
        //{
        //    bookings.Clear();

        //    DataTable bookingsDataTable = new DataTable();
        //    bookingsDataTable.Columns.Add("ID", typeof(int));
        //    bookingsDataTable.Columns.Add("GuestName", typeof(string));
        //    bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
        //    bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
        //    bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
        //    bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

        //    foreach (Booking booking in bookings)
        //    {
        //        bookingsDataTable.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
        //            booking.ArrivalDate, booking.DepartureDate);
        //    }

        //    return bookingsDataTable;
        //}

        ///// <summary>
        ///// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait távozás dátuma szerint egy adattáblában
        ///// </summary>
        ///// <param name="departureDate"></param>
        ///// <returns></returns>
        //public DataTable GetBookingsByDepartureDate(string departureDate)
        //{
        //    bookings.Clear();

        //    DataTable bookingsDataTable = new DataTable();
        //    bookingsDataTable.Columns.Add("ID", typeof(int));
        //    bookingsDataTable.Columns.Add("GuestName", typeof(string));
        //    bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
        //    bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
        //    bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
        //    bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

        //    foreach (Booking booking in bookings)
        //    {
        //        bookingsDataTable.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
        //            booking.ArrivalDate, booking.DepartureDate);
        //    }

        //    return bookingsDataTable;
        //}

        #endregion
    }
}
