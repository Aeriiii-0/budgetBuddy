using BB_Common;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DataLayer
{
    public class InMemoryData : IBudgetBuddyData
    {
        List<UserAccounts> accounts = new List<UserAccounts>();
        public InMemoryData()
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


        public double GetAllowance(string userUsername)
        {
            foreach (var account in accounts)
            {
                if (account.username == userUsername)
                {
                    return account.allowance;
                }
            }
            return 0.0;
        }

        public void UpdateAccount(UserAccounts userAccounts)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == userAccounts.username)
                {
                    accounts[i].allowance = userAccounts.allowance;
                }
            }
        }

        public void CreateAccount(UserAccounts userAccounts)
        {

        }


        public List<UserAccounts> GetAccounts()
        {
            return accounts;
        }

        public void DeleteAccount(UserAccounts userAccounts)
        {

        }

        public void AddExpense(FinancialReport expense)
        {

        }

        public int GetAccountId(UserAccounts userAccounts)
        {
            return 0;
        }

        public void DeleteLoggedDays(int accountId)
        {
           
        }

        public List<FinancialReport> GetExpensesOnAcc(int accountId)
        {
            return new List<FinancialReport>();
        }

    }
}
