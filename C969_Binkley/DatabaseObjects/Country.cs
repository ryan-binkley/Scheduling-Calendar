using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Country
    {
        Random rng = new Random();
        public Country()
        {
            countryId = rng.Next(1, 1000000);
        }
        public Country(string inpString)
        {

        }
        public Country(int countryID, string countryName)
        {
            CountryId = countryID;
            CountryName = countryName;
        }

        private int countryId;
        public int CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }

        private string country;
        public string CountryName
        {
            get { return country; }
            set { country = value; }
        }
    }
}
