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

        #endregion
    }
}
