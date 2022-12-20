using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Binkley
{
    public static class CurrentDate
    {
        // Make global static variables representing what month it currently is
        public static DateTime currentMonthDateTime = new DateTime(2022, 1, 1);
        public static BindingList<Appointment> appointmentsByMonth = new BindingList<Appointment>();

        // Make global static variables representing what week it currently is
        public static DateTime currentWeekStartDateTime = new DateTime(2022, 1, 1);
        public static DateTime currentWeekEndDateTime = new DateTime(2022, 1, 7);
        public static BindingList<Appointment> appointmentsByWeek = new BindingList<Appointment>();

        // Methods to modify the list should be put under here.

        // Void -> BindingList<Appointment>
        // This function should get all the appointments of the current month and put them in the appointmentsByMonth BindingList
        public static void GetAppointmentsByMonth()
        {
            // This lambda expression checks for equivalency between each appointment's month in the appointments BindingList and the current month set in this class. The ToList method also makes this extremely useful and simple to create a new BindingList and set the value of that BindingList to the Lambda's output list.
            appointmentsByMonth = new BindingList<Appointment>(AppointmentList.appointments.Where(appointment => (appointment.AppointmentMonth == currentMonthDateTime.Month) && (appointment.AppointmentYear == currentMonthDateTime.Year)).ToList());
        }

        // DataGridView -> Void
        // This function sets the input DataGridView to the appointmentsByMonth BindingList
        public static void SetAppointmentsByMonth(DataGridView inpDataGrid)
        {
            inpDataGrid.DataSource = appointmentsByMonth;
        }

        // Void -> BindingList<Appointment>
        // This function should get all the appointments of the current week and put them in the appointmentsByWeek BindingList
        public static void GetAppointmentsByWeek()
        {
            // This lambda expression checks for equivalency between each appointment's start/end in the appointments BindingList and the current week start/end set in this class. The ToList method also makes this extremely useful and simple to create a new BindingList and set the value of that BindingList to the Lambda's output list.
            appointmentsByWeek = new BindingList<Appointment>(AppointmentList.appointments.Where(appointment => (appointment.Start.ToLocalTime().Date >= currentWeekStartDateTime) && (appointment.End.ToLocalTime().Date <= currentWeekEndDateTime)).ToList());
        }

        // DataGridView -> Void
        // This function sets the input DataGridView to the appointmentsByWeek BindingList
        public static void SetAppointmentsByWeek(DataGridView inpDataGrid)
        {
            inpDataGrid.DataSource = appointmentsByWeek;
        }

        // Int -> Void
        // This function takes the current DateTime and adds a integer to it(subtracts if negative number is input) to change the month
        public static void AddToMonth(int inpInt)
        {
            currentMonthDateTime = currentMonthDateTime.AddMonths(inpInt);
        }

        // Int -> Void
        // This function takes the current DateTime and adds a integer to it(subtracts if negative number is input) to change the week
        public static void AddToWeek(int inpInt)
        {
            currentWeekStartDateTime = currentWeekStartDateTime.AddDays(inpInt);
            currentWeekEndDateTime = currentWeekEndDateTime.AddDays(inpInt);
        }
    }
}
