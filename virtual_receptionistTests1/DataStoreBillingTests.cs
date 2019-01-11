using Microsoft.VisualStudio.TestTools.UnitTesting;
using virtual_receptionist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist.Model.Tests
{
    [TestClass()]
    public class DataStoreBillingTests
    {
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 8.700 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_DevelopFunction()
        {
            DataStore dataStore = new DataStore();
            double expected = 7830;
            double actual = dataStore.CountDiscountPrice(8700, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 11.400 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_Test1()
        {
            DataStore dataStore = new DataStore();
            double expected = 10260;
            double actual = dataStore.CountDiscountPrice(11400, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 11.400 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_Test2()
        {
            DataStore dataStore = new DataStore();
            double expected = 12690;
            double actual = dataStore.CountDiscountPrice(14100, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
    }
}
