using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using C969_Binkley.StaticClasses;
using MySql.Data.MySqlClient;

namespace C969_Binkley
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // Event handlers for the buttons on the report screen
        private void tbmButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for how many types were scheduled in each month:\r\n\r\n";
            tbmReport();
        }

        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for each consultant's schedule:\r\n\r\n";
            ConsultantScheduleReport();
        }

        private void userScheduleButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "Report for each customer's schedule:\r\n\r\n";
            CustomerScheduleReport();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm.calendar_month.Visible = true;
            this.Visible = false;
        }

        // Assistant methods for generating the reports


        // Void -> Void
        // This method compares the types of appointments in the database against the months they can be found in and generates a report in the textbox with the total number of each type/month combo.
        private void tbmReport()
        {
            List<string> typesInAppts = new List<string>();

            for (int i = 0; i < AppointmentList.appointments.Count; i++)
            {
                if (!typesInAppts.Contains(AppointmentList.appointments[i].Type))
                {
                    typesInAppts.Add(AppointmentList.appointments[i].Type);
                }
            }

            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            foreach (string month in Months)
            {
                mainTextbox.Text = mainTextbox.Text + month + "\r\n";

                foreach (string str in typesInAppts)
                {
                    int counter = 0;

                    foreach(Appointment appt in AppointmentList.appointments)
                    {
                        if ((appt.Type == str) && (appt.AppointmentMonthString == month))
                        {
                            counter++;
                        }
                    }

                    mainTextbox.Text = mainTextbox.Text + String.Format("\t{0, 14} {1,8} \r\n", str, counter);
                }
            }
        }

        // Void -> Void
        // This method takes each consultant and compiles a list of their appointments and who/when they are with and generates a report in the textbox.
        private void ConsultantScheduleReport()
        {
            string[] users = new string[UserList.listOfUsers.Count];

            for(int i = 0; i < users.Length; i++)
            {
                users[i] = UserList.listOfUsers[i].UserName;
            }

            foreach (string str in users)
            {
                mainTextbox.Text = mainTextbox.Text + str + "\r\n\r\n";

                foreach (Appointment appt in AppointmentList.appointments)
                {
                    if (appt.User.UserName == str)
                    {
                        mainTextbox.Text = mainTextbox.Text + String.Format("\tAn appt. with " + appt.CustomerName + " at " + appt.AppointmentStartTime + " " + appt.AppointmentDay + " " + appt.AppointmentMonthString + "\r\n");
                    }
                }
            }
        }

        // Void -> Void
        // This method takes each customer and compiles a list of their appointments and who/when they are with and generates a report in the textbox.
        private void CustomerScheduleReport()
        {
            string[] customers = new string[CustomerList.listOfCustomers.Count];

            for(int i = 0; i < customers.Length; i++)
            {
                customers[i] = CustomerList.listOfCustomers[i].CustomerName;
            }

            foreach (string str in customers)
            {
                mainTextbox.Text = mainTextbox.Text + str + "\r\n\r\n";

                foreach (Appointment appt in AppointmentList.appointments)
                {
                    if (appt.Customer.CustomerName == str)
                    {
                        mainTextbox.Text = mainTextbox.Text + String.Format("\tAn appt. with " + appt.UserName + " at " + appt.AppointmentStartTime + " " + appt.AppointmentDay + " " + appt.AppointmentMonthString + "\r\n");
                    }
                }
            }
        }
    }
}
