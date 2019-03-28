using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist.Controllers.Validation;
using virtual_receptionist.Controllers.Exceptions;
using virtual_receptionist.Repositories.Models;
using System.Collections.Generic;

namespace virtual_receptionistTests.InputValidation
{
    [TestClass()]
    public class InputValidationTests
    {
        #region Név ellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti név
        /// </summary>
        [TestMethod()]
        public void ValidateNameTest_InCaseInputNameIsEmpty()
        {
            try
            {
                NameValidation validation = new NameValidation("");
                validation.ValidateName();
                Assert.Fail("Nem dobott kivételt üres névre!");
            }
            catch (InvalidNameException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kisbetűvel kezdődik-e bemeneti név
        /// </summary>
        [TestMethod()]
        public void ValidateNameTest_InCaseInputNamesFirstLetterIsLowercase()
        {
            try
            {
                NameValidation validation = new NameValidation("juhász");
                validation.ValidateName();
                Assert.Fail("Nem dobott kivételt kisbetűs névre!");
            }
            catch (InvalidNameException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, tartalmaz-e számot a bemeneti név
        /// </summary>
        [TestMethod()]
        public void ValidateNameTest_InCaseInputNameContainsDigitCharacters()
        {
            try
            {
                NameValidation validation = new NameValidation("Juhász1");
                validation.ValidateName();
                Assert.Fail("Nem dobott kivételt számot tartalmazó bemeneti névre");
            }
            catch (InvalidNameException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, tartalmaz-e számot a bemeneti név
        /// </summary>
        [TestMethod()]
        public void ValidateNameTest_InCaseInputNameIsValid()
        {
            try
            {
                NameValidation validation = new NameValidation("Juhász Bence");
                validation.ValidateName();
            }
            catch (InvalidNameException)
            {
            }
        }

        #endregion

        #region E-mail cím ellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti e-mail cím
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseInputNameIsEmpty()
        {
            try
            {
                EmailValidation validation = new EmailValidation("");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt üres e-mail címre!");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat1()
        {
            try
            {
                EmailValidation validation = new EmailValidation("teszt.teszt.com");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat2()
        {
            try
            {
                EmailValidation validation = new EmailValidation("teszt.@teszt.com");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat3()
        {
            try
            {
                EmailValidation validation = new EmailValidation("teszt...................@teszt.com");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat4()
        {
            try
            {
                EmailValidation validation = new EmailValidation("juhasz_bence_zsolt:@teszt.hu.com");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat5()
        {
            try
            {
                EmailValidation validation = new EmailValidation("juhasz:bence:zsolt@gmail.com");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e a bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsValidEmailFormat()
        {
            try
            {
                EmailValidation validation = new EmailValidation("juhasz.bence.zsolt@gmail.com");
                validation.ValidateEmail();
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        #endregion

        #region Születési dátum ellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti születési dátum
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsEmpty()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt üres születési dátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat1()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994.03.27");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dátum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat2()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994/03/27");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dátum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat3()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994.13.32.");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dtáum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat4()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994/13/32");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dátum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat5()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994/13.32");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dátum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat6()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("j994-03-27");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dátum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes születési dátum formátum-e bemeneti születési dátum /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateBirthDateTest_InCaseInputBirthDateIsValidBirthDateFormat()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994-03-27");
                validation.ValidateBirthDate();
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        #endregion

        #region Állampolgárság ellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti állampolgárság
        /// </summary>
        [TestMethod()]
        public void ValidateCitizenshipTest_InCaseInputCitizenshipIsEmpty()
        {
            try
            {
                CitizenshipValidation validation = new CitizenshipValidation("");
                validation.ValidateCitizenship();
                Assert.Fail("Nem dob kivételt üres állampolgárságra!");
            }
            catch (InvalidCitizenshipException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, helyes-e a bemeneti állampolgárság
        /// </summary>
        [TestMethod()]
        public void ValidateCitizenshipTest_InCaseInputCitizenshipIsNotValid1()
        {
            try
            {
                CitizenshipValidation validation = new CitizenshipValidation("Magyar");
                validation.ValidateCitizenship();
                Assert.Fail("Nem dob kivételt rossz állampolgárságra!");
            }
            catch (InvalidCitizenshipException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, helyes-e a bemeneti állampolgárság
        /// </summary>
        [TestMethod()]
        public void ValidateCitizenshipTest_InCaseInputCitizenshipIsNotValid2()
        {
            try
            {
                CitizenshipValidation validation = new CitizenshipValidation("magyar1");
                validation.ValidateCitizenship();
                Assert.Fail("Nem dob kivételt rossz állampolgárságra!");
            }
            catch (InvalidCitizenshipException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, helyes-e a bemeneti állampolgárság
        /// </summary>
        [TestMethod()]
        public void ValidateCitizenshipTest_InCaseInputCitizenshipIsNotValid3()
        {
            try
            {
                CitizenshipValidation validation = new CitizenshipValidation("mAgyar");
                validation.ValidateCitizenship();
                Assert.Fail("Nem dob kivételt rossz állampolgárságra!");
            }
            catch (InvalidCitizenshipException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, helyes-e a bemeneti állampolgárság
        /// </summary>
        [TestMethod()]
        public void ValidateCitizenshipTest_InCaseInputCitizenshipIsValid()
        {
            try
            {
                CitizenshipValidation validation = new CitizenshipValidation("magyar");
                validation.ValidateCitizenship();
            }
            catch (InvalidCitizenshipException)
            {
            }
        }

        #endregion

        #region Foglalás szobakapcitás és vendég szám ellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha nagyobb vendégszámot adunk meg olyan szobára, amely annál kisebb kapacitással rendelkezik
        /// </summary>
        [TestMethod()]
        public void ValidateBookingCapacity_InCaseNumberOfGuestAreMoreThanRoomCapacity()
        {
            Room roomTestObject = new Room();
            roomTestObject.Name = "Családi szoba";
            roomTestObject.Capacity = 4;

            Booking bookingTestObject = new Booking();

            bookingTestObject.Room = roomTestObject;
            bookingTestObject.NumberOfGuests = 5;

            try
            {
                BookingCapacityValidation bookingCapacityValidation = new BookingCapacityValidation(bookingTestObject, roomTestObject);
                bookingCapacityValidation.ValidateBookingCapacity();
                Assert.Fail("Nem dob kivételt nagyobb vendégszám esetén!");
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha kisebb vendégszámot adunk meg olyan szobára, amely annál nagyobb kapacitással rendelkezik
        /// </summary>
        [TestMethod()]
        public void ValidateBookingCapacity_InCaseNumberOfGuestAreLessThanRoomCapacity()
        {
            Room roomTestObject = new Room();
            roomTestObject.Name = "Háromágyas szoba";
            roomTestObject.Capacity = 3;

            Booking bookingTestObject = new Booking();

            bookingTestObject.Room = roomTestObject;
            bookingTestObject.NumberOfGuests = 2;

            try
            {
                BookingCapacityValidation bookingCapacityValidation = new BookingCapacityValidation(bookingTestObject, roomTestObject);
                bookingCapacityValidation.ValidateBookingCapacity();
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha ugyanolyan vendégszámot adunk meg olyan szobára, amely azzalé egyenlő kapacitással rendelkezik
        /// </summary>
        [TestMethod()]
        public void ValidateBookingCapacity_InCaseNumberOfGuestAreEqualsToRoomCapacity()
        {
            Room roomTestObject = new Room();
            roomTestObject.Name = "Háromágyas szoba";
            roomTestObject.Capacity = 3;

            Booking bookingTestObject = new Booking();

            bookingTestObject.Room = roomTestObject;
            bookingTestObject.NumberOfGuests = 3;

            try
            {
                BookingCapacityValidation bookingCapacityValidation = new BookingCapacityValidation(bookingTestObject, roomTestObject);
                bookingCapacityValidation.ValidateBookingCapacity();
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        #endregion

        #region Foglalás időpont tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha az érkezés és távozás dátuma egyezik
        /// </summary>
        [TestMethod()]
        public void ValidateBookingDate_InCaseBookingArrivalDateIsEqualsToDepartureDate()
        {
            Booking bookingTestObject = new Booking();
            bookingTestObject.ArrivalDate = "2019-03-25";
            bookingTestObject.DepartureDate = "2019-03-25";

            try
            {
                BookingDateValidation bookingDateValidation = new BookingDateValidation(bookingTestObject);
                bookingDateValidation.ValidateBookingDate();
                Assert.Fail("Nem dob kivételt, amennyiben az érkezés dátuma megegyezik a távozás dátuma!");
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha a távozás dátuma hamarabb van, mint az érkezés dátuma
        /// </summary>
        [TestMethod()]
        public void ValidateBookingDate_InCaseBookingArrivalDateIsLaterThanDepartureDate()
        {
            Booking bookingTestObject = new Booking();
            bookingTestObject.ArrivalDate = "2019-03-27";
            bookingTestObject.DepartureDate = "2019-03-26";

            try
            {
                BookingDateValidation bookingDateValidation = new BookingDateValidation(bookingTestObject);
                bookingDateValidation.ValidateBookingDate();
                Assert.Fail("Nem dob kivételt, ha az érkezés dátuma később van, mint a távozás dátuma!");
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, kivételkezelésre kerül-e ha az érkezés dátuma hamarabb van, mint a távozás dátuma
        /// </summary>
        [TestMethod()]
        public void ValidateBookingDate_InCaseBookingArrivalDateEarlierThanDepartureDate()
        {
            Booking bookingTestObject = new Booking();
            bookingTestObject.ArrivalDate = "2019-03-25";
            bookingTestObject.DepartureDate = "2019-03-26";

            try
            {
                BookingDateValidation bookingDateValidation = new BookingDateValidation(bookingTestObject);
                bookingDateValidation.ValidateBookingDate();
            }
            catch (InvalidBookingParameterException)
            {
            }
        }

        #endregion
    }
}
