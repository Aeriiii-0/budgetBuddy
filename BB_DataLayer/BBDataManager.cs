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
        IBudgetBuddyData budgetBuddyData;

        public BBDataManager()
        {
            //budgetBuddyData = new InMemoryData();
            //budgetBuddyData = new TextFileData();
            //budgetBuddyData = new JsonFileData();
            budgetBuddyData = new DBDataLayer();

        }

        public List<UserAccounts> GetAccounts()
        {
            return budgetBuddyData.GetAccounts();
        }

        public List<FinancialReport> GetExpensesOnAcc(int accountId)
        {
            return budgetBuddyData.GetExpensesOnAcc(accountId);
        }

        public void CreateAccount(UserAccounts userAccounts)
        {
            budgetBuddyData.CreateAccount(userAccounts);
        }

        public void UpdateAccount(UserAccounts userAccounts)
        {
            budgetBuddyData.UpdateAccount(userAccounts);
        }

        public void DeleteAccount(UserAccounts userAccounts)
        {
            budgetBuddyData.DeleteAccount(userAccounts);
        }

        public void AddExpense(FinancialReport expense)
        {
            budgetBuddyData.AddExpense(expense);
        }

        public int GetAccountId(UserAccounts userAccounts)
        {
            return budgetBuddyData.GetAccountId(userAccounts);
        }

        public void ClearData(int accountId)
        {
            budgetBuddyData.DeleteLoggedDays(accountId);
        }
    }
}
