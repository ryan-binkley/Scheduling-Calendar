using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    public class User
    {
        // Create an instance of the Random class to make a random number generator
        Random rng = new Random();
        public User()
        {
            // Uses the Random class to make a psuedo-random number between 1 and 1,000,000 to decrease the odds of non-unique numbers being assigned as the ID.
            userId = rng.Next(1, 1000000);
        }

        public User(string inpString)
        {

        }

        public User(int Id)
        {
            userId = Id;
        }

        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
