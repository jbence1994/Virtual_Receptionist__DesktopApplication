using System;
using virtual_receptionist.Models.ORM;
using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models.DatabaseConnection;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Models.Data
{
    /// <summary>
    /// Szálláshely adattár
    /// </summary>
    public class AccomodationRepository : Repository
    {
        #region Adattagok

        /// <summary>
        /// Szálláshely adatait tartalmazó lista
        /// </summary>
        private List<Accomodation> accomodations;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Szálláshely adattár konstruktora
        /// </summary>
        public AccomodationRepository()
        {
            accomodations = new List<Accomodation>();
        }

        #endregion

        #region Adatelérési és adatfeltöltő metódusok

        /// <summary>
        /// 
        /// </summary>
        private void UploadAccomodationList()
        {
            string sql =
                "SELECT accomodation.ID, accomodation.AccomodationName, accomodation.CompanyName, accomodation.Contact, accomodation.VATNumber, accomodation.Headquarters, accomodation.Site, accomodation.PhoneNumber, accomodation.EmailAddress, accomodation_profile.AccomodationID, accomodation_profile.Password FROM accomodation, accomodation_profile WHERE accomodation.ID = accomodation_profile.Accomodation";
            DataTable dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"].ToString());
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

                Accomodation accomodationInstance = new Accomodation(id, name, company, contact, vatNumber,
                    headquarters, site, phoneNumber, email, accomodationID, password);
                accomodations.Add(accomodationInstance);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Accomodation> GetAccomodations()
        {
            if (accomodations.Count == 0)
            {
                UploadAccomodationList();
            }

            return accomodations;
        }

        #endregion

        #region Üzleti logika

        /// <summary>
        /// Metódus, amely beállítja az adatbáziskapcsolódás típusát és autentikációt végez az alkalmazásba belépéskor
        /// </summary>
        /// <param name="accomodationID">Szálláshely azonosító</param>
        /// <param name="password">Regisztrációhoz tartozó jelszó</param>
        /// <param name="connectionType">Adatbáziskapcsolódás típusa</param>
        /// <returns>Egyezés esetén logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        /// <exception cref="FailedLoginException"></exception>
        /// <exception cref="InvalidConnectionTypeException"></exception>
        public bool Authentication(string accomodationID, string password, string connectionType)
        {
            try
            {
                bool entry = false;

                database.SetConnection(connectionType);

                foreach (Accomodation account in GetAccomodations())
                {
                    if (account.AccomodationID == accomodationID && account.Password == password)
                    {
                        entry = true;
                        break;
                    }

                    throw new FailedLoginException();
                }

                return entry;
            }
            catch (InvalidConnectionTypeException)
            {
                throw new InvalidConnectionTypeException();
            }
        }

        #endregion
    }
}
