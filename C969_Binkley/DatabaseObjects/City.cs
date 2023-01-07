using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class City
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public City()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            cityId = rng.Next(1, 1000000);
        }
        public City(string inpString)
        {

        }

        private int cityId;
        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }

        private string city;
        public string CityName
        {
            get { return city; }
            set { city = value; }
        }

        private Country country;
        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
