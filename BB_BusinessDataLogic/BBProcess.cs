using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BB_Common;
using BB_DataLayer;

namespace BB_BusinessDataLogic
{
    public class BBProcess
    {
        public static double allocation, TotalDailyExpense;
        static HashSet<int> selectedDay = new HashSet<int>();
        public static List<string> dayArray = new List<string>();
        public static List<double> dailyExpenses = new List<double>();
        static BBDataManager dataManager = new BBDataManager();


        public static bool Login(string userUsername, string userPassword)
        {
            var userAccounts = dataManager.GetAccounts();

            foreach (var account in userAccounts)
            {
                if (account.username == userUsername && account.password == userPassword)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool WorkDays(int days)
        {
            if (days < 1 || days > 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckLoggedDays(int days)
        {
            if (selectedDay.Count >= days)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidDay(int dayInput)
        {
            if (dayInput > 0 && dayInput < 8)
            {
                return true ;
            }
                return false;
        }

        public static bool AddUserInput(int dayInput)
        {

            if (selectedDay.Contains(dayInput))
            {
                return false;
            }
            else
            {
                selectedDay.Add(dayInput);
                string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                dayArray.Add(daysOfWeek[dayInput - 1]);

                return true;
            }
        }

        public static double WeeklyAllowance(int days, string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            allocation = userAccounts.allowance / days;
            return allocation;
        }

        public static double UpdateWeeklyAllowance(double Amount, double ToDo, string userUsername, int days, string userPassword )
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            double allowance = userAccounts.allowance;

            if (ToDo == 1)
            {
                allowance += Amount;
                userAccounts.allowance = allowance;
            }
            else
            {
                allowance -= Amount;
                userAccounts.allowance = allowance;
                
            }
            dataManager.UpdateAccount(userAccounts);
            return allowance;
        }

        public static double DisplayWeeklyExpenses()
        {
            double WeeklyExpenses = 0;
            WeeklyExpenses = dailyExpenses.Sum();
            return WeeklyExpenses;
        }

        public static bool CheckAmount(double Amount, double allowance, string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword); 
            allowance = userAccounts.allowance;
            return Amount <= allowance;
        }

        public static double DisplayDailyExpenses(double Breakfast, double Lunch, double Dinner, double Transportation)
        {
            TotalDailyExpense = 0;

            TotalDailyExpense = Breakfast + Lunch + Dinner + Transportation;
            dailyExpenses.Add(TotalDailyExpense);

            return TotalDailyExpense;
        }

        public static double DisplayAllowance(string userUsername, string userPassword) 
        {

            var userAccounts = GetUserAccounts(userUsername, userPassword);
            double WeeklyExpenses = dailyExpenses.Sum();

            userAccounts.allowance -= WeeklyExpenses;
            dataManager.UpdateAccount(userAccounts);

            dailyExpenses.Clear();
            dayArray.Clear();
            selectedDay.Clear();

            return UpdateAllowanceDisplay(userUsername, userPassword);
        }

        public static double UpdateAllowanceDisplay(string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            return userAccounts.allowance;
        }
        public static bool AllowanceModerator()
        {
            return TotalDailyExpense < allocation;

        }

        public static bool FinancialReportChecker()
        {
            return selectedDay.Count > 0;
        }

        public static UserAccounts GetUserAccounts(string userUsername, string userPassword)
        {

            var userAccounts = dataManager.GetAccounts();
            var foundAccount = new UserAccounts();

            foreach (var account in userAccounts)
            {
                if (account.username == userUsername && account.password == userPassword)
                {
                    foundAccount = account;
                }

            }
            return foundAccount;
        }

        public static void CreateAccount(string userUsername, string userPassword, string newUsername, string newPassword, double newAllowance)
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);
            if (userAccounts != null)
            {
                userAccounts = new UserAccounts
                {
                    username = newUsername,
                    password = newPassword,
                    allowance = newAllowance,
                };
                dataManager.CreateAccount(userAccounts);
            }
            else
            {
                throw new Exception("Can't create  account");
            }
        }


        public static void DeleteAccount(string userUsername, string userPassword)
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);

            if (userAccounts == null)
            {
                throw new Exception("User account not found.");
            }
            else
            {
                dataManager.DeleteAccount(userAccounts);
            }
        }
        
        

        public static void UpdateAccount(string userUsername, string userPassword, string newUsername, string newPassword, double newAllowance)
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);

            if (userAccounts == null)
            {
                throw new Exception("User account not found.");
            }
            else
            {
                userAccounts.username = newUsername;
                userAccounts.password = newPassword;
                userAccounts.allowance = newAllowance;
                dataManager.UpdateAccount(userAccounts);
            }
        }
    }
}
