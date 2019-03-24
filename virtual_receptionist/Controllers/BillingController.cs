using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Repositories;
using virtual_receptionist.Repositories.Models;
using System;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Controllers.Validation;

namespace virtual_receptionist.Controllers
{
    /// <summary>
    /// Számlázás modul vezérlője
    /// </summary>
    public class BillingController : Controller
    {
        #region Adattagok

        /// <summary>
        /// Számlázás adattár osztály egy példánya
        /// </summary>
        private BillingRepository billingRepository;

        /// <summary>
        /// Foglalások adattár egy példánya
        /// </summary>
        private BookingRepository bookingRepository;

        /// <summary>
        /// Vendég adattár egy példánya
        /// </summary>
        private GuestRepository guestRepository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázás modul vezérlő konstruktora
        /// </summary>
        public BillingController()
        {
            billingRepository = new BillingRepository();
            bookingRepository = new BookingRepository();
            guestRepository = new GuestRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely visszaadja egy adattáblában adattárból azokat a foglalásokat, amelyek még nem kerültek kiszámlázásra
        /// </summary>
        /// <returns>A foglalások adattáblájával tér vissza a metódus</returns>
        public DataTable GetBookingsToBill()
        {
            List<Booking> bookingNotPaid = bookingRepository.GetBookingsNotPaid();

            DataTable bookingsToBill = new DataTable();
            bookingsToBill.Columns.Add("ID", typeof(int));
            bookingsToBill.Columns.Add("Guest", typeof(string));
            bookingsToBill.Columns.Add("Room", typeof(int));
            bookingsToBill.Columns.Add("NumberOfGuests", typeof(int));
            bookingsToBill.Columns.Add("ArrivalDate", typeof(string));
            bookingsToBill.Columns.Add("DepartureDate", typeof(string));

            foreach (Booking booking in bookingNotPaid)
            {
                bookingsToBill.Rows.Add(booking.ID, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsToBill;
        }

        /// <summary>
        /// Metódus, amely lekéri adattárból a paraméterben átadott név alapján a vendég adatait számlázáshoz
        /// </summary>
        /// <param name="name">Vendég neve</param>
        /// <returns>A vendég adatait tároló sztringtömbbel tér vissza a függvény</returns>
        public string[] GetBillingData(string name)
        {
            string[] data = guestRepository.GetGuestDataForBilling(name);
            return data;
        }

        /// <summary>
        /// Metódus, amely lekéri a számlázási tételek adatait az adattárból és visszaadja őket egy adattáblában
        /// </summary>
        /// <returns>A számlázási tételek adataival feltöltött adattáblát adja vissza a függvény</returns>
        public DataTable GetBillingItems()
        {
            List<BillingItem> billingItems = billingRepository.GetBillingItems();

            DataTable billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("CategoryName", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (BillingItem billingItem in billingItems)
            {
                billingItemsDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItem.Category.VAT,
                    billingItem.Category.Name, billingItem.Category.Unit);
            }

            return billingItemsDataTable;
        }

        /// <summary>
        /// Metódus, amely visszaadja a fizetendő végösszeget
        /// </summary>
        /// <param name="price">Tétel egységár</param>
        /// <param name="quantity">Tétel mennyiség</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice(double price, int quantity)
        {
            return billingRepository.CountTotalPrice(price, quantity);
        }

        /// <summary>
        /// Metódus, amely visszaadja egy tétel kedvezményes árát százalékláb alapján
        /// </summary>
        /// <param name="itemPrice">Tétel ára</param>
        /// <param name="footPercent">Százalékláb</param>
        /// <returns>A kedvezményes árral tér vissza a függvény</returns>
        public double GetDiscountPrice(double itemPrice, double footPercent)
        {
            return billingRepository.CountDiscountPrice(itemPrice, footPercent);
        }

        /// <summary>
        /// Számla nyomtatás folyamatának elindítása
        /// </summary>
        /// <param name="bookingID">Foglalás azonosítója</param>
        public void PrintInvoice(int bookingID)
        {
            Booking booking = new Booking()
            {
                ID = Convert.ToInt32(bookingID)
            };

            billingRepository.SetBookingAsPaid(booking);
        }

        /// <summary>
        /// Mennyiség validátor
        /// </summary>
        /// <param name="quantity">Mennyiség</param>
        /// <exception cref="InvalidBllingItemParameterException"></exception>
        public void QuantityValidator(string quantity)
        {
            try
            {
                BillingItemQuantityValidation billingItemQuantityValidation =
                    new BillingItemQuantityValidation(quantity);
                billingItemQuantityValidation.ValidateBillingItemQuantity();
            }
            catch (InvalidBllingItemParameterException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Számlázási tétel validátor
        /// </summary>
        /// <param name="billingItem">Számlázási tétel</param>
        /// <exception cref="InvalidBllingItemParameterException"></exception>
        public void BillingItemValidator(string billingItem)
        {
            try
            {
                BillingItemValidation itemValidation = new BillingItemValidation(billingItem);
                itemValidation.ValidateBillingItem();
            }
            catch (InvalidBllingItemParameterException exception)
            {
                throw exception;
            }
        }

        #endregion
    }
}
