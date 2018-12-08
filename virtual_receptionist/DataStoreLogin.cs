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

        public bool IsAnyAccountExist()
        {
            bool existAnyAccount = false;

            Dictionary<string, string> accounts = new Dictionary<string, string>();

            string username = string.Empty;
            string password = string.Empty;

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

            if (accounts.Count != 0)
            {
                existAnyAccount = true;
            }

            return existAnyAccount;
        }

        #endregion
    }
}
