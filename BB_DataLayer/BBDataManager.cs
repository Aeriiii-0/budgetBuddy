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
            // budgetBuddyData = new InMemoryData();
            //budgetBuddyData = new TextFileData();
            budgetBuddyData = new JsonFileData();
        }

        public List<UserAccounts> GetAccounts()
        {
            return budgetBuddyData.GetAccounts();
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

    }
}
