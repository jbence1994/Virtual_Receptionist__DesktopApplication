using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Vendégadatbázis-szerkesztő modul metódusai

        public List<Guest> GetGuests()
        {
            List<Guest> guests = new List<Guest>();

            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM guest",
                Connection = mySqlConnection
            };

            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Guest guest = new Guest();

                guest.Name = mySqlDataReader["Name"].ToString();

                if (mySqlDataReader["Nationality"].ToString() == "0")
                {
                    guest.Nationality = true;
                }
                else
                {
                    guest.Nationality = false;
                }

                guest.Address = mySqlDataReader["Address"].ToString();
                guest.City = mySqlDataReader["City"].ToString();
                guest.ZipCode = mySqlDataReader["ZipCode"].ToString();
                guest.Country = mySqlDataReader["Country"].ToString();
                guest.VatNumber = mySqlDataReader["VATNumber"].ToString();
                guest.PhoneNumber = mySqlDataReader["PhoneNumber"].ToString();
                guest.EmailAddress = mySqlDataReader["EmailAddress"].ToString();

                guests.Add(guest);
            }

            mySqlConnection.Close();

            return guests;
        }

        #endregion
    }
}
