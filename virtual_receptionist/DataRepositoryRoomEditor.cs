using System;
using System.Data;

namespace virtual_receptionist.Model
{
    public partial class DataRepository
    {
        #region Szobanyilvántartás- és foglaláskezelő modul metódusai

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szobakiadás adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetReservations()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
