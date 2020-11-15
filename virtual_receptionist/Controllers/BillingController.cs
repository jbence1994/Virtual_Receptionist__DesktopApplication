using System.Data;
using virtual_receptionist.Repositories;

namespace virtual_receptionist.Controllers
{
    public class BillingController : Controller
    {
        private readonly BillingRepository billingRepository = new BillingRepository();
        private readonly BookingRepository bookingRepository = new BookingRepository();

        public DataTable GetUnpaidBookings()
        {
            var unpaidBookings = bookingRepository.GetUnpaidBookings();

            var bookingsToBill = new DataTable();

            bookingsToBill.Columns.Add("ID", typeof(int));
            bookingsToBill.Columns.Add("Guest", typeof(string));
            bookingsToBill.Columns.Add("Room", typeof(int));
            bookingsToBill.Columns.Add("NumberOfGuests", typeof(int));
            bookingsToBill.Columns.Add("ArrivalDate", typeof(string));
            bookingsToBill.Columns.Add("DepartureDate", typeof(string));

            foreach (var booking in unpaidBookings)
            {
                bookingsToBill.Rows.Add(booking.Id, booking.Guest.Name, booking.Room.Number, booking.NumberOfGuests,
                    booking.ArrivalDate, booking.DepartureDate);
            }

            return bookingsToBill;
        }

        public DataTable GetBillingItems()
        {
            var billingItems = billingRepository.GetBillingItems();

            var billingItemsDataTable = new DataTable();
            billingItemsDataTable.Columns.Add("Name", typeof(string));
            billingItemsDataTable.Columns.Add("Price", typeof(double));
            billingItemsDataTable.Columns.Add("VAT", typeof(double));
            billingItemsDataTable.Columns.Add("CategoryName", typeof(string));
            billingItemsDataTable.Columns.Add("Unit", typeof(string));

            foreach (var billingItem in billingItems)
            {
                billingItemsDataTable.Rows.Add(billingItem.Name, billingItem.Price, billingItem.Category.Vat,
                    billingItem.Category.Name, billingItem.Category.Unit);
            }

            return billingItemsDataTable;
        }
    }
}
