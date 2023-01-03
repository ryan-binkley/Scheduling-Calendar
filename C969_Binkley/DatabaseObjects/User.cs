using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    public class User
    {
        public static int uniqueID = 100;
        public User()
        {
            uniqueID++;
            userId = uniqueID;
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
