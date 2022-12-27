using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Customer
    {
        public int uniqueID = 1000;
        public Customer()
        {
            uniqueID++;
            customerId = uniqueID;
        }
        public Customer(int custID, string custName)
        {
            CustomerId = custID;
            CustomerName = custName;
            uniqueID++;
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
