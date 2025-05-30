using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB_Common;

namespace BB_DataLayer
{
    public interface IBudgetBuddyData
    {
        public List<UserAccounts> GetAccounts();
        public void CreateAccount(UserAccounts userAccounts);
        public void UpdateAccount(UserAccounts userAccounts);
        public void DeleteAccount(UserAccounts userAccounts);
        void AddExpense(FinancialReport expense);
        int GetAccountId(UserAccounts userAccounts);
        void DeleteLoggedDays(int accountId);

    }
}
