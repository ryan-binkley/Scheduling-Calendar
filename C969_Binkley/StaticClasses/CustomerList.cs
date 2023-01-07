using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using C969_Binkley.DatabaseObjects;
using MySql.Data.MySqlClient;

namespace C969_Binkley.StaticClasses
{
    public static class CustomerList
    {
        // Make a global 'static' List to be modified by the rest of the program.
        public static BindingList<Customer> listOfCustomers = new BindingList<Customer>();

        // Declare a temp variable to temporarily hold the object that the user selects
        public static Customer customerSelected;

        // Methods to modify the list should be put under here.

        // Customer -> Void
        // This method takes the input customer and adds them to the listOfCustomers BindingList
        public static void AddCustomer(Customer inpCustomer)
        {
            listOfCustomers.Add(inpCustomer);
        }

        // Customer -> Void
        // This method takes the input customer and deletes them from the listOfCustomers BindingList
        public static void DeleteCustomer(Customer inpCustomer)
        {
            listOfCustomers.Remove(inpCustomer);
        }

		// Void -> BindingList<Customer>
		// This method simply gets all the customers in the database and returns them in a bindinglist
		public static BindingList<Customer> GetAllCustomers()
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
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT * FROM customer JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId", sqlConnection);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create the list that will be returned
				BindingList<Customer> listToReturn = new BindingList<Customer>();

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
				{
					Customer customerToBeAddedToList = new Customer();

					customerToBeAddedToList.CustomerId = sqlReader.GetInt16("customerId");
					customerToBeAddedToList.CustomerName = sqlReader.GetString("customerName");

					customerToBeAddedToList.Address = new Address();
					customerToBeAddedToList.Address.AddressId = sqlReader.GetInt16("addressId");
					customerToBeAddedToList.AddressString = sqlReader.GetString("address");
					customerToBeAddedToList.Phone = sqlReader.GetString("phone");

					customerToBeAddedToList.Address.City = new City();
					customerToBeAddedToList.Address.City.CityId = sqlReader.GetInt16("cityId");
					customerToBeAddedToList.CityName = sqlReader.GetString("city");

					customerToBeAddedToList.Address.City.Country = new Country();
					customerToBeAddedToList.Address.City.Country.CountryId = sqlReader.GetInt16("countryId");
					customerToBeAddedToList.CountryName = sqlReader.GetString("country");

					listToReturn.Add(customerToBeAddedToList);
				}
				sqlReader.Close();
				// Return the bindinglist of all customers
				return listToReturn;
			}

			// If an error occurs, show a messagebox informing the user of the error and return null
			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "CustomerList Error");

				return null;
			}
		}
	}
}
