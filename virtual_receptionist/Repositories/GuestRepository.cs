using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using virtual_receptionist.Models;
using virtual_receptionist.MySQLConnection;

namespace virtual_receptionist.Repositories
{
    public class GuestRepository
    {
        private readonly Database database = Database.GetDatabaseInstance();
        private readonly List<Guest> guests;

        public GuestRepository()
        {
            guests = new List<Guest>();
        }

        private void UploadGuestsList()
        {
            const string sql =
                "SELECT guest.ID, guest.Name, guest.DocumentNumber, guest.Citizenship, guest.BirthDate, country.CountryName, guest.ZipCode, guest.City, guest.Address, guest.PhoneNumber, guest.EmailAddress FROM guest, country WHERE guest.Country = country.ID";

            var dt = database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToInt32(row["ID"]);
                var name = row["Name"].ToString();
                var documentNumber = row["DocumentNumber"].ToString();
                var citizenship = row["Citizenship"].ToString();
                var birthDate = Convert.ToDateTime(row["BirthDate"]).ToString("yyyy-MM-dd");
                var country = row["CountryName"].ToString();
                var zipCode = row["ZipCode"].ToString();
                var city = row["City"].ToString();
                var address = row["Address"].ToString();
                var phoneNumber = row["PhoneNumber"].ToString();
                var emailAddress = row["EmailAddress"].ToString();

                var guest = new Guest
                {
                    Id = id,
                    Name = name,
                    DocumentNumber = documentNumber,
                    Citizenship = citizenship,
                    BirthDate = birthDate,
                    Country = country,
                    ZipCode = zipCode,
                    City = city,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    EmailAddress = emailAddress
                };

                guests.Add(guest);
            }
        }

        public List<Guest> GetGuests()
        {
            if (guests.Count == 0)
                UploadGuestsList();

            return guests;
        }

        public void DeleteGuest(int id)
        {
            var sql = $"DELETE FROM guest WHERE guest.ID = \"{id}\"";
            database.Dml(sql);
        }

        public void UpdateGuest(Guest guest)
        {
            var sql =
                $"UPDATE guest SET guest.Name=\"{guest.Name}\", guest.DocumentNumber=\"{guest.DocumentNumber}\", guest.Citizenship=\"{guest.Citizenship}\", guest.BirthDate=\"{guest.BirthDate}\", guest.Country = (SELECT country.ID FROM country WHERE country.CountryName = \"{guest.Country}\"), guest.ZipCode=\"{guest.ZipCode}\", guest.City=\"{guest.City}\", guest.Address=\"{guest.Address}\", guest.PhoneNumber=\"{guest.PhoneNumber}\", guest.EmailAddress=\"{guest.EmailAddress}\" WHERE guest.ID = \"{guest.Id}\"";

            database.Dml(sql);
        }

        public void AddGuest(Guest guest)
        {
            var sql =
                $"INSERT INTO guest(Name, DocumentNumber, Citizenship, BirthDate, Country, ZipCode, City, Address, PhoneNumber, EmailAddress) VALUES(\"{guest.Name}\", \"{guest.DocumentNumber}\", \"{guest.Citizenship}\", \"{guest.BirthDate}\", (SELECT country.ID FROM country WHERE country.CountryName = \"{guest.Country}\"), \"{guest.ZipCode}\", \"{guest.City}\", \"{guest.Address}\", \"{guest.PhoneNumber}\", \"{guest.EmailAddress}\")";

            database.Dml(sql);
        }

        public int GetNextGuestId()
        {
            const string sql = "SELECT MAX(guest.ID) FROM guest";
            var maxId = database.ScalarDql(sql);

            int.TryParse(maxId, out var nextId);

            return nextId + 1;
        }

        public string[] GetGuestData(string name)
        {
            var data = new string[5];

            if (guests.Count == 0)
                UploadGuestsList();

            foreach (var guest in guests.Where(guest => guest.Name == name))
            {
                data[0] = guest.Name;
                data[1] = guest.Country;
                data[2] = guest.City;
                data[3] = guest.ZipCode;
                data[4] = guest.Address;
            }

            return data;
        }
    }
}
