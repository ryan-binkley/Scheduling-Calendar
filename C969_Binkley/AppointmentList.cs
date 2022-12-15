using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    public static class AppointmentList
    {
        // Make a global 'static' List to be modified by the rest of the program.
        static BindingList<Appointment> appointments = new BindingList<Appointment>();

        // Methods to modify the list should be put under here.
        
        // Appointment -> Void
        // This function adds the input appointment to the appointments bindinglist
        public static void AddAppointment(Appointment inpAppt)
        {
            appointments.Add(inpAppt);
        }

        // Appointment -> Void
        // This function deletes the appointment from the appointments bindinglist
        public static void DeleteAppointment(Appointment inpAppt)
        {
            appointments.Remove(inpAppt);
        }
    }
}
