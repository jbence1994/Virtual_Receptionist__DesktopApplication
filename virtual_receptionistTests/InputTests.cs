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

        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsNotValidEmail()
        {
            Input input = new Input("juhasz");

            bool expected = false;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt rossz e-mail inputra");
        }

        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsValidEmail()
        {
            Input input = new Input("juhasz.bence.zsolt@gmail.com");

            bool expected = true;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Bukik a teszt jó e-mail inputra");
        }
    }
}
