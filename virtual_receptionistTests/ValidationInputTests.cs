using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist.Exceptions;

namespace virtual_receptionist.Validation.ValidationTests
{
    [TestClass()]
    public class ValidationInputTests
    {
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
        /// Tesztmetódus, amely ellenőrzi, üres-e a bemeneti név
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
    }
}
