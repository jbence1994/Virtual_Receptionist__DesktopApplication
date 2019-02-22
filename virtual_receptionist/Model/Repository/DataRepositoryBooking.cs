using virtual_receptionist.Model.Entity;
using virtual_receptionist.Model.Interfaces;

namespace virtual_receptionist.Model.Repository
{
    public partial class DataRepository : IManipulable<Booking>
    {
        #region Foglalási napló modul üzleti logika

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Create(Booking booking)
        {
            string sql =
                $"INSERT INTO booking(GuestID, RoomID, NumberOfGuests, ArrivalDate, DepartureDate) VALUES ((SELECT guest.ID FROM guest WHERE guest.Name LIKE \"{booking.Guest.Name}\"), (SELECT room.ID FROM room WHERE room.Number LIKE \"{booking.Room.Number}\"), {booking.NumberOfGuests}, {booking.ArrivalDate}, {booking.DepartureDate});";
            database.DML(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking">Booking objektum</param>>
        public void Delete(Booking booking)
        {
            string sql = $"DELETE FROM booking WHERE ";
            database.DML(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking">Booking objektum</param>
        public void Update(Booking booking)
        {
            string sql = $"UPDATE room SET WHERE";
            database.DML(sql);
        }

        #endregion
    }
}
