using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969_Binkley.DatabaseObjects;

namespace C969_Binkley
{
    public class Appointment
    {
        Random rng = new Random();
        public Appointment()
        {
            
            appointmentId = rng.Next(1, 1000000);
        }

        public Appointment(string inpString)
        {

        }
        public Appointment(Customer inpCustomer, User inpUser, string apptType, DateTime apptStart, DateTime apptEnd)
        {
            Customer = inpCustomer;
            User = inpUser;
            Type = apptType;
            Start = apptStart;
            End = apptEnd;
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
            get { return start.ToLocalTime().Date.ToString("d"); }
        }

        public string AppointmentStartTime
        {
            get { return start.ToLocalTime().TimeOfDay.ToString(); }
        }
        public string AppointmentEndTime
        {
            get { return end.ToLocalTime().TimeOfDay.ToString(); }
        }

        public string CustomerName
        {
            get { return Customer.CustomerName; }
        }

        public string UserName
        {
            get { return User.UserName; }
        }

        public int AppointmentMonth
        {
            get { return start.ToLocalTime().Month; }
        }

        public int AppointmentYear
        {
            get { return start.ToLocalTime().Year; }
        }
    }
}
