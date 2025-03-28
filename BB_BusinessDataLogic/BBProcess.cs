using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_BusinessDataLogic
{
    public class BBProcess
    {
        public static double allocation, TotalDailyExpense;
        public static double WeeklyExpenses = 0;
        public static HashSet<int> selectedDay = new HashSet<int>();
        public static List<string> dayArray = new List<string>();
        public static List<double> dailyExpenses = new List<double>();


        public static bool Login(string userUsername, int userPassword)
        {
            string username = "Arra";
            int password = 4321;

            return username == userUsername || password == userPassword;
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

        public static double WeeklyAllowance(int days, double allowance)
        {

            allocation = allowance / days;
            return allocation;
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

        public static bool AddUserInput(int days, int dayInput)
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

        public static double DisplayDailyExpenses(double Breakfast, double Lunch, double Dinner, double Transportation, double WeeklyExpenses)
        {
            TotalDailyExpense = 0;

            TotalDailyExpense = Breakfast + Lunch + Dinner + Transportation;
            dailyExpenses.Add(TotalDailyExpense);
            BBProcess.WeeklyExpenses += TotalDailyExpense;

            return TotalDailyExpense;
        }

        public double DisplayWeeklyExpenses(double WeeklyExpenses)
        {
            return WeeklyExpenses;
        }

        public static bool AllowanceModerator()
        {
            if (TotalDailyExpense < allocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
