using System;
using MySQL_ORM;
using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Model.Entity;

namespace virtual_receptionist.Model.Repository
{
    /// <summary>
    /// Az alkalmazáshoz szükséges adatokat tároló és üzleti logikáért felelős adattár osztály
    /// </summary>
    public partial class DataRepository
    {
        #region Adattagok

        /// <summary>
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke ORM osztály egy példánya
        /// </summary>
        private static Database database;

        /// <summary>
        /// Szálláshelyek adatait tároló lista
        /// </summary>
        private List<Accomodation> accomodations;

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        private List<BillingItem> billingItems;

        /// <summary>
        /// Magánvendégeket tartalmazó lista
        /// </summary>
        private List<PrivateGuest> privateGuests;

        /// <summary>
        /// Vállalati vendégeket tartalmazó lista
        /// </summary>
        private List<CorporateGuest> corporateGuests;

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private List<Country> countries;

        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        private List<Room> rooms;

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private List<Booking> bookings;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Adattár konstruktora
        /// </summary>
        public DataRepository()
        {
            database = Database.DatabaseInstance;

            accomodations = new List<Accomodation>();
            billingItems = new List<BillingItem>();
            bookings = new List<Booking>();
            corporateGuests = new List<CorporateGuest>();
            countries = new List<Country>();
            privateGuests = new List<PrivateGuest>();
            rooms = new List<Room>();
        }

        #endregion

        #region Getter tulajdonságok

        /// <summary>
        /// Szálláshely egyed
        /// </summary>
        public Accomodation Accomodation
        {
            get { return Accomodation.GetInstance; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a szálláshelyek adatait és lista adatszerkezetek menti őket
        /// </summary>
        private void UploadAccomodationList()
        {
            Accomodation accomodation = Accomodation.GetInstance;

            string sql =
                "SELECT accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                accomodation.Name = row["AccomodationName"].ToString();
                accomodation.Company = row["CompanyName"].ToString();
                accomodation.Contact = row["Contact"].ToString();
                accomodation.VatNumber = row["VATNumber"].ToString();
                accomodation.Headquarters = row["Headquarters"].ToString();
                accomodation.Site = row["Site"].ToString();
                accomodation.PhoneNumber = row["PhoneNumber"].ToString();
                accomodation.EmailAddress = row["EmailAddress"].ToString();
                accomodation.AccomodationID = row["AccomodationID"].ToString();
                accomodation.Password = row["Password"].ToString();

                accomodations.Add(accomodation);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok neveit tartalmazó listát
        /// </summary>
        /// <returns>Országok neveivel feltöltött listát adja vissza</returns>
        public List<Country> GetCountries()
        {
            if (countries.Count == 0)
            {
                string sql = "SELECT * FROM country";
                DataTable dt = database.DQL(sql);

                foreach (DataRow row in dt.Rows)
                {
                    string name = row["CountryName"].ToString();

                    Country countryInstance = new Country(name);
                    countries.Add(countryInstance);
                }
            }

            return countries;
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a számlázási tételeket tartalmazó listát
        /// </summary>
        private void UploadBillingItemsList()
        {
            string sql =
                "SELECT billing_item.BillingItemName, billing_item.Price, billing_item_category.VAT, billing_item_category.BillingItemCategoryName, billing_item_category.Unit FROM billing_item, billing_item_category WHERE billing_item.Category = billing_item_category.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["BillingItemName"].ToString();
                string categoryName = row["BillingItemCategoryName"].ToString();
                double vat = double.Parse(row["VAT"].ToString());
                string unit = row["Unit"].ToString();
                double price = double.Parse(row["Price"].ToString());

                BillingItemCategory billingItemCategoryInstance = new BillingItemCategory(categoryName, vat, unit);
                BillingItem billingItemInstance = new BillingItem(name, billingItemCategoryInstance, price);
                billingItems.Add(billingItemInstance);
            }
        }

        /// <summary>
        /// Metódus, amely feltölti a számlázási tételeket tartalmazó adattáblát a listában tárolt adatokkal
        /// </summary>
        /// <returns>A számlázási tételeket tartalmazó listából feltöltött adattáblával tér vissza a függvény</returns>
        public DataTable GetBillingItems()
        {
            if (billingItems.Count == 0)
            {
                UploadBillingItemsList();
            }

            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("CategoryName", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItem item in billingItems)
            {
                billingItemsDataTable.Rows.Add(item.Name, item.Price, item.Category.VAT, item.Category.Name,
                    item.Category.Unit);
            }

            return billingItemsDataTable;
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobakiadásokat tartalmazó listát érkezés dátuma alapján
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        private void UploadBookingsListByArrivalDate(string arrivalDate)
        {
            string sql =
                $"SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID AND booking.ArrivalDate LIKE \"{arrivalDate}\" ORDER BY booking.ArrivalDate ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                Guest guest = new PrivateGuest()
                {
                    Name = row["Name"].ToString()
                };

                Room room = new Room
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

                Booking bookingInstance = new Booking(id, guest, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobakiadásokat tartalmazó listát távozás dátuma alapján
        /// </summary>
        /// <param name="departureDate">Távozás dátuma</param>
        private void UploadBookingsListByDepartureDate(string departureDate)
        {
            string sql =
                $"SELECT booking.ID, guest.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID AND booking.DepartureDate LIKE \"{departureDate}\" ORDER BY booking.DepartureDate ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                Guest guest = new PrivateGuest()
                {
                    Name = row["Name"].ToString()
                };

                Room room = new Room
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

                Booking bookingInstance = new Booking(id, guest, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait érkezés dátuma szerint egy adattáblában
        /// </summary>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public DataTable GetBookingsByArrivalDate(string arrivalDate)
        {
            bookings.Clear();
            UploadBookingsListByArrivalDate(arrivalDate);

            DataTable bookingsDataTable = new DataTable();
            bookingsDataTable.Columns.Add("ID", typeof(int));
            bookingsDataTable.Columns.Add("GuestName", typeof(string));
            bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookings)
            {
                bookingsDataTable.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt szobakiadások adatait távozás dátuma szerint egy adattáblában
        /// </summary>
        /// <param name="departureDate"></param>
        /// <returns></returns>
        public DataTable GetBookingsByDepartureDate(string departureDate)
        {
            bookings.Clear();
            UploadBookingsListByDepartureDate(departureDate);

            DataTable bookingsDataTable = new DataTable();
            bookingsDataTable.Columns.Add("ID", typeof(int));
            bookingsDataTable.Columns.Add("GuestName", typeof(string));
            bookingsDataTable.Columns.Add("RoomNumber", typeof(int));
            bookingsDataTable.Columns.Add("NumberOfGuests", typeof(int));
            bookingsDataTable.Columns.Add("ArrivalDate", typeof(DateTime));
            bookingsDataTable.Columns.Add("DepartureDate", typeof(DateTime));

            foreach (Booking booking in bookings)
            {
                bookingsDataTable.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsDataTable;
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobákat tartalmazó listát
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        private void UploadRoomsList()
        {
            string sql =
                "SELECT room.Name, room.Number, room_category.RoomCategoryName, room.Capacity FROM room, room_category WHERE room.Category = room_category.ID ORDER BY room.Number ASC";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                int number = int.Parse(row["Number"].ToString());
                string category = row["RoomCategoryName"].ToString();
                int capacity = int.Parse(row["Capacity"].ToString());

                RoomCategory roomCategoryInstance = new RoomCategory(category);
                Room roomInstance = new Room(name, number, roomCategoryInstance, capacity);
                rooms.Add(roomInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szoba adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött adattáblát adja vissza</returns>
        public DataTable GetRooms()
        {
            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            DataTable roomsDataTable = new DataTable();
            roomsDataTable.Columns.Add("Name", typeof(string));
            roomsDataTable.Columns.Add("Number", typeof(int));
            roomsDataTable.Columns.Add("CategoryName", typeof(string));
            roomsDataTable.Columns.Add("Capacity", typeof(int));

            foreach (Room room in rooms)
            {
                roomsDataTable.Rows.Add(room.Name, room.Number, room.Category, room.Capacity);
            }

            return roomsDataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetRoomNumbersWithNamesAndCategoryNames()
        {
            List<string> roomNumbersWithRoomNames = new List<string>();

            if (rooms.Count == 0)
            {
                UploadRoomsList();
            }

            foreach (Room room in rooms)
            {
                roomNumbersWithRoomNames.Add($"{room.Number}) szoba, {room.Name} ({room.Category.Name})");
            }

            return roomNumbersWithRoomNames;
        }

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a vendégeket és lista adatszerkezetbe menti őket
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        private void UploadPrivateGuestsList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.DocumentNumber != \"\"";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["Name"].ToString();
                string documentNumber = row["DocumentNumber"].ToString();
                string citizenship = row["Citizenship"].ToString();
                string birthDate = DateTime.Parse(row["BirthDate"].ToString()).ToShortDateString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                PrivateGuest privateGuestInstance = new PrivateGuest(id, name, documentNumber, citizenship, birthDate,
                    country, zipCode, city, address, phoneNumber, emailAddress);

                privateGuests.Add(privateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból kiolvassa a céges vendégeket és lista adatszerkezetbe menti őket
        /// </summary>
        private void UploadCorporateGuestList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.VATNumber, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.VATNumber, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID AND guest.VATNumber != \"\"";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["Name"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                CorporateGuest corporateGuestInstance = new CorporateGuest(id, name, vatNumber, country, zipCode, city,
                    address, phoneNumber, emailAddress);

                corporateGuests.Add(corporateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetPrivateGuests()
        {
            if (privateGuests.Count == 0)
            {
                UploadPrivateGuestsList();
            }

            DataTable privateGuestsDataTable = new DataTable();
            privateGuestsDataTable.Columns.Add("ID", typeof(int));
            privateGuestsDataTable.Columns.Add("Name", typeof(string));
            privateGuestsDataTable.Columns.Add("DocumentNumber", typeof(string));
            privateGuestsDataTable.Columns.Add("Citizenship", typeof(string));
            privateGuestsDataTable.Columns.Add("BirthDate", typeof(string));
            privateGuestsDataTable.Columns.Add("Country", typeof(string));
            privateGuestsDataTable.Columns.Add("ZipCode", typeof(string));
            privateGuestsDataTable.Columns.Add("City", typeof(string));
            privateGuestsDataTable.Columns.Add("Address", typeof(string));
            privateGuestsDataTable.Columns.Add("PhoneNumber", typeof(string));
            privateGuestsDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (PrivateGuest privateGuest in privateGuests)
            {
                privateGuestsDataTable.Rows.Add(privateGuest.ID, privateGuest.Name, privateGuest.DocumentNumber,
                    privateGuest.Citizenship,
                    privateGuest.BirthDate, privateGuest.Country, privateGuest.ZipCode, privateGuest.City,
                    privateGuest.Address, privateGuest.PhoneNumber, privateGuest.EmailAddress);
            }

            return privateGuestsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes céges vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetCorporateGuests()
        {
            if (corporateGuests.Count == 0)
            {
                UploadCorporateGuestList();
            }

            DataTable corporateGuestDataTable = new DataTable();
            corporateGuestDataTable.Columns.Add("ID", typeof(int));
            corporateGuestDataTable.Columns.Add("Name", typeof(string));
            corporateGuestDataTable.Columns.Add("VATNumber", typeof(string));
            corporateGuestDataTable.Columns.Add("Country", typeof(string));
            corporateGuestDataTable.Columns.Add("ZipCode", typeof(string));
            corporateGuestDataTable.Columns.Add("City", typeof(string));
            corporateGuestDataTable.Columns.Add("Address", typeof(string));
            corporateGuestDataTable.Columns.Add("PhoneNumber", typeof(string));
            corporateGuestDataTable.Columns.Add("EmailAddress", typeof(string));

            foreach (CorporateGuest corporateGuest in corporateGuests)
            {
                corporateGuestDataTable.Rows.Add(corporateGuest.ID, corporateGuest.Name, corporateGuest.VatNumber,
                    corporateGuest.Country, corporateGuest.ZipCode, corporateGuest.City, corporateGuest.Address,
                    corporateGuest.PhoneNumber, corporateGuest.EmailAddress);
            }

            return corporateGuestDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja a soron következő vendégazonosítót adatbázisból
        /// </summary>
        /// <returns>Az adatbázisban soron következő vendégazonosítót adja vissza a függvény</returns>
        public int GetNextGuestID()
        {
            int nextID;

            string sql = "SELECT MAX(guest.ID) FROM guest";
            string maxID = database.DQLScalar(sql);

            int.TryParse(maxID, out nextID);

            return nextID + 1;
        }

        #endregion
    }
}
