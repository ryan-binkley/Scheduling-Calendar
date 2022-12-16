using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using MySql.Data.MySqlClient;
using C969_Binkley.DatabaseObjects;

namespace C969_Binkley
{
    public static class AppointmentList
    {
        // Make a global 'static' List to be modified by the rest of the program.
        public static BindingList<Appointment> appointments = new BindingList<Appointment>();

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

        // Void -> BindingList<Appointment>
        // This functions simply gets all the appointments in the database and returns them in a bindinglist
        public static BindingList<Appointment> GetAllAppointments()
        {
			// Create a local reference to the Sql Connection in the DBConnection class
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			try
			{
				// If the connection is not open, inform user and return null to get out of the function call
				if (!(sqlConnection.State == ConnectionState.Open))
				{
					MessageBox.Show("Connection to Database is closed.", "Connection Error");
					
					return null;
				}

				// Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT * FROM appointment JOIN user ON appointment.userId = user.userId JOIN customer ON appointment.customerId = customer.customerId JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId", sqlConnection);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create the list that will be returned
				BindingList<Appointment> listToReturn = new BindingList<Appointment>();

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
				{
					Appointment apptToBeAddedToList = new Appointment();

					apptToBeAddedToList.AppointmentId = sqlReader.GetInt32("appointmentId");
					apptToBeAddedToList.Customer = new Customer();
					apptToBeAddedToList.Customer.CustomerId = sqlReader.GetInt32("customerId");
					apptToBeAddedToList.Customer.CustomerName = sqlReader.GetString("customerName");
					apptToBeAddedToList.User = new User();
					apptToBeAddedToList.User.UserId = sqlReader.GetInt32("userId");
					apptToBeAddedToList.User.UserName = sqlReader.GetString("userName");
					apptToBeAddedToList.Type = sqlReader.GetString("type");
					apptToBeAddedToList.Start = sqlReader.GetDateTime("start");
					apptToBeAddedToList.End = sqlReader.GetDateTime("end");
					apptToBeAddedToList.Customer.Address = new Address();
					apptToBeAddedToList.Customer.Address.AddressName = sqlReader.GetString("address");
					apptToBeAddedToList.Customer.Address.City = new City();
					apptToBeAddedToList.Customer.Address.City.CityName = sqlReader.GetString("city");
					apptToBeAddedToList.Customer.Address.City.Country = new Country();
					apptToBeAddedToList.Customer.Address.City.Country.CountryName = sqlReader.GetString("country");

					listToReturn.Add(apptToBeAddedToList);
				}
				sqlReader.Close();
				// Return the bindinglist of all appointments
				return listToReturn;
			}

			// If an error occurs, show a messagebox informing the user of the error and return null
			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "User Exists Error");
				
				return null;
			}
		}
    }
}
