using System.Data;
using System.Collections.Generic;
using virtual_receptionist.Models.Data;
using virtual_receptionist.Models.ORM;
using System;

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

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázás modul vezérlő konstruktora
        /// </summary>
        public BillingController()
        {
            billingRepository = new BillingRepository();
            bookingRepository = new BookingRepository();
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
        /// Metódus, amely beállítja a számlázási tétel adatait
        /// </summary>
        /// <param name="itemParameters">Számlázási tétel paraméterei</param>
        public void SetBillingItemParameters(params object[] itemParameters)
        {
            DataTable billingDataTable = new DataTable();
            billingDataTable.Columns.Add("Tétel", typeof(string));
            billingDataTable.Columns.Add("Ár", typeof(double));
            billingDataTable.Columns.Add("Egység", typeof(string));
            billingDataTable.Columns.Add("Mennyiség", typeof(int));

            string item = itemParameters[0].ToString();
            double vat = Convert.ToDouble(itemParameters[1].ToString());
            string unit = itemParameters[1].ToString();
            double price = double.Parse(itemParameters[2].ToString());
            int quantity = int.Parse(itemParameters[3].ToString());
        }

        /// <summary>
        /// Új rekord hozzáadása
        /// </summary>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable AddNewRow()
        {
            return new DataTable();
        }

        /// <summary>
        /// Rekord törlése
        /// </summary>
        /// <param name="index">Törlendő rekord</param>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable DeleteRow(int index)
        {
            return new DataTable();
        }

        /// <summary>
        /// Rekord módosítása
        /// </summary>
        /// <param name="index">Módosítandó rekord</param>
        /// <returns>Módosított adattáblát adja vissza a függvény</returns>
        public DataTable UpdateRow(int index)
        {
            return new DataTable();
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
        /// <param name="prices">Bementi paraméter tétel árak</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double GetTotalPrice(params double[] prices)
        {
            double total = billingRepository.CountTotalPrice(prices);
            return total;
        }

        #endregion
    }
}
