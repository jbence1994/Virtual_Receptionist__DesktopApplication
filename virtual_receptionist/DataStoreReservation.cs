using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Foglalás-kezelő modul metódusai

        /// <summary>
        /// Metódus, amely visszaadja az adatbázisban tárolt összes szobakiadás adatát egy DataTable adatszerkezetben
        /// </summary>
        /// <returns>Adatokkal feltöltött DataTable-t adja vissza</returns>
        public DataTable GetRents()
        {
            DataTable reservations = new DataTable();

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM reservation",
                Connection = mySqlConnection
            };

            mySqlDataAdapter = new MySqlDataAdapter()
            {
                SelectCommand = mySqlCommand
            };

            mySqlCommandBuilder = new MySqlCommandBuilder()
            {
                DataAdapter = mySqlDataAdapter
            };

            mySqlDataAdapter.Fill(reservations);

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");
            
            return reservations;
        }

        #endregion
    }
}
