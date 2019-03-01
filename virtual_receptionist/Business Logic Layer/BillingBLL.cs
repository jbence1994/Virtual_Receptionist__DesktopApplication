using System.Linq;

namespace virtual_receptionist.BusinessLogicLayer
{
    public class BillingBLL
    {
        #region Számlázó üzleti logika metódusok

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
