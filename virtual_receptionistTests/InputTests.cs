using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace virtual_receptionist.Tests
{
    [TestClass()]
    public class InputTests
    {
        #region IsEmpty() tesztek

        [TestMethod()]
        public void IsEmptyTest_InCaseInputIsNotEmpty()
        {
            Input input = new Input("test");

            bool expected = false;
            bool actual = input.IsEmpty();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt nem üres inputra");
        }

        [TestMethod()]
        public void IsEmptyTest_InCaseInputIsEmpty()
        {
            Input input = new Input("");

            bool expected = true;
            bool actual = input.IsEmpty();
            Assert.AreEqual(expected, actual, "Bukik a tezt üres inputra");

        }

        #endregion

        #region IsValidEmailAddress() tesztek

        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsNotValidEmail()
        {
            Input input = new Input("test.com");

            bool expected = false;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt rossz e-mail inputra");
        }

        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsValidEmail()
        {
            Input input = new Input("test@test.co.uk");

            bool expected = true;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Bukik a teszt jó e-mail inputra");
        }

        #endregion

        #region FirstLetterIsUppercaseCharacter() tesztek

        [TestMethod()]
        public void FirstLetterIsUppercaseCharacterTest_InCaseFirstLetterIsLowercase()
        {
            Input input = new Input("test");

            bool expected = false;
            bool actual = input.FirstLetterIsUppercaseCharacter();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt rossz inputra");
        }

        [TestMethod()]
        public void FirstLetterIsUppercaseCharacterTest_InCaseFirstLetterIsUppercase()
        {
            Input input = new Input("Test");

            bool expected = true;
            bool actual = input.FirstLetterIsUppercaseCharacter();
            Assert.AreEqual(expected, actual, "Bukik a teszt jó inputra");
        }

        #endregion
    }
}
