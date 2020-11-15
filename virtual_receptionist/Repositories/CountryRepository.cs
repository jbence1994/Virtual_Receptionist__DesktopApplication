﻿using System.Collections.Generic;
using System.Data;
using virtual_receptionist.Models;

namespace virtual_receptionist.Repositories
{
    public class CountryRepository : Repository
    {
        private readonly List<Country> countries = new List<Country>();

        private List<Country> UploadCountriesList()
        {
            const string sql = "SELECT * FROM country";
            var dt = database.DQL(sql);

            foreach (DataRow row in dt.Rows)
            {
                var name = row["CountryName"].ToString();

                countries.Add(new Country {Name = name});
            }

            return countries;
        }

        public List<Country> GetCountries()
        {
            if (countries.Count == 0)
                UploadCountriesList();

            return countries;
        }
    }
}
