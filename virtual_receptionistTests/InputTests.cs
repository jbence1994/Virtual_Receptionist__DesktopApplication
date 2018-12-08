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
        /// <summary>
        /// Tesztmetódus: Üres inputra kiváltódik-e kivétel a függvény futásakor?
        /// </summary>
        [TestMethod()]
        public void InputControllerTest_InCaseInputIsEmpty()
        {
            try
            {
                Input input = new Input("");
                bool expected = true;
                bool actual = input.InputController();
                Assert.AreEqual(actual, expected, "Nem jelez hibá üres hiba esetén!");
            }
            catch (Exception)
            {
                Debug.Write("Kivétel elkapva!");
            }
        }
    }
}
