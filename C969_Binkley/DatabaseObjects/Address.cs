using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Address
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public Address()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            addressId = rng.Next(1, 1000000);
        }

        public Address(string inpString)
        {
            
        }
        private int addressId;
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }

        private string address;
        public string AddressName
        {
            get { return address; }
            set { address = value; }
        }

        private City city;
        public City City
        {
            get { return city; }
            set { city = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
