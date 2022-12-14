using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using C969_Binkley.Database;
using System.IO;
using System.Globalization;
using System.Threading;
using C969_Binkley.StaticClasses;

namespace C969_Binkley
{
	public partial class LoginForm : Form
	{
		// Static properties for this class
		public static Calender calendar_month = new Calender();
		static string user;
		public static User currentUser;
		
		public LoginForm()
		{
			// These control flow statements check what region the user is in(Anywhere with the culture code of 'es') and changes the culture to the local culture.
			if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es");
			else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
				Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");

			InitializeComponent();
			StartTimer();
		}

		// Event handler for submit button on LoginForm
        private void submitCredentialsButton_Click(object sender, EventArgs e)
        {
			
			if (!UserExists())
            {
				LogAuthentication(usernameTextbox.Text, passwordTextbox.Text, false);
				loginErrorLabel.Visible = true;
				if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
                {
					loginErrorLabel.Text = "User does not exist.";
				}
				else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				{
					loginErrorLabel.Text = "El usuario no existe.";
				}
				
				return;
            }

			// If the user exists, set the user to the text in the username textbox
			user = usernameTextbox.Text;

			// If the password textbox contains the correct password, continue onto the calendar form
			if (passwordTextbox.Text == GrabPasswordFromDatabase())
            {
				LogAuthentication(usernameTextbox.Text, passwordTextbox.Text, true);
				calendar_month.Visible = true;
				this.Visible = false;
				currentUser = GetUser(user);
				CheckUpcoming(currentUser.UserId);
			}
			else
            {
				LogAuthentication(usernameTextbox.Text, passwordTextbox.Text, false);
				loginErrorLabel.Visible = true;

				if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
				{
					loginErrorLabel.Text = "Username and Password do not match.";
				}
				else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				{
					loginErrorLabel.Text = "Nombre de usuario y contraseña no coinciden.";
				}
            }
		}

		// Void -> Boolean
		// This method returns true if the user in the textbox 'exists' in the database, returns false if it doesn't
		private bool UserExists()
        {
			// Create a local reference to the Sql Connection in the DBConnection class
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			try
            {
				// If the connection is not open, inform user and return false to get out of the function call
				if (!(sqlConnection.State == ConnectionState.Open))
				{
					if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
					{
						MessageBox.Show("Connection to Database is closed.", "Connection Error");
					}
					else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
					{
						MessageBox.Show("La conexión a la base de datos está cerrada.", "Error de conexión");
					}

					return false;
				}
				
				// Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT userName FROM user", sqlConnection);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
                {
					// Set username string to every value of the userName column of the user table
					string username = sqlReader.GetString("userName");

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
				if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
				{
					MessageBox.Show(exception.Message, "User Exists Error");
				}
				else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				{
					MessageBox.Show(exception.Message, "El usuario existe error");
				}

				return false;
            }
		}

		// Void -> String
		// This method grabs the password of the user from the username textbox if it exists
		private string GrabPasswordFromDatabase()
        {
			// Create a local reference to the Sql Connection in the DBConnection class
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			try
			{
				// If the connection is not open, inform user and return null to get out of the function call
				if (!(sqlConnection.State == ConnectionState.Open))
				{
					if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
					{
						MessageBox.Show("Connection to Database is closed.", "Connection Error");
					}
					else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
					{
						MessageBox.Show("La conexión a la base de datos está cerrada.", "Error de conexión");
					}
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
				if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
				{
					MessageBox.Show(exception.Message, "User Exists Error");
				}
				else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				{
					MessageBox.Show(exception.Message, "El usuario existe error");
				}

				return null;
			}
		}
	
		// Void -> Void
		// This method sets up a timer and adds a one second update interval and the tmr_Tick event handler to it
		private void StartTimer()
		{
			System.Windows.Forms.Timer timer = null;

			timer = new System.Windows.Forms.Timer();
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

		// String String Boolean -> Void
		// This method takes in the username string, the password string and a boolean and
		// depending on whether or not the authentication was successful or not, logs the authentication result
		private void LogAuthentication(string username, string password, bool success)
        {
			if (!File.Exists("..\\..\\logs\\authenticationLog.txt"))
            {
				File.Create("..\\..\\logs\\authenticationLog.txt");
            }

			FileStream authLog = new FileStream("..\\..\\logs\\authenticationLog.txt", FileMode.Append, FileAccess.Write);

			if (success == true)
            {
				StreamWriter authCreds = new StreamWriter(authLog);
				authCreds.WriteLine("User '" + usernameTextbox.Text + "' has authenticated successfully at " + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("UTC")).ToString() + " UTC");
				authCreds.Close();
            }
            else
            {
				StreamWriter authCreds = new StreamWriter(authLog);
				authCreds.WriteLine("User '" + usernameTextbox.Text + "' & Password '" + passwordTextbox.Text + "' has attempted to authenticate at " + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("UTC")).ToString() + " UTC");
				authCreds.Close();
			}

			authLog.Close();
        }

		// String -> User
		// This method grabs the user based on the input string for the username
		private User GetUser(string username)
        {
			// Create a local reference to the Sql Connection in the DBConnection class
			MySqlConnection sqlConnection = DBConnection.sqlConnection;

			try
			{
				// If the connection is not open, inform user and return null to get out of the function call
				if (!(sqlConnection.State == ConnectionState.Open))
				{
					if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
					{
						MessageBox.Show("Connection to Database is closed.", "Connection Error");
					}
					else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
					{
						MessageBox.Show("La conexión a la base de datos está cerrada.", "Error de conexión");
					}
					return null;
				}

				// Create new instance of MySqlCommand with the SqlCmd and the SqlConnection as parameters
				MySqlCommand mySqlCmd = new MySqlCommand("SELECT userId FROM user WHERE userName=@username", sqlConnection);

				// User MySql parameter to specify 'WHERE' clause using user for the username
				mySqlCmd.Parameters.AddWithValue("@username", user);

				// Create a SqlDataReader to execute and read the output of the SqlCommand
				MySqlDataReader sqlReader = mySqlCmd.ExecuteReader();

				// Create int variable to hold each of the results of the sql command
				int userId;

				// While there is a 'record' after the one it is on, continue to the next record
				while (sqlReader.Read())
				{
					// Get the one entry that is the userId corresponding to the username
					userId = sqlReader.GetInt32("userId");

					// Close sqlReader so repeated attempts do not cause an exception
					sqlReader.Close();

					currentUser = new User(userId);

					return currentUser;
				}
				sqlReader.Close();

				// If the code does not find a userId, return null
				return null;
			}

			// If an error occurs, show a messagebox informing the user of the error and return null
			catch (MySqlException exception)
			{
				if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
				{
					MessageBox.Show(exception.Message, "User Exists Error");
				}
				else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
				{
					MessageBox.Show(exception.Message, "El usuario existe error");
				}

				return null;
			}
		}

		// Int -> Void
		// This method takes in the user who has successfully authenticated and checks if they have an appointment in 15 mins or less upon login
		public void CheckUpcoming(int inpUserId)
		{
			List<Appointment> tempList = new List<Appointment>();

			for (int i = 0; i < AppointmentList.appointments.Count; i++)
			{
				if (AppointmentList.appointments[i].User.UserId == inpUserId)
				{
					tempList.Add(AppointmentList.appointments[i]);
				}
			}

			foreach (Appointment appt in tempList)
            {
				TimeSpan ts = appt.Start.ToLocalTime() - DateTime.Now;

				if ((ts.Minutes <= 15 && ts.Minutes > 0 && ts.Days == 0) && (appt.Start.ToLocalTime().Hour == DateTime.Now.Hour))
                {
					MessageBox.Show(String.Format("You have an appointment in " + ts.Minutes + " minutes."));
                }
            }
		}
	}
}
