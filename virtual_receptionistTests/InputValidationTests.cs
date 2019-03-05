using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist.Controllers.Exceptions;

namespace virtual_receptionist.Controllers.Validation.ValidationTests
{
    [TestClass()]
    public class InputValidationTests
    {
        #region Névellenőrző tesztek

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
        public void ValidateNameTest_InCaseContainsDigitCharacters()
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
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e bemeneti e-mail cím /Regulax Expression/
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
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e bemeneti e-mail cím /Regulax Expression/
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
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat3()
        {
            try
            {
                EmailValidation validation = new EmailValidation("teszt.teszt@teszt.com.hu");
                validation.ValidateEmail();
                Assert.Fail("Nem dob kivételt rossz e-mail cím formátumra");
            }
            catch (InvalidEmailAddressException)
            {
            }
        }

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, érvényes e-mail cím formátum-e bemeneti e-mail cím /Regulax Expression/
        /// </summary>
        [TestMethod()]
        public void ValidateEmailTest_InCaseEmailIsNotValidEmailFormat4()
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

        #endregion

        #region Születési dátum tesztek

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
                BirthDateValidation validation = new BirthDateValidation("1994-03-24");
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
        public void ValidateBirthDateTest_InCaseInputBirthDateIsNotValidBirthDateFormat2()
        {
            try
            {
                BirthDateValidation validation = new BirthDateValidation("1994.03.24.");
                validation.ValidateBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dtáum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        #endregion
    }
}
