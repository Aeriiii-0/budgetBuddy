using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_Common
{
    public class UserAccounts
    {
        public string Password = "1234";
        public string password
        {
            get { return Password; }
            set
            {
                if (value.Length <6 )
                {
                    Password = value;
                }
            }
        }

        public string Username = "four";
        public string username
        {
            get { return Username; }
            set
            {
                if (value.Length < 6)
                {
                    Username = value;
                }
            }
        }

        public double allowance { get; set; }



    }
}

