using MySql.Data.MySqlClient;
using System.Data;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Vendégadatbázis-szerkesztő modul metódusai

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes vendéget egy DataTable adatszerkezetben
        /// </summary>
        /// <returns></returns>
        public DataTable GetGuests()
        {
            DataTable guests = new DataTable();

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
