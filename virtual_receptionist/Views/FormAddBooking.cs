using System.Windows.Forms;
using System;
using System.Linq;
using virtual_receptionist.Models;
using virtual_receptionist.Repositories;
using virtual_receptionist.Validation;

namespace virtual_receptionist.Views
{
    public partial class FormAddBooking : Form
    {
        private readonly BookingRepository bookingRepository = new BookingRepository();
        private readonly CountryRepository countryRepository = new CountryRepository();
        private readonly RoomRepository roomRepository = new RoomRepository();
        private readonly GuestRepository guestRepository = new GuestRepository();

        /// <summary>
        /// Foglalási napló foglalásfelvétel modális ablak konstruktora
        /// </summary>
        public FormAddBooking()
        {
            InitializeComponent();
        }

        private void FormBookingManager_Load(object sender, EventArgs e)
        {
            textBoxGuestName.Select();
            comboBoxCountry.DataSource = countryRepository.GetCountries().Select(country => country.Name).ToList();
            comboBoxRoom.DataSource = roomRepository.GetRooms().Select(room => room.Number).ToList();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool validData = true;

            /*
             * Vendégadatok validálása
             */

            string name = textBoxGuestName.Text;
            string documentNumber = textBoxDocumentNumber.Text;
            string citizenship = textBoxCitizenship.Text;
            string birthDate = textBoxBirthDate.Text;
            string country = comboBoxCountry.SelectedItem.ToString();
            string zipCode = textBoxZipCode.Text;
            string city = textBoxCity.Text;
            string address = textBoxAddress.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmailAddress.Text;

            try
            {
                NameValidation.ValidateName(name);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderName.SetError(textBoxGuestName, exception.Message);
                validData = false;
            }

            try
            {
                DocumentNumberValidation.ValidateDocumentNumber(documentNumber);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderDocumentNumber.SetError(textBoxDocumentNumber, exception.Message);
                validData = false;
            }

            try
            {
                CitizenshipValidation.ValidateCitizenship(citizenship);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderCitizenship.SetError(textBoxCitizenship, exception.Message);
                validData = false;
            }

            try
            {
                BirthDateValidation.ValidateBirthDate(birthDate);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderBirthDate.SetError(textBoxBirthDate, exception.Message);
                validData = false;
            }

            try
            {
                ZipCodeValidation.ValidateZipCode(zipCode);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderZipCode.SetError(textBoxZipCode, exception.Message);
                validData = false;
            }

            try
            {
                CityValidation.ValidateCity(city);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderCity.SetError(textBoxCity, exception.Message);
                validData = false;
            }

            try
            {
                AddressValidation.ValidateAddress(address);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderAddress.SetError(textBoxAddress, exception.Message);
                validData = false;
            }

            try
            {
                PhoneNumberValidation.ValidatePhoneNumber(phoneNumber);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderPhoneNumber.SetError(textBoxPhoneNumber, exception.Message);
                validData = false;
            }

            try
            {
                EmailValidation.ValidateEmail(email);
            }
            catch (Exception exception)
            {
                DialogResult = DialogResult.None;
                errorProviderEmailAddress.SetError(textBoxEmailAddress, exception.Message);
                validData = false;
            }

            /*
             * Foglalásadatok validálása
             */

            int roomNumber = Convert.ToInt32(comboBoxRoom.SelectedItem);
            decimal numberOfGuests = numericUpDownNumberOfGuests.Value;
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            DateTime departureDate = dateTimePickerDepartureDate.Value;

            try
            {
                errorProviderDepartureDate.Clear();
                BookingDateValidator(arrivalDate, departureDate);
            }
            catch (Exception exception)
            {
                errorProviderDepartureDate.SetError(dateTimePickerDepartureDate, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            try
            {
                errorProviderFreeCapacity.Clear();
                FreeRoomCapacityValidator(arrivalDate, roomNumber);
            }
            catch (Exception exception)
            {
                errorProviderFreeCapacity.SetError(comboBoxRoom, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            try
            {
                errorProviderNumberOfGuests.Clear();
                BookingCapacityValidator(numberOfGuests, roomNumber);
            }
            catch (Exception exception)
            {
                errorProviderNumberOfGuests.SetError(numericUpDownNumberOfGuests, exception.Message);
                DialogResult = DialogResult.None;
                validData = false;
            }

            if (!validData)
                return;

            AddGuest(name, documentNumber, citizenship, birthDate, country, zipCode, city,
                address, phoneNumber, email);
            AddBooking(name, roomNumber, numberOfGuests, arrivalDate, departureDate);
        }

        private void textBoxGuestName_TextChanged(object sender, EventArgs e)
        {
            errorProviderName.Clear();
        }

        private void textBoxDocumentNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderDocumentNumber.Clear();
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderEmailAddress.Clear();
        }

        private void textBoxBirthDate_TextChanged(object sender, EventArgs e)
        {
            errorProviderBirthDate.Clear();
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            errorProviderZipCode.Clear();
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            errorProviderCity.Clear();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            errorProviderPhoneNumber.Clear();
        }

        private void textBoxCitizenship_TextChanged(object sender, EventArgs e)
        {
            errorProviderCitizenship.Clear();
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            errorProviderDepartureDate.Clear();
        }

        private void numericUpDownNumberOfGuests_ValueChanged(object sender, EventArgs e)
        {
            errorProviderNumberOfGuests.Clear();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderFreeCapacity.Clear();
        }

        private void AddBooking(params object[] bookingParameters)
        {
            var guest = new Guest
            {
                Name = bookingParameters[0].ToString()
            };

            var room = new Room
            {
                Number = Convert.ToInt32(bookingParameters[1])
            };

            var numberOfGuests = Convert.ToInt32(bookingParameters[2]);

            var arrivalDate = Convert.ToDateTime(bookingParameters[3]).ToString("yyyy-MM-dd");

            var departureDate = Convert.ToDateTime(bookingParameters[4]).ToString("yyyy-MM-dd");

            const bool paid = false;

            var booking = new Booking
            {
                Guest = guest,
                Room = room,
                NumberOfGuests = numberOfGuests,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                IsPaid = paid
            };

            bookingRepository.AddBooking(booking);
        }

        public void BookingDateValidator(DateTime arrivalDate, DateTime departureDate)
        {
            var booking = new Booking
            {
                ArrivalDate = arrivalDate.ToString(),
                DepartureDate = departureDate.ToString()
            };

            BookingDateValidation.ValidateBookingDate(booking);
        }

        public void BookingCapacityValidator(decimal numberOfGuests, int roomNumber)
        {
            var room = new Room
            {
                Capacity = roomRepository.GetRoomCapacity(roomNumber)
            };

            var booking = new Booking
            {
                NumberOfGuests = Convert.ToInt32(numberOfGuests),
                Room = room
            };

            BookingCapacityValidation.ValidateBookingCapacity(booking);
        }

        public void FreeRoomCapacityValidator(DateTime arrivalDate, int roomNumber)
        {
            var room = new Room
            {
                Number = roomNumber
            };

            var booking = new Booking
            {
                Room = room,
                ArrivalDate = arrivalDate.ToString("yyyy-MM-dd")
            };

            bookingRepository.ValidateFreeRoomCapacityOnSpecifiedArrivalDate(booking);
        }

        public void AddGuest(params object[] guestParameters)
        {
            var name = guestParameters[0].ToString();
            var documentNumber = guestParameters[1].ToString();
            var citizenship = guestParameters[2].ToString();
            var birthDate = guestParameters[3].ToString();
            var country = guestParameters[4].ToString();
            var zipCode = guestParameters[5].ToString();
            var city = guestParameters[6].ToString();
            var address = guestParameters[7].ToString();
            var phoneNumber = guestParameters[8].ToString();
            var email = guestParameters[9].ToString();

            var guest = new Guest
            {
                Name = name,
                DocumentNumber = documentNumber,
                Citizenship = citizenship,
                BirthDate = birthDate,
                Country = country,
                ZipCode = zipCode,
                City = city,
                Address = address,
                PhoneNumber = phoneNumber,
                EmailAddress = email
            };

            guestRepository.AddGuest(guest);
        }
    }
}
