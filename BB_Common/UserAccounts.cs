using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_Common
{
    public class UserAccounts
    {
        string Password = "1234";
        public string password
        {
            get { return Password; }
            set
            {
                if (value.Length < 5)
                {
                    Password = value;
                }
            }
        }

        string Username = "four";
        public string username
        {
            get { return Username; }
            set
            {
                if (value.Length < 5)
                {
                    Username = value;
                }
            }
        }

        public double allowance { get; set; }

    }
}

