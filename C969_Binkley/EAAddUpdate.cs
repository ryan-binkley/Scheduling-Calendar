using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using C969_Binkley.DatabaseObjects;
using C969_Binkley.StaticClasses;
using MySql.Data.MySqlClient;
using C969_Binkley;

namespace C969_Binkley
{
    public partial class EAAddUpdate : Form
    {
        // Static property for this class
        public static string addOrMod = "";
        public EAAddUpdate()
        {
            InitializeComponent();

            // Items to be modified upon initialization of this form
            this.customerDopdown.DataSource = CustomerList.listOfCustomers;
            UserList.listOfUsers = UserList.GetAllUsers();
            this.userDropdown.DataSource = UserList.listOfUsers;

            this.CustomerDropdown.ResetText();
            this.CustomerDropdown.SelectedIndex = -1;
            this.UserDropdown.ResetText();
            this.UserDropdown.SelectedIndex = -1;
        }

        // Event handlers for clicking the save/cancel buttons
        private void saveButtonEAF_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            DateTime newDate = (datetimepickerDay.Value.Date + datetimepickerTime.Value.TimeOfDay).AddSeconds(-datetimepickerTime.Value.Second);

            if (newDate.ToUniversalTime().Hour < 9 || newDate.ToUniversalTime().Hour > 17)
            {
                MessageBox.Show("The operating business hours are 09:00 A.M. UTC to 05:00 P.M. UTC. Please adjust appointment time to be within these hours. Local and UTC times are located on the main form in the top left.", "Appointment Time Error", MessageBoxButtons.OK);

                return;
            }



            if (addOrMod == "add")
            {
                Appointment apptToAdd = new Appointment();

                apptToAdd.Start = newDate.ToUniversalTime();
                apptToAdd.End = newDate.ToUniversalTime().AddMinutes(30);

                User tempUser = new User("NA");
                tempUser = (User)UserDropdown.SelectedItem;

                if (!CheckAvailability(apptToAdd, tempUser.UserId))
                {
                    return;
                }

                apptToAdd.Type = typeTextbox.Text;
                apptToAdd.Customer = (Customer)CustomerDropdown.SelectedItem;
                apptToAdd.User = (User)UserDropdown.SelectedItem;
                AppointmentList.AddAppointment(apptToAdd);

                // Create a local reference to the Sql Connection in the DBConnection class
                MySqlConnection sqlConnection = DBConnection.sqlConnection;

                try
                {
                    // If the connection is not open, inform user and return null to get out of the function call
                    if (!(sqlConnection.State == ConnectionState.Open))
                    {
                        MessageBox.Show("Connection to Database is closed.", "Connection Error");

                        return;
                    }

                    string cmd = String.Format("INSERT INTO appointment (appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({0}, {1}, {2}, \'not needed\', \'not needed\', \'not needed\', \'not needed\', \'{3}\', \'not needed\', \'{4}\', \'{5}\', NOW(), \'test\', NOW(), \'test\');", apptToAdd.AppointmentId.ToString(), apptToAdd.Customer.CustomerId.ToString(), apptToAdd.User.UserId.ToString(), apptToAdd.Type, apptToAdd.Start.AddSeconds(-apptToAdd.Start.Second).ToString("yyyy-MM-dd H:mm:ss"), apptToAdd.End.AddSeconds(-apptToAdd.End.Second).ToString("yyyy-MM-dd H:mm:ss"));

                    // Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
                    MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();
                }

                // If an error occurs, show a messagebox informing the user of the error and return null
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.Message, "Appointment Add Error");

                    return;
                }

            }

            if (addOrMod == "mod")
            {
                int indexOfApptToBeChanged = Calender.selectedApptIndex;
                User tempUser = new User("NA");
                tempUser = (User)UserDropdown.SelectedItem;

                if(!CheckAvailability(AppointmentList.appointments[indexOfApptToBeChanged], tempUser.UserId))
                {
                    return;
                }

                AppointmentList.appointments[indexOfApptToBeChanged].Type = typeTextbox.Text;
                AppointmentList.appointments[indexOfApptToBeChanged].Customer = (Customer)customerDopdown.SelectedItem;
                AppointmentList.appointments[indexOfApptToBeChanged].Start = newDate.ToUniversalTime();
                AppointmentList.appointments[indexOfApptToBeChanged].End = newDate.ToUniversalTime().AddMinutes(30);
                AppointmentList.appointments[indexOfApptToBeChanged].User = (User)userDropdown.SelectedItem;

                // Create a local reference to the Sql Connection in the DBConnection class
                MySqlConnection sqlConnection = DBConnection.sqlConnection;

                try
                {
                    // If the connection is not open, inform user and return null to get out of the function call
                    if (!(sqlConnection.State == ConnectionState.Open))
                    {
                        MessageBox.Show("Connection to Database is closed.", "Connection Error");

                        return;
                    }

                    string cmd = String.Format("BEGIN; " +
                        "UPDATE appointment SET type = \'{0}\' WHERE appointmentId = {1};" +
                        "UPDATE appointment SET customerId = {2} WHERE appointmentId = {1};" +
                        "UPDATE appointment SET userId = {3} WHERE appointmentId = {1};" +
                        "UPDATE appointment SET start = \'{4}\' WHERE appointmentId = {1};" +
                        "UPDATE appointment SET end = \'{5}\' WHERE appointmentId = {1};" +
                        "COMMIT;", AppointmentList.appointments[indexOfApptToBeChanged].Type, AppointmentList.appointments[indexOfApptToBeChanged].AppointmentId.ToString(), AppointmentList.appointments[indexOfApptToBeChanged].Customer.CustomerId.ToString(), AppointmentList.appointments[indexOfApptToBeChanged].User.UserId.ToString(), AppointmentList.appointments[indexOfApptToBeChanged].Start.ToString("yyyy-MM-dd H:mm:ss"), AppointmentList.appointments[indexOfApptToBeChanged].End.ToString("yyyy-MM-dd H:mm:ss"));

                    // Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
                    MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

                    mySqlCmd.ExecuteNonQuery();
                }

                // If an error occurs, show a messagebox informing the user of the error and return null
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.Message, "Appointment Update Error");

                    return;
                }
            }

            ClearTextboxes();
            this.CustomerDropdown.ResetText();
            this.CustomerDropdown.SelectedIndex = -1;
            this.UserDropdown.ResetText();
            this.UserDropdown.SelectedIndex = -1;
            this.Visible = false;
            LoginForm.calendar_month.Visible = true;
        }

        private void cancelButtonEAF_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            this.CustomerDropdown.ResetText();
            this.CustomerDropdown.SelectedIndex = -1;
            this.UserDropdown.ResetText();
            this.UserDropdown.SelectedIndex = -1;

            this.Visible = false;
            LoginForm.calendar_month.Visible = true;
        }

        // Public getters/setters for main form attributes
        public TextBox TypeTextbox
        {
            get
            {
                return this.typeTextbox;
            }
            set
            {
                this.typeTextbox = value;
            }
        }
        public ComboBox CustomerDropdown
        {
            get
            {
                return this.customerDopdown;
            }
            set
            {
                this.customerDopdown = value;
            }
        }
        public DateTimePicker DateTimePickerDay
        {
            get
            {
                return this.datetimepickerDay;
            }
            set
            {
                this.datetimepickerDay = value;
            }
        }
        public DateTimePicker DateTimePickerTime
        {
            get
            {
                return this.datetimepickerTime;
            }
            set
            {
                this.datetimepickerTime = value;
            }
        }
        public ComboBox UserDropdown
        {
            get
            {
                return this.userDropdown;
            }
            set
            {
                this.userDropdown = value;
            }
        }

        // Void -> Void
        // This method clears the forms textboxes
        public void ClearTextboxes()
        {
            foreach (Control txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    txtBox.Text = "";
                }
            }
        }

        // void -> Boolean
        // This function ensures that no textboxes are left empty and/or combobox options unselected
        public bool ValidateInput()
        {
            foreach (Control txtBox in this.Controls)
            {
                if ((txtBox is TextBox) && (txtBox.Text == ""))
                {
                    MessageBox.Show("There cannot be any empty inputs!", "Customer Edit Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (this.CustomerDropdown.SelectedIndex == -1 || this.UserDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("There cannot be any empty inputs!", "Customer Edit Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        // Appointment Int -> Boolean
        // This function takes in the appointment being modified/added and checks if the appointment times conflict with any others where the user is the same
        public bool CheckAvailability(Appointment inpAppt, int inpUserId)
        {
            List<Appointment> tempList = new List<Appointment>();

            for(int i = 0; i < AppointmentList.appointments.Count; i++)
            {
                if (AppointmentList.appointments[i].User.UserId == inpUserId)
                {
                    tempList.Add(AppointmentList.appointments[i]);
                }
            }

            foreach (Appointment appt in tempList)
            {
                if((appt.Start < inpAppt.End) && (inpAppt.Start < appt.End))
                {
                    MessageBox.Show("The consultant cannot be in two appointments at the same time.", "Appointment Conflict Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }

        // Event handler for when this form's visibility changes
        private void EAAddUpdate_VisibleChanged(object sender, EventArgs e)
        {
            if (addOrMod == "add")
            {
                EAFLabel.Text = "Add";
            }

            if (addOrMod == "mod")
            {
                EAFLabel.Text = "Update";
            }
        }
    }
}
