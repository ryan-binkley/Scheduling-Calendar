using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Address
    {
        Random rng = new Random();
        public Address()
        {
            addressId = rng.Next(1, 1000000);
        }

        public Address(string inpString)
        {
            
        }
        public Address(int addID, string addName, City inpCity, string inpPhone)
        {
            AddressId = addID;
            AddressName = addName;
            City = inpCity;
            Phone = inpPhone;
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
