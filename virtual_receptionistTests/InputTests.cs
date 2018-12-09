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
            Assert.AreEqual(expected, actual, "Nem bukik a tezt üres inputra");

        }
    }
}
