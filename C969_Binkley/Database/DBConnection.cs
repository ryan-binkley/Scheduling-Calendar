using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace C969_Binkley.Database
{
    public class DBConnection
    {
		public static MySqlConnection sqlConnection { get; set; }
		public static string getAllRelevantInformation = "SELECT * FROM appointment JOIN user ON appointment.userId = user.userId JOIN customer ON appointment.customerId = customer.customerId JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId";

		public static void startConnection()
        {
			// Get the connection string for Sql DB from App.config
			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			// Wrap the connection in a exception handling block
			try
			{
				// Set the MySqlConnection variable sqlConnection to a new MySqlConnection with the constr as input for the local db
				sqlConnection = new MySqlConnection(constr);

				// Open the db connection to be worked on
				sqlConnection.Open();
			}

			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
			}
		}

		public static void closeConnection()
        {
			try
			{
				// Close MySql connection
				if (sqlConnection != null)
				{
					sqlConnection.Close();
				}

				sqlConnection = null;
			}

			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
			}
		}
    }
}
