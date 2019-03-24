using virtual_receptionist.Controllers.Exceptions;
using static virtual_receptionist.Controllers.Validation.InputValidation;

namespace virtual_receptionist.Controllers.Validation
{
    /// <summary>
    /// Tétel ellenőrző osztály
    /// </summary>
    public class ItemValidation
    {
        /// <summary>
        /// Tétel input
        /// </summary>
        private string item;

        /// <summary>
        /// Tétel ellenőrző osztály konstruktora
        /// </summary>
        /// <param name="item">Tétel input</param>
        public ItemValidation(string item)
        {
            this.item = item;
        }

        /// <summary>
        /// Tétel ellenőrző metódus
        /// </summary>
        public void ValidateItem()
        {
            if (IsEmpty(item))
            {
                throw new InvalidBllingItemParameterException("Nincs kijelölt tétel!");
            }
        }
    }
}
