using System;
using System.Data;
using MySQL_Interface;
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
        /// Adatbázis kapcsolódást és CRUD műveleteket megvalósító egyke osztály egy példánya
        /// </summary>
        private static Database database;

        /// <summary>
        /// Szálláshelyeket tartalmazó lista
        /// </summary>
        private static List<Accomodation> accomodations;

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        private static List<BillingItem> billingItems;

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        private static List<Booking> bookings;

        /// <summary>
        /// Cégeket tartalmazó lista
        /// </summary>
        private static List<Company> companies;

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        private static List<Country> countries;

        /// <summary>
        /// Magánvendégeket tartalmazó lista
        /// </summary>
        private static List<Guest> guests;

        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        private static List<Room> rooms;

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
            companies = new List<Company>();
            countries = new List<Country>();
            guests = new List<Guest>();
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

        /// <summary>
        /// Szálláshelyeket tartalmazó lista
        /// </summary>
        public List<Accomodation> Accomodations
        {
            get
            {
                if (accomodations.Count == 0)
                {
                    UploadAccomodationList();
                }

                return accomodations;
            }
        }

        /// <summary>
        /// Számlázási tételeket tartalmazó lista
        /// </summary>
        public List<BillingItem> BillingItems
        {
            get
            {
                if (billingItems.Count == 0)
                {
                    UploadBillingItemsList();
                }

                return billingItems;
            }
        }

        /// <summary>
        /// Foglalásokat tartalmazó lista
        /// </summary>
        public List<Booking> Bookings
        {
            get
            {
                if (bookings.Count == 0)
                {
                    UploadBookingsList();
                }

                return bookings;
            }
        }

        /// <summary>
        /// Cégeket tartalmazó lista
        /// </summary>
        public List<Company> Companies
        {
            get
            {
                if (companies.Count == 0)
                {
                    UploadCompaniesList();
                }

                return companies;
            }
        }

        /// <summary>
        /// Orszgáokat tartalmazó lista
        /// </summary>
        public List<Country> Countries
        {
            get
            {
                if (countries.Count == 0)
                {
                    UploadCountriesList();
                }

                return countries;
            }
        }

        /// <summary>
        /// Vendégeket tartalmazó lista
        /// </summary>
        public List<Guest> Guests
        {
            get
            {
                if (guests.Count == 0)
                {
                    UploadGuestsList();
                }

                return guests;
            }
        }

        /// <summary>
        /// Szobákat tartalmazó lista
        /// </summary>
        public List<Room> Rooms
        {
            get
            {
                if (rooms.Count == 0)
                {
                    UploadRoomsList();
                }

                return rooms;
            }
        }

        #endregion

        #region Adatelérési és adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szálláshelyek adatait tartalmazó listát
        /// </summary>
        private static void UploadAccomodationList()
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
        /// Metódus, amely adatbázisból feltölti a számlázási tételek adatait tartalmazó listát
        /// </summary>
        private static void UploadBillingItemsList()
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
        /// Metódus, amely adatbázisból feltölti a foglalások adatait tartalmazó listát
        /// </summary>
        private static void UploadBookingsList()
        {
            string sql =
                "SELECT booking.ID, guest.Name, company.Name, room.Number, booking.NumberOfGuests, booking.ArrivalDate, booking.DepartureDate FROM booking, guest, company, room WHERE booking.GuestID = guest.ID AND booking.RoomID = room.ID AND booking.CompanyID = company.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                Guest guest = new Guest()
                {
                    Name = row["Name"].ToString()
                };

                Company company = new Company()
                {
                    Name = row["Name"].ToString()
                };

                Room room = new Room()
                {
                    Number = int.Parse(row["Number"].ToString())
                };

                int numberOfGuests = int.Parse(row["NumberOfGuests"].ToString());
                DateTime arrival = (DateTime) row["ArrivalDate"];
                DateTime departure = (DateTime) row["DepartureDate"];

                Booking bookingInstance = new Booking(id, guest, company, room, numberOfGuests, arrival, departure);
                bookings.Add(bookingInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a cégek adatait tartalmazó listát
        /// </summary>
        private static void UploadCompaniesList()
        {
            string sql =
                "SELECT company.ID, company.CompanyName, company.VATNumber, country.CountryName, company.ZipCode, company.City, company.Address, company.PhoneNumber, company.EmailAddress FROM company, country WHERE company.Country = country.ID";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = int.Parse(row["ID"].ToString());
                string name = row["CompanyName"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string country = row["CountryName"].ToString();
                string zipCode = row["ZipCode"].ToString();
                string city = row["City"].ToString();
                string address = row["Address"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string emailAddress = row["EmailAddress"].ToString();

                Company companyInstance = new Company(id, name, vatNumber, country, zipCode, city, address, phoneNumber,
                    emailAddress);
                companies.Add(companyInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti az országok adatait tartalmazó listát
        /// </summary>
        private static void UploadCountriesList()
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

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a vendégek adatait tartalmazó listát
        /// </summary>
        private static void UploadGuestsList()
        {
            string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID";
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

                Guest privateGuestInstance = new Guest(id, name, documentNumber, citizenship, birthDate,
                    country, zipCode, city, address, phoneNumber, emailAddress);
                guests.Add(privateGuestInstance);
            }
        }

        /// <summary>
        /// Metódus, amely adatbázisból feltölti a szobák adatait tartalmazó listát
        /// </summary>
        private static void UploadRoomsList()
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

        #endregion
    }
}
