using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models;
using virtual_receptionist.MySQLConnection;

namespace virtual_receptionist.Repositories
{
    public class CountryRepository
    {
        private readonly Database database = Database.GetDatabaseInstance();
        private readonly List<Country> countries = new List<Country>();

        private void UploadCountriesList()
        {
            const string sql = "SELECT * FROM country";
            var dt = database.Dql(sql);

            foreach (DataRow row in dt.Rows)
            {
                var name = row["CountryName"].ToString();

                countries.Add(new Country {Name = name});
            }
        }

        public List<Country> GetCountries()
        {
            if (countries.Count == 0)
                UploadCountriesList();

            return countries;
        }
    }
}
