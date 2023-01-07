using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C969_Binkley.DatabaseObjects;

namespace C969_Binkley
{
    public class Appointment
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public Appointment()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            appointmentId = rng.Next(1, 1000000);
        }

        public Appointment(string inpString)
        {

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

        public string AppointmentMonthString
        {
            get { return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(AppointmentMonth); }
        }
    }
}
