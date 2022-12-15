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
			this.appointmentCalendarDataGridView.AutoGenerateColumns = false;
			this.appointmentCalendarDataGridView.DataSource = AppointmentList.appointments;
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
	}
}
