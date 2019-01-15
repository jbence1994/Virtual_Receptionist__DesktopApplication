using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

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
        { return new DataTable(); }

        #endregion
    }
}
