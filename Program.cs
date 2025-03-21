// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.ObjectModel;

namespace budgetBuddy
{
    class budgetBuddy
    {
        static HashSet<int> selectedDay = new HashSet<int>();
        static List<string> dayArray = new List<string>();
        static List<double> dailyExpenses = new List<double>();


        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("WELCOME TO BUDGET BUDDY! ");
            Console.WriteLine("--------------------------");

            string username = "Arra";
            int password = 4321;
            string userUsername;
            int userPassword;

            do
            {
                Console.WriteLine("\nEnter your username: ");
                userUsername = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter your password: ");
                userPassword = Convert.ToInt32(Console.ReadLine().Trim());

                if (password != userPassword || username != userUsername)
                {
                    Console.WriteLine("\nIncorrect password entered. Please try again.");
                }
            }
            while (userUsername != username || password != userPassword);

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n>> Successful log-in! <<");
            Console.WriteLine("\n--------------------------");

            (int days, double allowance) = regForm();
            appFunctions(days, allowance);
        }

        static (int, double) regForm()
        {
            int days;
            double allowance;

            do
            {
                Console.WriteLine("\nHow many days do you go to school or work? (1-7): ");
                days = Convert.ToInt32(Console.ReadLine());

                if (days < 1 || days > 7)
                {
                    Console.WriteLine("\nInvalid Input.");
                }
            }
            while (days < 1 || days > 7);

            Console.WriteLine();
            Console.WriteLine("\nHow much is your weekly allowance in Philippine Peso? (e.g: 1000.00)");
            Console.WriteLine("\nEnter amount here: ");
            allowance = Convert.ToDouble(Console.ReadLine());

            double allocation = allowance / days;

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine($"\nSUGGESTED ALLOCATION PER DAY: >> {allocation} << ");
            Console.WriteLine("\nCongratulations! You're done with the registration.");
            Console.WriteLine("\n----------------------------------------------------");

            return (days, allowance);
        }

        static void appFunctions(int days, double allowance)
        {
            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter an Action: ");
                Console.WriteLine("\n[1] LOG DAILY EXPENSES\n[2] EXIT");
                Console.WriteLine("\nSelect a choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("\nPlease enter a valid input");
                }
            }
            while (choice != 1 && choice != 2);

            switch (choice)
            {
                case 1:
                    dailyExpense(days, allowance, 0);
                    break;
                case 2:
                    Console.WriteLine("Goodbye >_<");
                    Environment.Exit(0);
                    break;
            }
        }

        private static void dailyExpense(int days, double allowance, double weeklyExpense)
        {
            if (selectedDay.Count >= days)
            {
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                Console.WriteLine("\nYou've already logged for all the days you registered.\nPlease come back next week <3");
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                financialReport(weeklyExpense);
                return;
            }

            int dayInput;
            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\nDays of the week:");
                Console.WriteLine("\n[1] MONDAY\n[2] TUESDAY\n[3] WEDNESDAY\n[4] THURSDAY\n[5] FRIDAY\n[6] SATURDAY\n[7] SUNDAY");
                Console.Write("\nPlease select the current day: ");
                dayInput = Convert.ToInt32(Console.ReadLine());

                if (dayInput < 1 || dayInput > 7)
                {
                    Console.WriteLine("Please select a valid input");
                }
                else if (selectedDay.Contains(dayInput))
                {
                    Console.WriteLine("\n--------------------------------------------------------------------");
                    Console.WriteLine("You've already logged for the selected day. Please come back tomorrow.");
                    askToLog(days, allowance, weeklyExpense);
                    return;
                }
            }
            while (dayInput < 1 || dayInput > 7);

            selectedDay.Add(dayInput);
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            dayArray.Add(daysOfWeek[dayInput - 1]);

            double spent = moneyTracker();
            dailyExpenses.Add(spent);
            weeklyExpense += spent;

            Console.WriteLine("\nTotal expenses for the day: " + spent);
            allowanceModerator(spent, allowance / days, allowance);
            askToLog(days, allowance, weeklyExpense);
        }

        private static double moneyTracker()
        {
            double spent = 0;
            Console.WriteLine("\n-----------------------------------------------------------------------");
            Console.WriteLine("\nEnter the exact amount (in PHP) you spent based on the asked category.");

            Console.Write("\nBreakfast: ");
            spent += Convert.ToDouble(Console.ReadLine());

            Console.Write("\nLunch: ");
            spent += Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDinner: ");
            spent += Convert.ToDouble(Console.ReadLine());

            Console.Write("\nTransportation: ");
            spent += Convert.ToDouble(Console.ReadLine());

            return spent;
        }

        static void allowanceModerator(double spent, double allocation, double allowance)
        {
            if (spent >= allowance)
            {
                Console.WriteLine("You have insufficient funds for the rest of the week.");
            }
            else if (spent == allocation)
            {
                Console.WriteLine("Good, you have spent just the right allocation for the day.");
            }
            else if (spent > allocation)
            {
                Console.WriteLine("\nYou exceeded the expense allocation for the day. Try to spend less for the rest of the week.");
            }
            else
            {
                Console.WriteLine("Great Job! You might be able to save by the end of the week!");
            }
        }

        static void askToLog(int days, double allowance, double weeklyExpense)
        {
            char userChoice;
            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\nDo you want to log expense for another day?\n[Y] YES  [N] NO");
                userChoice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (userChoice != 'Y' && userChoice != 'N')
                {
                    Console.WriteLine("\nPlease enter valid inputs only.");
                }
            }
            while (userChoice != 'Y' && userChoice != 'N');

            if (userChoice == 'Y')
            {
                dailyExpense(days, allowance, weeklyExpense);
            }
            else
            {
                financialReport(weeklyExpense);
                Console.WriteLine("\nGoodbye! See you next time!");
                Environment.Exit(0);
            }
        }

        static void financialReport(double weeklyExpense)
        {
            Console.WriteLine("\n------------WEEKLY FINANCIAL REPORT-------------");
            Console.WriteLine("\nSummary of your weekly expenses:");
            Console.WriteLine("\n" + string.Join("\t", dayArray));
            Console.WriteLine("\n" + string.Join("\t", dailyExpenses));
            Console.WriteLine("\nTotal expenses throughout the week: " + weeklyExpense);
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("\nThanks for using Budget Buddy by Arriane Nichole Caraliman.");
        }
    }
}


