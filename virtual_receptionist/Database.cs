using System.Xml;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.Model
{
    /// <summary>
    /// Adatbázis műveleteket és interakciókat végző ORM osztály
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// Adatbázis kapcsolatot létrehozó mező
        /// </summary>
        private static MySqlConnection mySqlConnection;
        /// <summary>
        /// SQL utasítást vágrehajtó mező
        /// </summary>
        private static MySqlCommand mySqlCommand;
        /// <summary>
        /// Adatbázis adatot olvasó mező
        /// </summary>
        private static MySqlDataReader mySqlDataReader;
        /// <summary>
        /// Adatszerkezeteket adattal feltöltő osztály egy példánya
        /// </summary>
        private static MySqlDataAdapter mySqlDataAdapter;
        /// <summary>
        /// SQL DML és DDL parancsokat egyszerűen végrehajtó osztály egy példánya
        /// </summary>
        private static MySqlCommandBuilder mySqlCommandBuilder;

        /// <summary>
        /// Adatbázis műveleteket és interakciókat végző ORM osztály statikus konstruktora
        /// </summary>
        static Database()
        {
            mySqlConnection = new MySqlConnection()
            {
                ConnectionString = ""
            };
        }

        /// <summary>
        /// 
        /// </summary>
        private static void SetConnectionString()
        {

        }
    }
}
