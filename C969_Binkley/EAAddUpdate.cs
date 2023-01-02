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

namespace C969_Binkley
{
    public partial class EAAddUpdate : Form
    {
        public static string addOrMod = "";
        public EAAddUpdate()
        {
            InitializeComponent();
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
                EAFLabel.Text = "Add";


            }

            if (addOrMod == "mod")
            {
                EAFLabel.Text = "Update";

                int indexOfApptToBeChanged = AppointmentList.appointments.IndexOf((Appointment)Calender.custForm.custDGV.CurrentRow.DataBoundItem);

                AppointmentList.appointments[indexOfApptToBeChanged].Type = typeTextbox.Text;
                AppointmentList.appointments[indexOfApptToBeChanged].Customer = (Customer)customerDopdown.SelectedItem;
                AppointmentList.appointments[indexOfApptToBeChanged].Start = newDate;
                AppointmentList.appointments[indexOfApptToBeChanged].User = (User)userDropdown.SelectedItem;

            }

            ClearTextboxes();
            this.Visible = false;
            Calender.custForm.Visible = true;
        }

        private void cancelButtonEAF_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
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
        // This function ensures that no textboxes are left empty
        public bool ValidateInput()
        {
            foreach (Control txtBox in this.Controls)
            {
                if ((txtBox is TextBox) && (txtBox.Text == ""))
                {
                    MessageBox.Show("There cannot be any empt inputs!", "Customer Edit Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }
    }
}
