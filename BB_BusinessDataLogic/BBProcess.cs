using BB_Common;
using BB_DataLayer;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BB_BusinessDataLogic
{
    public class BBProcess
    {
        public static double allocation, TotalDailyExpense;
        public static HashSet<int> selectedDay = new HashSet<int>();
        public static List<string> dayArray = new List<string>();
        public static List<double> dailyExpenses = new List<double>();
        public static BBDataManager dataManager = new BBDataManager();
        public static MailScenario emailService = new MailScenario();
      

        //methods in previous ui
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

        public static bool ValidDay(int dayInput)
        {
            if (dayInput > 0 && dayInput < 8)
            {
                return true;
            }
            return false;
        }

        public static bool CheckAmount(double Amount, double allowance, string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            allowance = userAccounts.allowance;
            return Amount <= allowance;
        }

        public static bool FinancialReportChecker()
        {
            return selectedDay.Count > 0;
        }


        //used in winforms
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

        public static double WeeklyAllowance(int days, string userUsername, string userPassword)  //daily allocation
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            allocation = userAccounts.allowance / days;
            return allocation;
        }

        public static bool UpdateWeeklyAllowance(double Amount, Actions userAction, string userUsername, string userPassword )
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            double allowance = userAccounts.allowance;

            if (userAction == Actions.Increase)
            {
                allowance += Amount;
                userAccounts.allowance = allowance;
                dataManager.UpdateAccount(userAccounts);
                return true;
            }
           if (userAction == Actions.Decrease) {
            
               if(!CheckAmount(Amount, allowance, userUsername, userPassword))
                {
                    return false;
                }

                allowance -= Amount;
                userAccounts.allowance = allowance;
                dataManager.UpdateAccount(userAccounts);
                return true;
            }
            
            return false;
        }

        public static double DisplayWeeklyExpenses()
        {
            double WeeklyExpenses = 0;
            WeeklyExpenses = dailyExpenses.Sum();
            return WeeklyExpenses;
        }
       
        public static double DisplayDailyExpenses(double Breakfast, double Lunch, double Dinner, double Transportation, string userUsername, string userPassword, int dayInput, double allowance)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            TotalDailyExpense = Breakfast + Lunch + Dinner + Transportation;

            userAccounts.allowance -= TotalDailyExpense; 
            dataManager.UpdateAccount(userAccounts);     
            dailyExpenses.Add(TotalDailyExpense);

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };  
            string dayOfWeek = daysOfWeek[dayInput - 1];

            SaveDailyExpenseToDB(userUsername, userPassword, dayOfWeek, TotalDailyExpense);

            return TotalDailyExpense;
        }

        public static void SaveDailyExpenseToDB(string userUsername, string userPassword, string dayOfWeek, double totalExpense)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            int accountId = dataManager.GetAccountId(userAccounts);

            FinancialReport expense = new FinancialReport
            {
                account_id = accountId,
                DayOfWeek = dayOfWeek,
                TotalExpense = totalExpense,
                ExpenseDate = DateTime.Today
            };

            UpdateAllowanceDisplay(userUsername, userPassword);
            dataManager.AddExpense(expense);

        }

        public static double GetExpenseForDay(int dayIndex)
        {
            if (dayIndex < dailyExpenses.Count)
                return dailyExpenses[dayIndex];
            return 0;
        }

        public static bool AllowanceModerator()
        {
            return TotalDailyExpense < allocation;

        }

        public static double UpdateAllowanceDisplay(string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            return userAccounts.allowance;
        }
       

       
        public static UserAccounts GetUserAccounts(string userUsername, string userPassword)
        {
            var userAccounts = dataManager.GetAccounts();

            foreach (var account in userAccounts)
            {
                if (account.username == userUsername && account.password == userPassword)
                {
                    return account;
                }

            }
            return null;
        }

        public static bool CreateAccount(string userUsername, string userPassword, double allowance)
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);

            if (userAccounts == null)
            {
                userAccounts = new UserAccounts
                {
                    username = userUsername,
                    password = userPassword,
                    allowance = allowance
                };

                dataManager.CreateAccount(userAccounts);
                var emailService = new MailService();
                bool success = emailService.SendEmail(MailScenario.Welcome, userUsername.ToLower() + "@gmail.com",  userUsername);
                if (success)
                    Console.WriteLine("Email sent!");
                else
                    Console.WriteLine("Email failed to send");

                return true;

            }
            else
            {
                return false; 
            }
        }


        public static bool DeleteAccount(string userUsername, string userPassword) 
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);

            if (userAccounts == null)
            {
                return false;
                
            }
            else
            {
                var emailService = new MailService();
                bool success = emailService.SendEmail(MailScenario.AccountDelete, userUsername.ToLower() + "@gmail.com", userUsername);
                dataManager.DeleteAccount(userAccounts);
                return true;
            }
        }

        public static bool UpdateAccount(string userUsername, string userPassword,  string newPassword) 
        {
            UserAccounts userAccounts = GetUserAccounts(userUsername, userPassword);

            if (userAccounts == null)
            {
                return false;
            }
            else
            {
                userAccounts.password = newPassword;
                dataManager.UpdateAccount(userAccounts);
                return true;
            }
        }

       

        public static bool ClearData(string userUsername, string userPassword)
        {
            var userAccounts = GetUserAccounts(userUsername, userPassword);
            int accountId = dataManager.GetAccountId(userAccounts);

            dataManager.ClearData(accountId);
            return true;
        }


      

        public static void LogAnotherWeek()
        {
            selectedDay.Clear(); 
            dayArray.Clear();
            dailyExpenses.Clear();
        }

      

        public static List<UserAccounts> GetAccounts()
        {
            return dataManager.GetAccounts(); 
        }

        public static List<FinancialReport> GetUserExpenses(string userUsername, string userPassword)
        {
            var userAccount = GetUserAccounts(userUsername, userPassword);
            int accountId = dataManager.GetAccountId(userAccount);
            return dataManager.GetExpensesOnAcc(accountId);
        }




    }
}
