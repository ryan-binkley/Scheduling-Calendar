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

namespace C969_Binkley
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

        private void submitCredentialsButton_Click(object sender, EventArgs e)
        {
			// Get the connection string for Sql DB from App.config
			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

			// Make the MySql connection variable
			MySqlConnection sqlConnection = null;

			// Wrap the connection in a exception handling block
			try
            {
				// Set the MySqlConnection variable sqlConnection to a new MySqlConnection with the constr as input for the local db
				sqlConnection = new MySqlConnection(constr);

				// Open the db connection to be worked on
				sqlConnection.Open();

				// Perform needed db functions here
            }

			catch(MySqlException exception)
            {
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }

			finally
            {
				// Close MySql connection
				if (sqlConnection != null)
                {
					sqlConnection.Close();
                }
            }
        }
    }
}
