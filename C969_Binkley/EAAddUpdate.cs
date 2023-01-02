using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.DatabaseObjects;
using C969_Binkley.StaticClasses;

namespace C969_Binkley
{
    public partial class EAAddUpdate : Form
    {
        public static string addOrMod = "";
        public EAAddUpdate()
        {
            InitializeComponent();
            this.customerDopdown.DataSource = CustomerList.listOfCustomers;
            UserList.listOfUsers = UserList.GetAllUsers();
            this.userDropdown.DataSource = UserList.listOfUsers;
        }

        private void saveButtonEAF_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            DateTime newDate = datetimepickerDay.Value.Date + datetimepickerTime.Value.TimeOfDay;
            


            if (addOrMod == "add")
            {

            }

            if (addOrMod == "mod")
            {
                int indexOfApptToBeChanged = AppointmentList.appointments.IndexOf((Appointment)Calender.custForm.custDGV.CurrentRow.DataBoundItem);

                AppointmentList.appointments[indexOfApptToBeChanged].Type = typeTextbox.Text;
                AppointmentList.appointments[indexOfApptToBeChanged].Customer = (Customer)customerDopdown.SelectedItem;
                AppointmentList.appointments[indexOfApptToBeChanged].Start = newDate;
                AppointmentList.appointments[indexOfApptToBeChanged].User = (User)userDropdown.SelectedItem;

            }

            ClearTextboxes();
            this.CustomerDropdown.ResetText();
            this.CustomerDropdown.SelectedIndex = -1;
            this.UserDropdown.ResetText();
            this.UserDropdown.SelectedIndex = -1;
            this.Visible = false;
            Calender.custForm.Visible = true;
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
