using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace virtual_receptionist
{
    public partial class DataStore
    {
        #region Belépési folyamatot vezérlő és ellenőrző metódusok

        /// <summary>
        /// Metódus, amely ellenőrzi van-e felhasználói fiók létrehozva
        /// </summary>
        /// <returns>Ha van felhasználói fiók logikai true-val tér vissza, ellenkező esetben logikai false-szal tér vissza</returns>
        public bool IsAnyAccountExist()
        {
            bool existAnyAccount = false;

            Dictionary<string, string> accounts = new Dictionary<string, string>();

            string username = string.Empty;
            string password = string.Empty;

            mySqlConnection.Open();
            Debug.WriteLine("Sikeres adatbázis kapcsolódás...");

            mySqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM account",
                Connection = mySqlConnection
            };

            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                username = mySqlDataReader["username"].ToString();
                password = mySqlDataReader["password"].ToString();
                accounts.Add(username, password);
            }

            mySqlDataReader.Close();
            Debug.WriteLine("MySqlDataReader olvasás sikeresen befejeződött...");

            if (accounts.Count != 0)
            {
                existAnyAccount = true;
            }

            mySqlConnection.Close();
            Debug.WriteLine("Adatbázis kapcsolat sikeresen lezárult...");

            return existAnyAccount;
        }

        #endregion
    }
}
