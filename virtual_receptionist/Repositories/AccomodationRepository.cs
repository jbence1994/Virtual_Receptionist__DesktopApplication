using System;
using System.Data;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    /// <summary>
    /// Szálláshely adattár
    /// </summary>
    public class AccomodationRepository : Repository
    {
        #region Adatfeltöltő metódusok

        /// <summary>
        /// Metódus, amely beállítja a szálláshely adatait, amyel az adatábzisban van regisztrálva
        /// </summary>
        private void SetAccomodation()
        {
            string sql =
                "SELECT accomodation.ID, accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                string name = row["AccomodationName"].ToString();
                string company = row["CompanyName"].ToString();
                string contact = row["Contact"].ToString();
                string vatNumber = row["VATNumber"].ToString();
                string headquarters = row["Headquarters"].ToString();
                string site = row["Site"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string email = row["EmailAddress"].ToString();

                string accomodationID = row["AccomodationID"].ToString();
                string password = row["Password"].ToString();

                Accomodation accomodation = Accomodation.GetAccomodation();
                accomodation.AccomodationName = name;
                accomodation.CompanyName = company;
                accomodation.Contact = contact;
                accomodation.VATNumber = vatNumber;
                accomodation.Headquarters = headquarters;
                accomodation.Site = site;
                accomodation.PhoneNumber = phoneNumber;
                accomodation.EmailAddress = email;
                accomodation.AccomodationID = accomodationID;
                accomodation.Password = password;
            }
        }

        #endregion

        #region Üzleti logika

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Accomodation GetAccomodation()
        {
            Accomodation accomodation = Accomodation.GetAccomodation();
            SetAccomodation();
            return accomodation;
        }

        /// <summary>
        /// Metódus, amely beállítja az adatbáziskapcsolódás típusát és autentikációt végez az alkalmazásba belépéskor
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="Exception"></exception>
        public bool Authentication(string accomodationID, string password)
        {
            try
            {
                database.SetConnection();

                Accomodation accomodation = GetAccomodation();

                if (accomodation.AccomodationID == accomodationID && accomodation.Password == password)
                {
                    return true;
                }

                throw new FailedLoginException();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        #endregion
    }
}
