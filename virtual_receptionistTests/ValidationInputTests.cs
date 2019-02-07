using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist.Exceptions;

namespace virtual_receptionist.Validation.ValidationTests
{
    [TestClass()]
    public class ValidationInputTests
    {
        #region Névellenőrző tesztek

        /// <summary>
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti név
        /// </summary>
        [TestMethod()]
        public void ProvideNameTest_InCaseInputNameIsEmpty()
        {
            try
            {
                Input inputName = new Input("");
                inputName.ProvideName();
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
        public void ProvideNameTest_InCaseInputNamesFirstLetterIsLowercase()
        {
            try
            {
                Input inputName = new Input("juhász");
                inputName.ProvideName();
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
        public void ProvideNameTest_InCaseContainsDigitCharacters()
        {
            try
            {
                Input inputName = new Input("Juhász1");
                inputName.ProvideName();
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
        public void ProvideEmailTest_InCaseInputNameIsEmpty()
        {
            try
            {
                Input inputEmail = new Input("");
                inputEmail.ProvideEmail();
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
        public void ProvideEmailTest_InCaseEmailIsNotValidEmailFormat1()
        {
            try
            {
                Input inputEmail = new Input("teszt.teszt.com");
                inputEmail.ProvideEmail();
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
        public void ProvideEmailTest_InCaseEmailIsNotValidEmailFormat2()
        {
            try
            {
                Input inputEmail = new Input("teszt.@teszt.com");
                inputEmail.ProvideEmail();
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
        public void ProvideEmailTest_InCaseEmailIsNotValidEmailFormat3()
        {
            try
            {
                Input inputEmail = new Input("teszt.teszt@teszt.com.hu");
                inputEmail.ProvideEmail();
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
        public void ProvideEmailTest_InCaseEmailIsNotValidEmailFormat4()
        {
            try
            {
                Input inputEmail = new Input("teszt...................@teszt.com");
                inputEmail.ProvideEmail();
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
        public void ProvideEmailTest_InCaseInputBirthDateIsEmpty()
        {
            try
            {
                Input inputBirthDate = new Input("");
                inputBirthDate.ProvideBirthDate();
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
        public void ProvideEmailTest_InCaseInputBirthDateIsNotValidBirthDateFormat1()
        {
            try
            {
                Input inputBirthDate = new Input("");
                inputBirthDate.ProvideBirthDate();
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
        public void ProvideEmailTest_InCaseInputBirthDateIsNotValidBirthDateFormat2()
        {
            try
            {
                Input inputBirthDate = new Input("");
                inputBirthDate.ProvideBirthDate();
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
        public void ProvideEmailTest_InCaseInputBirthDateIsNotValidBirthDateFormat3()
        {
            try
            {
                Input inputBirthDate = new Input("");
                inputBirthDate.ProvideBirthDate();
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
        public void ProvideEmailTest_InCaseInputBirthDateIsNotValidBirthDateFormat4()
        {
            try
            {
                Input inputBirthDate = new Input("");
                inputBirthDate.ProvideBirthDate();
                Assert.Fail("Nem dob kivételt rossz születési dtáum formátumra!");
            }
            catch (InvalidBirthDateException)
            {
            }
        }

        #endregion
    }
}
