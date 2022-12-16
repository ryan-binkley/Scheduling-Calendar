using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_Binkley
{
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
			StartTimer();
			AppointmentList.appointments = AppointmentList.GetAllAppointments();
			apptDGV.AutoGenerateColumns = false;
			apptDGV.DataSource = AppointmentList.appointments;
		}

		public DataGridView apptDGV
		{
			get { return this.appointmentCalendarDataGridView; }
			set { this.appointmentCalendarDataGridView = value; }
		}


		// Void -> Void
		// This function sets up a timer and adds a one second update interval and the timer_Tick event handler to it
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
		// This function allows other classes to access and work with the Calendar DataGridView
		public DataGridView GetCurrentDataGridView()
        {
			return this.appointmentCalendarDataGridView;
        }

		// Void -> Void
		// This function will make the month label and buttons visible
		public void ShowMonth()
        {
			this.monthLabel.Text = Month.currentMonthDateTime.ToString("MMMM");
			this.monthLabel.Visible = true;
			this.prevMonthButton.Visible = true;
			this.nextMonthButton.Visible = true;
        }

		// Void -> Void
		// This function will make the month label and buttons not visible
		public void DoNotShowMonth()
		{
			this.monthLabel.Visible = false;
			this.prevMonthButton.Visible = false;
			this.nextMonthButton.Visible = false;
		}

		// Event-handlers for radio buttons
		private void allAppointmentsRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
			AppointmentList.appointments = AppointmentList.GetAllAppointments();
			apptDGV.DataSource = AppointmentList.appointments;
			DoNotShowMonth();
        }

        private void monthAppointmentsRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
			Month.GetAppointmentsByMonth();
			Month.SetAppointmentsByMonth(apptDGV);
			ShowMonth();
		}


    }
}
