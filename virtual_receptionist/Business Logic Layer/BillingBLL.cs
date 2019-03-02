using System.Linq;
using virtual_receptionist.DataAccessLayer.Data;

namespace virtual_receptionist.BusinessLogicLayer
{
    /// <summary>
    /// Számlázás üzleti logika osztálya
    /// </summary>
    public class BillingBLL
    {
        #region Adattagok

        /// <summary>
        /// Számlázás adattár egy példánya
        /// </summary>
        private BillingRepository repository;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul üzleti logika osztály konstruktora
        /// </summary>
        public BillingBLL()
        {
            repository = new BillingRepository();
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Metódus, amely tétel kedvezményt számít
        /// </summary>
        /// <param name="itemPrice">Tétel értéke, amelyből kedvezményt számol a függvény</param>
        ///<param name="footPercent">Százalékláb értéke</param>
        /// <returns>A kiszámolt kedvezmény értékével tér vissza a függvény</returns>
        public double CountDiscountPrice(double itemPrice, double footPercent)
        {
            double difference = (itemPrice * footPercent) / 100;
            return itemPrice - difference;
        }

        /// <summary>
        /// Metódus, amely kiszámolja a fizetendő végösszeget
        /// </summary>
        /// <param name="prices">Bementi paraméter tétel árak</param>
        /// <returns>Fizetendő végösszeget adja vissza a függvény</returns>
        public double CountTotalPrice(params double[] prices)
        {
            return prices.Sum();
        }

        #endregion
    }
}
