using System;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    public class AccommodationRepository : Repository
    {
        private void SetAccommodation()
        {
            const string sql =
                "SELECT accomodation.ID, accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";

            var dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                var name = row["AccomodationName"].ToString();
                var company = row["CompanyName"].ToString();
                var contact = row["Contact"].ToString();
                var vatNumber = row["VATNumber"].ToString();
                var headquarters = row["Headquarters"].ToString();
                var site = row["Site"].ToString();
                var phoneNumber = row["PhoneNumber"].ToString();
                var email = row["EmailAddress"].ToString();
                var accommodationId = row["AccomodationID"].ToString();
                var password = row["Password"].ToString();

                var accommodation = Accommodation.GetAccommodation();
                accommodation.Name = name;
                accommodation.Company = company;
                accommodation.Contact = contact;
                accommodation.VatNumber = vatNumber;
                accommodation.Headquarters = headquarters;
                accommodation.Site = site;
                accommodation.PhoneNumber = phoneNumber;
                accommodation.EmailAddress = email;
                accommodation.AccommodationId = accommodationId;
                accommodation.Password = password;
            }
        }

        public Accommodation GetAccommodation()
        {
            var accommodation = Accommodation.GetAccommodation();
            SetAccommodation();
            return accommodation;
        }

        public bool Authentication(string accommodationId, string password)
        {
            database.SetConnection();

            var accommodation = GetAccommodation();

            if (accommodation.AccommodationId == accommodationId &&
                accommodation.Password == password)
                return true;

            throw new Exception();
        }
    }
}
