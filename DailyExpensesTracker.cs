// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using BB_BusinessDataLogic;

namespace budgetBuddy
{
    public class DailyExpensesTracker
    {
        static string[] actions = new string[] { "[1] View Allowance", "[2] Log Expenses", "[3] Release Financial Report", "[4] Exit" };
        static int days;
        static string userUsername = string.Empty;
        static double WeeklyExpenses;
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("WELCOME TO BUDGET BUDDY! ");
            Console.WriteLine("--------------------------");

            Login();

        }

        static void Login()
        {
            string userPassword = string.Empty;

            do
            {
                Console.WriteLine("\nEnter your username: ");
                userUsername = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter your password: ");
                userPassword = Console.ReadLine().Trim();

                if (!BBProcess.Login(userUsername, userPassword))
                {
                    Console.WriteLine("\nIncorrect password or username entered. Please try again.");
                }
            }
            while (!BBProcess.Login(userUsername, userPassword));

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n>> Successful log-in! <<");
            Console.WriteLine("\n--------------------------");

            Menu();
            double userInput= GetUserInput();

            while (userInput != 4)
            {
                switch (userInput)
                {
                    case 1:
                        ViewAllowance();
                        break;
                     case 2:
                        RegistrationForm();
                        break;
                    case 3:
                        if (!BBProcess.FinancialReportChecker())
                        {
                            Console.WriteLine("Please log expenses before releasing financial report.");
                        }
                        else
                        {
                            financialReport();
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. (1-4 only)");
                        break;
                }
                Menu();
                userInput = GetUserInput();
            }

        }

        static void Menu()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n   Hey there, Budget Bud!\nHere's what you can do with us:");

            foreach (string action in actions)
            {
                Console.WriteLine("\n"+ action);
            }
        }

        static double GetUserInput() 
        {
            Console.Write("\nInput Action: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            return userInput;
        }

        static int RegistrationForm()
        {
            do
            {
                Console.WriteLine("\nHow many days do you go to school or work? (1-7): ");
                days = Convert.ToInt32(Console.ReadLine());

                if (!BBProcess.WorkDays(days))
                {
                    Console.WriteLine("\nInvalid Input.");
                }

            }
            while (!BBProcess.WorkDays(days));

            InputAllowance();
            return days;
        }

        static void InputAllowance()
        {
            BBProcess.WeeklyAllowance(days, userUsername);

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine($"\nSUGGESTED ALLOCATION PER DAY: >> {BBProcess.WeeklyAllowance(days, userUsername)} <<");
            Console.WriteLine("\nCongratulations! You're done with the registration.");
            Console.WriteLine("\n----------------------------------------------------");

            ToCheckLoggedDays();
        }

        static void ToCheckLoggedDays()
        {
            if (!BBProcess.CheckLoggedDays(days))
            {
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                Console.WriteLine("\nYou've already logged for all the days you registered.\nPlease come back next week <3");
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                return;
            }
            UserInput();
        }

        static int UserInput()
        {

            int dayInput;

            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\nDays of the week:");
                Console.WriteLine("\n[1] MONDAY\n[2] TUESDAY\n[3] WEDNESDAY\n[4] THURSDAY\n[5] FRIDAY\n[6] SATURDAY\n[7] SUNDAY");
                Console.Write("\nPlease select the current day: ");
                dayInput = Convert.ToInt32(Console.ReadLine());

                if (!BBProcess.WorkDays(days))
                {
                    Console.WriteLine("Please select a valid input");
                }
                else if (!BBProcess.AddUserInput(dayInput))
                {
                    Console.WriteLine("\n--------------------------------------------------------------------");
                    Console.WriteLine("You've already logged for the selected day. Please come back tomorrow.");
                    AskToLogDay();

                }
            }
            while (!BBProcess.WorkDays(days));
            moneyTracker();
            return (dayInput);
        }



        static void moneyTracker()
        {

            Console.WriteLine("\n-----------------------------------------------------------------------");
            Console.WriteLine("\nEnter the exact amount (in PHP) you spent based on the asked category.");

            Console.Write("\nBreakfast: ");
            double Breakfast = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nLunch: ");
            double Lunch = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDinner: ");
            double Dinner = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nTransportation: ");
            double Transportation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTotal expenses for the day: " + BBProcess.DisplayDailyExpenses(Breakfast, Lunch, Dinner, Transportation));

            AllowanceReminder();
            AskToLogDay();

        }

        static void AllowanceReminder()
        {

            if (!BBProcess.AllowanceModerator())
            {
                Console.WriteLine("\nYou exceeded the expense allocation for the day. Try to spend less for the rest of the week.");
            }
            else
            {
                Console.WriteLine("\nGood, you have spent just the right allocation for the day.");
            }

        }

        static void ViewAllowance()
        {
            Console.WriteLine("\nAllowance Available: " + BBProcess.DisplayAllowance(userUsername));
        }

        static void AskToLogDay()
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
                ToCheckLoggedDays();
            }
            else
            {
                Menu();
                double userInput = GetUserInput();
            }
        }
        
     
        static void financialReport()
        {
            Console.WriteLine("\n------------WEEKLY FINANCIAL REPORT-------------");
            Console.WriteLine("\nSummary of your weekly expenses:");
            Console.WriteLine("\n" + string.Join("\t", BBProcess.dayArray));
            Console.WriteLine("\n" + string.Join("\t", BBProcess.dailyExpenses));
            Console.WriteLine("\nTotal expenses throughout the week: " + BBProcess.DisplayWeeklyExpenses());
            Console.WriteLine("\nAllowance left: " + BBProcess.DisplayAllowance(userUsername));
            Console.WriteLine("\n------------------------------------------------");
       
        }
    }
}


