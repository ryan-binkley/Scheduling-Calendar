using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using C969_Binkley.Database;
using C969_Binkley.StaticClasses;
using MySql.Data.MySqlClient;

namespace C969_Binkley
{
    public partial class Calender : Form
    {
		// Creating the new forms to be able to travel to/from
		public static EditCustomersForm custForm = new EditCustomersForm();
		public static EAAddUpdate editApptsForm = new EAAddUpdate();
		public static Reports reportForm = new Reports();

		// Properties for the class itself
		public static int selectedApptIndex = 0;
		public Calender()
        {
            InitializeComponent();
			StartTimer();

			// Items to be initialized upon starting the form
			AppointmentList.appointments = AppointmentList.GetAllAppointments();
			apptDGV.AutoGenerateColumns = false;
			apptDGV.DataSource = AppointmentList.appointments;
		}

		// This is a simple accessor for the DataGridView
		public DataGridView apptDGV
		{
			get { return this.appointmentCalendarDataGridView; }
			set { this.appointmentCalendarDataGridView = value; }
		}


		// Void -> Void
		// This method sets up a timer and adds a one second update interval and the timer_Tick event handler to it
		private void StartTimer()
		{
			System.Windows.Forms.Timer timer = null;

			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Enabled = true;
		}

		// Event Handler
		// Event handler to handle the timer
		void timer_Tick(object sender, EventArgs e)
		{
			currentTimeTimer.Text = DateTime.Now.ToString();
			UTCTimeTimer.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("UTC")).ToString();
		}

		// Void -> DataGridView
		// This method allows other classes to access and work with the Calendar DataGridView
		public DataGridView GetCurrentDataGridView()
        {
			return this.appointmentCalendarDataGridView;
        }

		// Void -> Void
		// This method will make the month label and buttons visible
		public void ShowMonth()
        {
			this.dateLabel.Text = CurrentDate.currentMonthDateTime.ToString("MMMM");
			this.yearLabel.Text = CurrentDate.currentMonthDateTime.ToString("yyyy");
			this.dateLabel.Visible = true;
			this.yearLabel.Visible = true;
			this.prevDateButton.Visible = true;
			this.nextDateButton.Visible = true;
        }

		// Void -> Void
		// This method will make the month label and buttons not visible
		public void DoNotShowMonth()
		{
			this.dateLabel.Visible = false;
			this.yearLabel.Visible = false;
			this.prevDateButton.Visible = false;
			this.nextDateButton.Visible = false;
		}

		// Void -> Void
		// This method will make the month label and buttons visible
		public void ShowWeek()
		{
			this.dateLabel.Text = CurrentDate.currentWeekStartDateTime.ToString("M") + " - " + CurrentDate.currentWeekEndDateTime.ToString("M");
			this.yearLabel.Text = CurrentDate.currentWeekStartDateTime.ToString("yyyy");
			this.yearLabel.Visible = true;
			this.dateLabel.Visible = true;
			this.prevDateButton.Visible = true;
			this.nextDateButton.Visible = true;
		}

		// Void -> Void
		// This method will make the month label and buttons not visible
		public void DoNotShowWeek()
		{
			this.dateLabel.Visible = false;
			this.yearLabel.Visible = false;
			this.prevDateButton.Visible = false;
			this.nextDateButton.Visible = false;
		}

		// Event-handlers for radio buttons
		private void allAppointmentsRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
			AppointmentList.appointments = AppointmentList.GetAllAppointments();
			apptDGV.DataSource = AppointmentList.appointments;
			DoNotShowMonth();
			DoNotShowWeek();
        }

        private void monthAppointmentsRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
			CurrentDate.GetAppointmentsByMonth();
			CurrentDate.SetAppointmentsByMonth(apptDGV);
			DoNotShowWeek();
			ShowMonth();
		}

        private void weekAppointmentsRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
			CurrentDate.GetAppointmentsByWeek();
			CurrentDate.SetAppointmentsByWeek(apptDGV);
			DoNotShowMonth();
			ShowWeek();
		}

		// Event handlers for prevDate and nextDate Buttons
        private void prevDateButton_Click(object sender, EventArgs e)
        {
			if (monthAppointmentsRadioButton.Checked == true)
            {
				CurrentDate.AddToMonth(-1);
				CurrentDate.GetAppointmentsByMonth();
				CurrentDate.SetAppointmentsByMonth(apptDGV);
				DoNotShowWeek();
				ShowMonth();
            }
			
			if (weekAppointmentsRadioButton.Checked == true)
            {
				CurrentDate.AddToWeek(-7);
				CurrentDate.GetAppointmentsByWeek();
				CurrentDate.SetAppointmentsByWeek(apptDGV);
				DoNotShowMonth();
				ShowWeek();
            }
        }

		// Event handler for the next date button
        private void nextDateButton_Click(object sender, EventArgs e)
        {
			if (monthAppointmentsRadioButton.Checked == true)
			{
				CurrentDate.AddToMonth(1);
				CurrentDate.GetAppointmentsByMonth();
				CurrentDate.SetAppointmentsByMonth(apptDGV);
				ShowMonth();
			}

			if (weekAppointmentsRadioButton.Checked == true)
			{
				CurrentDate.AddToWeek(7);
				CurrentDate.GetAppointmentsByWeek();
				CurrentDate.SetAppointmentsByWeek(apptDGV);
				ShowWeek();
			}
		}

		// Event handler for the customer button click
        private void customerButton_Click(object sender, EventArgs e)
        {
			custForm.Visible = true;
			this.Visible = false;
        }

		// Event handlers for the modification buttons to appointments
        private void calAddButton_Click(object sender, EventArgs e)
        {
			EAAddUpdate.addOrMod = "add";


			editApptsForm.Visible = true;
			this.Visible = false;
        }

        private void calUpdateButton_Click(object sender, EventArgs e)
        {
			EAAddUpdate.addOrMod = "mod";

			Appointment apptSelected = (Appointment)apptDGV.CurrentRow.DataBoundItem;
			selectedApptIndex = AppointmentList.appointments.IndexOf(apptSelected);

			editApptsForm.TypeTextbox.Text = apptSelected.Type;
			editApptsForm.CustomerDropdown.SelectedIndex = editApptsForm.CustomerDropdown.FindStringExact(apptSelected.Customer.CustomerName);
			editApptsForm.DateTimePickerDay.Value = apptSelected.Start.ToLocalTime();
			editApptsForm.DateTimePickerTime.Value = apptSelected.Start.ToLocalTime();
			UserList.listOfUsers = UserList.GetAllUsers();
			editApptsForm.UserDropdown.SelectedIndex = editApptsForm.UserDropdown.FindStringExact(apptSelected.User.UserName);


			editApptsForm.Visible = true;
			this.Visible = false;
		}

        private void calDeleteButton_Click(object sender, EventArgs e)
        {
			Appointment apptSelected = (Appointment)apptDGV.CurrentRow.DataBoundItem;

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

				// Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
				string cmd = String.Format("DELETE FROM appointment WHERE appointmentId={0};", apptSelected.AppointmentId.ToString());

				MySqlCommand mySqlCmd = new MySqlCommand(cmd, sqlConnection);

				mySqlCmd.ExecuteNonQuery();
			}

			// If an error occurs, show a messagebox informing the user of the error and return null
			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "Appointment Delete Error");

				return;
			}

			AppointmentList.DeleteAppointment(apptSelected);
		}

		// Event handler for when the form changes visibility
        private void Calender_VisibleChanged(object sender, EventArgs e)
        {
			AppointmentList.appointments = AppointmentList.GetAllAppointments();
			apptDGV.DataSource = AppointmentList.appointments;
		}

		// Event handler for going to the reports form to generate reports
        private void generateReportsButton_Click(object sender, EventArgs e)
        {
			reportForm.Visible = true;
			this.Visible = false;
        }
    }
}
