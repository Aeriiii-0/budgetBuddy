// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using BB_BusinessDataLogicc;

namespace budgetBuddy
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("WELCOME TO BUDGET BUDDY! ");
            Console.WriteLine("--------------------------");


            string userUsername;
            int userPassword;

            do
            {
                Console.WriteLine("\nEnter your username: ");
                userUsername = Console.ReadLine().Trim();

                Console.WriteLine("\nEnter your password: ");
                userPassword = Convert.ToInt32(Console.ReadLine().Trim());

                if (!BB_Process.Login(userUsername, userPassword))
                {
                    Console.WriteLine("\nIncorrect password entered. Please try again.");
                }
            }
            while (!BB_Process.Login(userUsername, userPassword));

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\n>> Successful log-in! <<");
            Console.WriteLine("\n--------------------------");

            int days = RegistrationForm();

        }

        static int RegistrationForm()
        {
            int days;
            do
            {
                Console.WriteLine("\nHow many days do you go to school or work? (1-7): ");
                days = Convert.ToInt32(Console.ReadLine());

                if (!BB_Process.WorkDays(days))
                {
                    Console.WriteLine("\nInvalid Input.");
                }

            }
            while (!BB_Process.WorkDays(days));

            InputAllowance(days);
            return days;
        }

        static double InputAllowance(int days)
        {

            Console.WriteLine();
            Console.WriteLine("\nHow much is your weekly allowance in Philippine Peso? (e.g: 1000.00)");
            Console.WriteLine("\nEnter amount here: ");
            double allowance = Convert.ToDouble(Console.ReadLine());

            BB_Process.WeeklyAllowance(days, allowance);

            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine($"\nSUGGESTED ALLOCATION PER DAY: >> {BB_Process.allocation} <<");
            Console.WriteLine("\nCongratulations! You're done with the registration.");
            Console.WriteLine("\n----------------------------------------------------");

            ToCheckLoggedDays(days);
            return (allowance);
        }

        static void ToCheckLoggedDays(int days)
        {
            if (!BB_Process.CheckLoggedDays(days))
            {
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                Console.WriteLine("\nYou've already logged for all the days you registered.\nPlease come back next week <3");
                Console.WriteLine("\n-------------------------------------------------------------------------------------");
                financialReport();
                return;

            }

            UserInput(days);


        }

        static int UserInput(int days)
        {

            int dayInput;

            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("\nDays of the week:");
                Console.WriteLine("\n[1] MONDAY\n[2] TUESDAY\n[3] WEDNESDAY\n[4] THURSDAY\n[5] FRIDAY\n[6] SATURDAY\n[7] SUNDAY");
                Console.Write("\nPlease select the current day: ");
                dayInput = Convert.ToInt32(Console.ReadLine());

                if (!BB_Process.WorkDays(days))
                {
                    Console.WriteLine("Please select a valid input");
                }
                else if (!BB_Process.AddUserInput(days, dayInput))
                {
                    Console.WriteLine("\n--------------------------------------------------------------------");
                    Console.WriteLine("You've already logged for the selected day. Please come back tomorrow.");
                    AskToLogDay(days);

                }
            }
            while (!BB_Process.WorkDays(days));
            moneyTracker(days);
            return (dayInput);
        }




        static void moneyTracker(int days)
        {
            BB_Process BB_Process = new BB_Process();

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

            double WeeklyExpenses = 0;

            Console.WriteLine("\nTotal expenses for the day: " + BB_Process.DisplayDailyExpenses(Breakfast, Lunch, Dinner, Transportation, WeeklyExpenses));

            AllowanceReminder();
            AskToLogDay(days);

        }

        static void AllowanceReminder()
        {

            if (!BB_Process.AllowanceModerator())
            {
                Console.WriteLine("\nYou exceeded the expense allocation for the day. Try to spend less for the rest of the week.");
            }
            else
            {
                Console.WriteLine("\nGood, you have spent just the right allocation for the day.");
            }

        }

        static void AskToLogDay(int days)
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
                ToCheckLoggedDays(days);
            }
            else
            {
                financialReport();
                Console.WriteLine("\nGoodbye! See you next time!");
                Environment.Exit(0);
            }
        }

        static void financialReport()
        {
            Console.WriteLine("\n------------WEEKLY FINANCIAL REPORT-------------");
            Console.WriteLine("\nSummary of your weekly expenses:");
            Console.WriteLine("\n" + string.Join("\t", BB_Process.dayArray));
            Console.WriteLine("\n" + string.Join("\t", BB_Process.dailyExpenses));
            Console.WriteLine("\nTotal expenses throughout the week: " + BB_Process.WeeklyExpenses);
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("\nThanks for using Budget Buddy :>>.");
        }
    }
}


