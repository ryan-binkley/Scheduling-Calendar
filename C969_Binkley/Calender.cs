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

		// This is a simple accessor for the DataGridView
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
			this.dateLabel.Text = CurrentDate.currentMonthDateTime.ToString("MMMM");
			this.dateLabel.Visible = true;
			this.prevDateButton.Visible = true;
			this.nextDateButton.Visible = true;
        }

		// Void -> Void
		// This function will make the month label and buttons not visible
		public void DoNotShowMonth()
		{
			this.dateLabel.Visible = false;
			this.prevDateButton.Visible = false;
			this.nextDateButton.Visible = false;
		}

		// Void -> Void
		// This function will make the month label and buttons visible
		public void ShowWeek()
		{
			this.dateLabel.Text = CurrentDate.currentWeekStartDateTime.ToString("M") + " - " + CurrentDate.currentWeekEndDateTime.ToString("M");
			this.dateLabel.Visible = true;
			this.prevDateButton.Visible = true;
			this.nextDateButton.Visible = true;
		}

		// Void -> Void
		// This function will make the month label and buttons not visible
		public void DoNotShowWeek()
		{
			this.dateLabel.Visible = false;
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
    }
}
