using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Binkley
{
    class User
    {
        public User(int Id)
        {
            UserId = Id;
        }

        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}
