using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969_Binkley.Database;
using MySql.Data.MySqlClient;

namespace C969_Binkley.StaticClasses
{
    public static class UserList
    {
        // Make a global 'static' List to be modified by the rest of the program.
        public static BindingList<User> listOfUsers = new BindingList<User>();

		// Void -> BindingList<User>
		// This method grabs all users in the database and returns them in a BindingList<User> for the static BindingList property of this class
		public static BindingList<User> GetAllUsers()
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
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT * FROM user;", sqlConnection);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create the list that will be returned
				BindingList<User> listToReturn = new BindingList<User>();

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
				{
					User userToBeAddedToList = new User();

					userToBeAddedToList.UserId = sqlReader.GetInt16("userId");
					userToBeAddedToList.UserName = sqlReader.GetString("userName");

					listToReturn.Add(userToBeAddedToList);
				}

				sqlReader.Close();
				// Return the bindinglist of all users
				return listToReturn;
			}

			// If an error occurs, show a messagebox informing the user of the error and return null
			catch (MySqlException exception)
			{
				MessageBox.Show(exception.Message, "UserList Error");

				return null;
			}
		}
	}
}
