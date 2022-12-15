﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley.DatabaseObjects
{
    public class Customer
    {
        public Customer(int custID, string custName)
        {
            CustomerId = custID;
            CustomerName = custName;
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
    }
}
