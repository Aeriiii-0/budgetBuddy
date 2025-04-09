using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB_Common;

namespace BB_DataLayer
{
    
    public class BBDataManager
    {
        List<UserAccounts> accounts = new List<UserAccounts>();

        public BBDataManager() 
        {
            ExistingAccounts();
        }

        public void ExistingAccounts()
        {
            accounts.Add(new UserAccounts
            {
                username = "Arra",
                password = "4321",
                allowance = 5000
            });

            accounts.Add(new UserAccounts
            {
                username = "kairi",
                password = "1234",
                allowance = 750
            });

            accounts.Add(new UserAccounts
            {
                username = "Jyan",
                password = "1111",
                allowance = 1500
            });

            accounts.Add(new UserAccounts
            {
                username = "mein",
                password = "2222",
                allowance = 8200
            });

            accounts.Add(new UserAccounts
            {
                username = "deil",
                password = "3333",
                allowance = 200
            });
        }

        public bool AccountValidator(string userUsername, string userPassword)
        {
            foreach (var account in accounts)
            {
                if( account.username == userUsername && account.password == userPassword )
                {
                    return true;
                }
            }
            return false;
        }

    public double GetAllowance(string userUsername)
        {
        foreach(var account in accounts)
            {
                if (account.username == userUsername)
                {
                    return account.allowance;
                }
            }
        return 0.0;
        }
    }

}
