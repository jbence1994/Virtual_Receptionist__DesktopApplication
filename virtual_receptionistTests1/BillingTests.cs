using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace virtual_receptionist.DataAccessLayer.BillingTests
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
            Repository repository = new Repository();
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
            Repository repository = new Repository();
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
            Repository repository = new Repository();
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
            Repository repository = new Repository();
            double expected = 6960;
            double actual = repository.CountDiscountPrice(8700, 20);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test1()
        {
            Repository repository = new Repository();
            double expected = 10;
            double actual = repository.CountTotalPrice(1, 2, 3, 4);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test2()
        {
            Repository repository = new Repository();
            double expected = 9000;

            double roomForOnePerson = 8700;
            double cityTaxforOnePerson = 300;

            double actual = repository.CountTotalPrice(roomForOnePerson, cityTaxforOnePerson);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test3()
        {
            Repository repository = new Repository();
            double expected = 12000;

            double roomForTwoPeople = 11400;
            double cityTaxforTwoPeople = 600;

            double actual = repository.CountTotalPrice(roomForTwoPeople, cityTaxforTwoPeople);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test4()
        {
            Repository repository = new Repository();
            double expected = 15000;

            double roomForThreePeople = 14100;
            double cityTaxforThreePeople = 900;

            double actual = repository.CountTotalPrice(roomForThreePeople, cityTaxforThreePeople);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test5()
        {
            Repository repository = new Repository();
            double expected = 18000;

            double roomForFourPeople = 16800;
            double cityTaxforFourPeople = 1200;

            double actual = repository.CountTotalPrice(roomForFourPeople, cityTaxforFourPeople);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }

        /// <summary>
        /// Tesztmetódus, amely kiszámolja a paraméterül kapott számok végösszegét
        /// </summary>
        [TestMethod()]
        public void CountTotalPriceTest_Test6()
        {
            Repository repository = new Repository();
            double expected = 13000;

            double room = 8700;
            double cityTax = 300;
            double cityTaxUnderEighteen = 0;
            double breakfast1 = 1500;
            double breakfast2 = 1500;
            double wash = 1000;

            double actual =
                repository.CountTotalPrice(room, cityTax, cityTaxUnderEighteen, breakfast1, breakfast2, wash);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
    }
}
