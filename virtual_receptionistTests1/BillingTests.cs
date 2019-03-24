using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace virtual_receptionist.Repositories.BillingTests
{
    [TestClass()]
    public class BillingTests
    {
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 8.700 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountDiscountPriceTest_DevelopFunction()
        {
            BillingRepository repository = new BillingRepository();
            double expected = 7830;
            double actual = repository.CountDiscountPrice(8700, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja 11.400 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountDiscountPriceTest_Test1()
        {
            BillingRepository repository = new BillingRepository();
            double expected = 10260;
            double actual = repository.CountDiscountPrice(11400, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja 14.100 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountDiscountPriceTest_Test2()
        {
            BillingRepository repository = new BillingRepository();

            double expected = 12690;
            double actual = repository.CountDiscountPrice(14100, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja 8700 Ft 20%-át
        /// </summary>
        [TestMethod()]
        public void CountDiscountPriceTest_Test3()
        {
            BillingRepository repository = new BillingRepository();

            double expected = 6960;
            double actual = repository.CountDiscountPrice(8700, 20);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott ár-mennyiség arányában a végösszeget
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test1()
        {
            BillingRepository repository = new BillingRepository();

            double expected = 26100;

            double price = 8700;
            int quantity = 3;

            double actual = repository.CountTotalPrice(price, quantity);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott ár-mennyiség arányában a végösszeget
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test2()
        {
            BillingRepository repository = new BillingRepository();

            double expected = 8700;

            double roomForOnePerson = 8700;
            int quantity = 1;

            double actual = repository.CountTotalPrice(roomForOnePerson, quantity);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott ár-mennyiség arányában a végösszeget
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test3()
        {
            BillingRepository repository = new BillingRepository();

            double expected = 22800;

            double roomForTwoPeople = 11400;
            int quantity = 2;

            double actual = repository.CountTotalPrice(roomForTwoPeople, quantity);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
    }
}
