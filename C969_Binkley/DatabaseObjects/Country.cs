using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Country
    {
        public static int uniqueID = 1000;
        public Country()
        {
            uniqueID++;
            countryId = uniqueID;
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
