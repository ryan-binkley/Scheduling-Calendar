using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using C969_Binkley.Database;

namespace C969_Binkley
{
	public partial class LoginForm : Form
	{
		Calender_Month calendar_month = new Calender_Month();
		static string user;

		public LoginForm()
		{
			InitializeComponent();
		}

		// Event handler for submit button on LoginForm
        private void submitCredentialsButton_Click(object sender, EventArgs e)
        {
			if (!UserExists())
            {
				loginErrorLabel.Visible = true;
				loginErrorLabel.Text = "User does not exist.";
				return;
            }

			// If the user exists, set the user to the text in the username textbox
			user = usernameTextbox.Text;

			// If the password textbox contains the correct password, continue onto the calendar form
			if (passwordTextbox.Text == GrabPasswordFromDatabase())
            {
				calendar_month.Visible = true;
				this.Visible = false;
            }
			else
            {
				loginErrorLabel.Visible = true;
				loginErrorLabel.Text = "Username and Password do not match.";
            }
		}

		// Void -> Boolean
		// This function returns true if the user in the textbox 'exists' in the database, returns false if it doesn't
		public bool UserExists()
        {
			// Create a local reference to the Sql Connection in the DBConnection class
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			try
            {
				// If the connection is not open, inform user and return false to get out of the function call
				if (!(sqlConnection.State == ConnectionState.Open))
				{
					MessageBox.Show("Connection to Database is closed.", "Connection Error");
					return false;
				}
				
				// Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT userName FROM user", sqlConnection);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create string variable to hold each of the results of the sql command
				string username;

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
                {
					// Set username string to every value of the userName column of the user table
					username = sqlReader.GetString("userName");

					// If the user exists, close the SqlDataReader and return true
					if (username.ToUpper() == usernameTextbox.Text.ToUpper())
					{
						sqlReader.Close();
						return true;
					}
				}
				sqlReader.Close();

				// If the code passes all usernames and does not find it, return false
				return false;
			}

			// If an error occurs, show a messagebox informing the user of the error and return false
			catch (MySqlException exception)
            {
				MessageBox.Show(exception.Message, "User Exists Error");
				return false;
            }
		}

		// Void -> String
		// This function grabs the password of the user from the username textbox if it exists
		public string GrabPasswordFromDatabase()
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
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT password FROM user WHERE userName=@username", sqlConnection);

				// User MySql parameter to specify 'WHERE' clause using user for the username
				mySqlCmd.Parameters.AddWithValue("@username", user);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create string variable to hold each of the results of the sql command
				string password;

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
				{
					// Get the one entry that is the password corresponding to the username
					password = sqlReader.GetString("password");

					// Close sqlReader so repeated attempts do not cause an exception
					sqlReader.Close();

					// Return the password string
					return password;
				}
				sqlReader.Close();

				// If the code does not find a password, return null
				return null;
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
