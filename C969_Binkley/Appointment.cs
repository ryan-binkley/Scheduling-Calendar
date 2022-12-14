using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    class Appointment
    {
        public Appointment(int apptID, int custID, int userID, string apptType, DateTime apptStart, DateTime apptEnd)
        {
            AppointmentId = apptID;
            CustomerId = custID;
            UserId = userID;
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

        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
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
    }
}
