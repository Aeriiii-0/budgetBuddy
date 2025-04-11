using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return dataManager.AccountValidator(userUsername, userPassword);
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

        public static double WeeklyAllowance(int days, string userUsername)
        {
            allocation = dataManager.GetAllowance(userUsername) / days;
            return allocation;
        }


        public static double UpdateWeeklyAllowance(double Amount, double ToDo, string userUsername, int days)
        {
            double allowance = dataManager.GetAllowance(userUsername);

            if (ToDo == 1)
            {
                allowance += Amount;
                dataManager.UpdateAllowance(userUsername, allowance);
            }
            else
            {
                allowance -= Amount;
                dataManager.UpdateAllowance(userUsername, allowance);
            }

            return allowance;
        }

        public static double DisplayWeeklyExpenses()
        {
            double WeeklyExpenses = 0;
            WeeklyExpenses = dailyExpenses.Sum();
            return WeeklyExpenses;
        }


        public static bool CheckAmount(double Amount, double allowance, string userUsername)
        {
            allowance = dataManager.GetAllowance(userUsername);
            return Amount <= allowance;
        }


        public static double DisplayDailyExpenses(double Breakfast, double Lunch, double Dinner, double Transportation)
        {
            TotalDailyExpense = 0;

            TotalDailyExpense = Breakfast + Lunch + Dinner + Transportation;
            dailyExpenses.Add(TotalDailyExpense);

            return TotalDailyExpense;
        }


        public static double DisplayAllowance(string userUsername)
        {
            double AllowanceLeft = 0;

            double allowance = dataManager.GetAllowance(userUsername);
            double WeeklyExpenses = dailyExpenses.Sum();

            AllowanceLeft = allowance - WeeklyExpenses;

            return AllowanceLeft;
        }



        public static bool AllowanceModerator()
        {
            return TotalDailyExpense < allocation;

        }

        public static bool FinancialReportChecker()
        {
            if (selectedDay.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
