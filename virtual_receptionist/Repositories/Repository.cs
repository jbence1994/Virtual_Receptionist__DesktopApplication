using virtual_receptionist.MySQLConnection;

namespace virtual_receptionist.Repositories
{
    public class Repository
    {
        protected Database Database;

        public Repository()
        {
            Database = Database.GetDatabaseInstance();
        }
    }
}
