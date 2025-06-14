// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Principal;
using BB_BusinessDataLogic;
using BB_Common;

namespace budgetBuddy
{
    public class DailyExpensesTracker
    {
        static string[] actions = new string[] { "[1] View Allowance", "[2] Log Expenses", "[3] Release Financial Report", "[4] Update Allowance", "[5] Account Settings", "[6] Log Another week", "[7] Log-out ", "[8] Exit" };

        static int days, action, dayInput;
        static string userUsername = string.Empty;
        static string userPassword = string.Empty;
        static double WeeklyExpenses, userInput, allowance;
        static List<UserAccounts> userAccount = new List<UserAccounts>();
        static string newUsername, newPassword;
        static double newAllowance;


        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("WELCOME TO BUDGET BUDDY! ");
            Console.WriteLine("--------------------------");

            Entrance();
            Login();

        }

        static void Login()
        {

            do
            {
                Menu();
                userInput = GetUserInput();

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
                            Console.WriteLine("\n----------------------------------------------------");
                            Console.WriteLine("\nPlease log expenses before releasing financial report.");
                        }
                        else
                        {
                            financialReport();
                        }
                        break;
                    case 4:
                        OperationToDo();
                        break;
                    case 5:
                        AccountSettings(userAccount);
                        break;
                    case 6:
                        LogAnotherWeek();
                        break;
                    case 7:
                        Entrance();
                        Login();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. (1-8 only)");
                        break;
                }
            }

            while (userInput != 7);

        }


        static void Menu()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n   Hey there, Budget Bud!\nHere's what you can do with us:");

            foreach (string action in actions)
            {
                Console.WriteLine("\n" + action);
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

            DisplayWeeklyAllocation();
            return days;
        }

        static void DisplayWeeklyAllocation()
        {

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine($"\nSUGGESTED ALLOCATION PER DAY: >> {BBProcess.WeeklyAllowance(days, userUsername, userPassword)} <<");
            Console.WriteLine("\nGreat! Try to keep expenses under the allocation to save money!");
            Console.WriteLine("\n----------------------------------------------------");

            ToCheckLoggedDays();
        }

        static double OperationToDo()
        {
            double ToDo = 0;
            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("\nSelect action to update your allowance ");
                Console.WriteLine("\n[1] Increase     [2] Decrease");
                Console.WriteLine("\nAction: ");
                ToDo = Convert.ToDouble(Console.ReadLine());

                if (ToDo != 1 && ToDo != 2)
                {
                    Console.WriteLine("\nPlease input 1 or 2 only");
                }
            }

            while (ToDo != 1 && ToDo != 2);
            InputAllowance(ToDo);
            return ToDo;
        }

        static double InputAllowance(double ToDo)
        {
            double Amount = 0;
            if (ToDo == 2)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("\nEnter amount here: ");
                    Amount = Convert.ToDouble(Console.ReadLine());

                    if (!BBProcess.CheckAmount(Amount, allowance, userUsername, userPassword))
                    {
                        Console.WriteLine("Insufficient allowance. Please decrease accordingly.");

                    }
                }
                while (!BBProcess.CheckAmount(Amount, allowance, userUsername, userPassword));

                Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("\nAllowance Updated!");
                Console.WriteLine("\nAllowance Available:" + BBProcess.UpdateWeeklyAllowance(Amount, ToDo, userUsername, days, userPassword));
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("\nEnter amount here: ");
                Amount = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("\nAllowance Updated!");
                Console.WriteLine("\nAllowance Available:" + BBProcess.UpdateWeeklyAllowance(Amount, ToDo, userUsername, days, userPassword));
            }
            return Amount;
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
            else
            {
                UserInput();
            }

        }

        static int UserInput()
        {


            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\nDays of the week:");
                Console.WriteLine("\n[1] MONDAY\n[2] TUESDAY\n[3] WEDNESDAY\n[4] THURSDAY\n[5] FRIDAY\n[6] SATURDAY\n[7] SUNDAY");
                Console.Write("\nPlease select the current day: ");
                dayInput = Convert.ToInt32(Console.ReadLine());

                if (!BBProcess.ValidDay(dayInput))
                {
                    Console.WriteLine("\nInvalid Input.");
                }

                else if (!BBProcess.AddUserInput(dayInput))
                {
                    Console.WriteLine("\n--------------------------------------------------------------------");
                    Console.WriteLine("You've already logged for the selected day. Please come back tomorrow.");
                    AskToLogDay();

                }
                else
                {
                    moneyTracker();
                }
            }
            while (!BBProcess.ValidDay(dayInput));
            return dayInput;
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

            Console.WriteLine("\nTotal expenses for the day: " + BBProcess.DisplayDailyExpenses(Breakfast, Lunch, Dinner, Transportation, userUsername, userPassword, dayInput));

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
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\nAllowance Available: " + BBProcess.UpdateAllowanceDisplay(userUsername, userPassword));
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
        }

        static void financialReport()
        {
            Console.WriteLine("\n------------WEEKLY FINANCIAL REPORT-------------");
            Console.WriteLine("\nSummary of your weekly expenses:");
            Console.WriteLine("\n" + string.Join("\t", BBProcess.dayArray));
            Console.WriteLine("\n" + string.Join("\t", BBProcess.dailyExpenses));
            Console.WriteLine("\nTotal expenses throughout the week: " + BBProcess.DisplayWeeklyExpenses());
            Console.WriteLine("\nAllowance left: " + BBProcess.DisplayAllowance(userUsername, userPassword));
            Console.WriteLine("\n------------------------------------------------");

        }

        static void AccountSettings(List<UserAccounts> userAccount)
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("\nAccount Settings");
            Console.WriteLine("\n[1] Update Account");
            Console.WriteLine("\n[2] Delete Account");
            Console.WriteLine("\n[3] Clear Logged Data");
            Console.WriteLine("\n[4] Back to Main Menu");


            Console.Write("\nSelect action: ");
            action = Convert.ToInt32(Console.ReadLine());


            switch (action)
            {
                case 1:
                    AccountChecker();
                    Console.Write("\nEnter New Password: ");
                    newPassword = Console.ReadLine().Trim();

                    Console.Write("\nEnter New Allowance: ");
                    newAllowance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\nAccount Updated!");
                    BBProcess.UpdateAccount(userUsername, userPassword, newPassword);
                    break;
                case 2:
                    AccountChecker();
                    Console.WriteLine("\n----------------------------------------------------");
                    Console.WriteLine("\nAccount Deleted!");
                    BBProcess.DeleteAccount(userUsername, userPassword);
                    break;
                case 3:
                    ClearData();
                    break;
                case 4:
                    Menu();
                    userInput = GetUserInput();
                    break;
                default:
                    Console.WriteLine("\nInvalid input. (1-4 only)");
                    break;

            }


        }
        static void AccountChecker()
        {
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
        }

        static void AddAccountDetails()
        {
            Console.Write("\nEnter New Username: ");
            userUsername = Console.ReadLine().Trim();

            Console.Write("\nEnter New Password: ");
            userPassword = Console.ReadLine().Trim();

            Console.Write("\nEnter New Allowance: ");
            allowance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("\nAccount Created!");
            BBProcess.CreateAccount(userUsername, userPassword,allowance);
        }

        static void LogAnotherWeek()
        {
            BBProcess.LogAnotherWeek();
            RegistrationForm();
        }

        static void ClearData()
        {
            if (!BBProcess.ClearData(userUsername, userPassword))
            {
                Console.WriteLine("No data to delete.");
            }
            else
            {
                Console.WriteLine("Logged days data has been deleted.");
            }

        }

        static void Entrance(){
            float actionInput;

            do
            {

                Console.WriteLine("\n--------------------------");
                Console.WriteLine("\nPick Action: ");
                Console.WriteLine("\n[1] Log-in \n \n[2] Sign-up");
                Console.WriteLine();
                actionInput = Convert.ToSingle(Console.ReadLine());


                if (actionInput == 1)
                {
                    AccountChecker();

                    Console.WriteLine("\n--------------------------");
                    Console.WriteLine("\n>> Successful log-in! <<");
                    Console.WriteLine("\n--------------------------");
                }
                else if (actionInput == 2)
                {
                    AddAccountDetails();
                }

                if (actionInput != 1 && actionInput != 2)
                {
                    Console.WriteLine("\nInvalid Input. Please enter 1 or 2 only.");
                }
            }
            while (actionInput != 1 && actionInput != 2);
        }

    }
}


