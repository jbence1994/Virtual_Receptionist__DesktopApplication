using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Model.Entity
{
    /// <summary>
    /// Számlázandó foglalások modell osztálya
    /// </summary>
    public class BillingData
    {
        private int id;
        private string guestName;
        private int roomNumber;
        private string roomCategory;
        private int numberOfGuests;
        private DateTime arrivalDate;
        private DateTime departureDate;

        public BillingData(int id, string guestName, int roomNumber, string roomCategory, int numberOfGuests,
            DateTime arrivalDate, DateTime departureDate)
        {
            this.id = id;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.roomCategory = roomCategory;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public string RoomCategory
        {
            get { return roomCategory; }
            set { roomCategory = value; }
        }

        public int NumberOfGuest
        {
            get { return numberOfGuests; }
            set { numberOfGuests = value; }
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public override string ToString()
        {
            return $"{id}{guestName}{roomNumber}{roomCategory}{numberOfGuests}{arrivalDate}{departureDate}";
        }
    }
}
