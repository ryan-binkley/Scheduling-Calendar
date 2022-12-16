﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969_Binkley.DatabaseObjects;

namespace C969_Binkley
{
    public class Appointment
    {
        int uniqueID = 1;

        public Appointment()
        {
            uniqueID++;
        }
        public Appointment(Customer inpCustomer, User inpUser, int custID, string apptType, DateTime apptStart, DateTime apptEnd)
        {
            AppointmentId = uniqueID;
            Customer = inpCustomer;
            User = inpUser;
            Type = apptType;
            Start = apptStart;
            End = apptEnd;

            uniqueID++;
        }

        private int appointmentId;
        public int AppointmentId
        {
            get { return appointmentId; }
            set { appointmentId = value; }
        }

        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private DateTime start;
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        private DateTime end;
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        public string AppointmentDay
        {
            get { return start.Date.ToString("d"); }
        }

        public string AppointmentStartTime
        {
            get { return start.TimeOfDay.ToString(); }
        }
        public string AppointmentEndTime
        {
            get { return end.TimeOfDay.ToString(); }
        }

        public string CustomerName
        {
            get { return Customer.CustomerName; }
        }

        public string UserName
        {
            get { return User.UserName; }
        }
    }
}
