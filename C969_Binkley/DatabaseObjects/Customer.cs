using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Customer
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public Customer()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            customerId = rng.Next(1, 1000000);
        }

        public Customer(string inpString)
        {

        }

        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        private Address address;
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string AddressString
        {
            get { return Address.AddressName; }
            set { Address.AddressName = value; }
        }

        public string Phone
        {
            get { return Address.Phone; }
            set { Address.Phone = value; }
        }

        public string CityName
        {
            get { return Address.City.CityName; }
            set { Address.City.CityName = value; }
        }

        public string CountryName
        {
            get { return Address.City.Country.CountryName; }
            set { Address.City.Country.CountryName = value; }
        }
    }
}
