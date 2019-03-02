using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Szálláshely egyed
    /// </summary>
    public class Accomodation
    {
        /// <summary>
        /// 
        /// </summary>
        private int id;

        /// <summary>
        /// 
        /// </summary>
        private string accomodationName;

        /// <summary>
        /// 
        /// </summary>
        private string companyName;

        /// <summary>
        /// 
        /// </summary>
        private string contact;

        /// <summary>
        /// 
        /// </summary>
        private string vatNumber;

        /// <summary>
        /// 
        /// </summary>
        private string headquarters;

        /// <summary>
        /// 
        /// </summary>
        private string site;

        /// <summary>
        /// 
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// 
        /// </summary>
        private string emailAddress;

        /// <summary>
        /// 
        /// </summary>
        private string accomodationID;

        /// <summary>
        /// 
        /// </summary>
        private string password;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accomodationName"></param>
        /// <param name="companyName"></param>
        /// <param name="contact"></param>
        /// <param name="vatNumber"></param>
        /// <param name="headquarters"></param>
        /// <param name="site"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailAddress"></param>
        public Accomodation(int id, string accomodationName, string companyName, string contact, string vatNumber,
            string headquarters, string site,
            string phoneNumber, string emailAddress)
        {
            this.id = id;
            this.accomodationName = accomodationName;
            this.companyName = companyName;
            this.contact = contact;
            this.vatNumber = vatNumber;
            this.headquarters = headquarters;
            this.site = site;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AccomodationName
        {
            get { return accomodationName; }
            set { accomodationName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VATNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Headquarters
        {
            get { return headquarters; }
            set { headquarters = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Site
        {
            get { return site; }
            set { site = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        ///
        public string AccomodationID
        {
            get { return accomodationID; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get { return password; }
        }

        public override string ToString()
        {
            return
                $"{id} {accomodationName} {companyName} {contact} {vatNumber} {headquarters} {site} {phoneNumber} {emailAddress}";
        }
    }
}
