using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace virtual_receptionist.MySQLConnection
{
    public sealed class Database
    {
        private static readonly Database DatabaseInstance = new Database();
        private MySqlConnection mySqlConnection;
        private MySqlCommand mySqlCommand;
        private MySqlDataAdapter mySqlDataAdapter;

        private Database()
        {
        }

        public static Database GetDatabaseInstance()
        {
            return DatabaseInstance;
        }

        public void SetConnection()
        {
            mySqlConnection = new MySqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString
            };
        }

        private void OpenConnection()
        {
            if (mySqlConnection.State != ConnectionState.Closed)
                return;

            mySqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (mySqlConnection.State != ConnectionState.Open)
                return;

            mySqlConnection.Close();
        }

        public DataTable Dql(string query)
        {
            OpenConnection();

            var dataTable = new DataTable();

            mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlDataAdapter = new MySqlDataAdapter
            {
                SelectCommand = mySqlCommand
            };

            mySqlDataAdapter.Fill(dataTable);

            CloseConnection();

            return dataTable;
        }

        public void Dml(string query)
        {
            OpenConnection();

            mySqlCommand = new MySqlCommand
            {
                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlCommand.Prepare();
            mySqlCommand.ExecuteNonQuery();

            CloseConnection();
        }

        public string ScalarDql(string query)
        {
            OpenConnection();

            mySqlCommand = new MySqlCommand()
            {

                CommandText = query,
                Connection = mySqlConnection
            };

            mySqlCommand.Prepare();

            var scalarQuery = mySqlCommand.ExecuteScalar().ToString();

            CloseConnection();

            return scalarQuery;
        }
    }
}
