using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    public class User
    {
        public int uniqueID = 0;
        public User()
        {
            uniqueID++;
        }
        public User(int Id)
        {
            UserId = Id;
            uniqueID++;
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
