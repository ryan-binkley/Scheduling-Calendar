using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Country
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public Country()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            countryId = rng.Next(1, 1000000);
        }
        public Country(string inpString)
        {

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
