// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.ObjectModel;
namespace budgetBuddy
{
    class budgetBuddy
    {
        private static double allocation, spent, allowance, weeklyExpense;
        private static int days, dayInput, userPassword, choice;
        private static string userUsername;
        private static char userChoices;
        private static HashSet<int> selectedDay = new HashSet<int>();
        static Collection <string> dayArray = new Collection<string>();
        static Collection<double> dailyExpenses = new Collection<double>();
        public static void Main(string[] args)
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("WELCOME TO BUDGET BUDDY! ");
            Console.WriteLine("--------------------------");

            string username = "Arra";
            int password = 4321;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===========================");
                Console.WriteLine();
                Console.WriteLine("Enter your username: ");
                userUsername = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter your password: ");
                userPassword = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===========================");

                if (password != userPassword || username != userUsername)
                {
                    Console.WriteLine("\nIncorrect password entered. Please try again");
                }
            }
            while (userUsername != username || password != userPassword);
            
                Console.WriteLine();
                Console.WriteLine(">> Successful log-in! <<");
                regForm();

   
            static void regForm()
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("How many days do you go to school or work? (1-7): ");
                    days = Convert.ToInt32(Console.ReadLine());


                    if (days < 0 || days > 7)
                    {
                        Console.WriteLine("\nInvalid Input.");
                    }
                }

                while (days < 0 || days > 7);
                
                    Console.WriteLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("How much is your allowance in Philippine Peso? (e.g: 1000.00)");
                    Console.WriteLine("Enter amount here: ");
                    allowance = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("---------------------------------------------------");

                    allocation = allowance / days;
                    Console.WriteLine();
                    Console.WriteLine($"SUGGESTED ALLOCATION PER DAY: >> {allocation} << ");
                    Console.WriteLine("\n--------------------------------------------------");

                    Console.WriteLine("\nCongratulations! You're done with the registration.");
                    Console.WriteLine();
                    Console.WriteLine("--------------------------");

                    do
                    {
                        Console.WriteLine("\n[1] LOG DAILY EXPENSES\n[2] EXIT");
                        Console.WriteLine("\nSelect a choice: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------");

                        if (choice != 1 && choice != 2)
                        {
                            Console.WriteLine("\nPlease enter a valid input");
                        }
                    }

                    while (choice != 1 && choice != 2);
                    
                        switch (choice)
                        {
                            case 1:
                                dailyExpense();
                                break;
                            case 2:
                                Console.WriteLine("Good bye >_<");
                                Environment.Exit(0);
                                break;
                }

            }
        }

        private static void dailyExpense()
        {
            if (selectedDay.Count >= days)
            {
                Console.WriteLine();
                Console.WriteLine("\nYou've already logged for all the days you registered.\nPlease come back next week <33");
                financialReport();
                return;
            }

            do
            {
                Console.WriteLine("\n[1] MONDAY\n[2] TUESDAY\n[3] WEDNESDAY\n[4] THURSDAY\n[5] FRIDAY\n[6] SATURDAY\n[7] SUNDAY");
                Console.WriteLine("\nPlease select the current day:");
                dayInput = Convert.ToInt32(Console.ReadLine());

                if (dayInput <1 || dayInput >7)
                {
                    Console.WriteLine("Please select a valid input");
                }

                else if (selectedDay.Contains(dayInput))
                {
                    Console.WriteLine("You've already logged for the selected day. Please come back tomorrow.");
                    return;
                }
                
            }

            while (dayInput < 1 || dayInput > 7);
            selectedDay.Add(dayInput);

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            dayArray.Add(daysOfWeek[dayInput - 1]);

            moneyTracker();

        }

        private static void moneyTracker()
        {
            spent = 0;
            Console.WriteLine("\nPlease enter the exact amount (in PHP) you spent based on the asked category.");

            Console.WriteLine("\nBreakfast: ");
            spent += Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine("\nLunch: ");
            spent += Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("\nDinner: ");
            spent += Convert.ToDouble(Console.ReadLine());
       
            Console.WriteLine("\nTransportation: ");
            spent += Convert.ToDouble(Console.ReadLine());
            

            weeklyExpense += spent;
            dailyExpenses.Add(spent);
            Console.WriteLine("\nTotal expenses for the day: " + spent);
           
             if (spent >= allowance)
            {
                Console.WriteLine("You have insufficient funds for the rest of the week.");
            }

            else if (spent == allocation)
            {
                Console.WriteLine("Good, you have spent just the right allocation for the day.");
            }
            else if (spent >= allocation)
            {

                Console.WriteLine("\nYou exceed the expense allocation for the day.\nPlease try to lessen your expense the following days for the rest of the week.");
            }

            else if (spent < allocation)
            {
                Console.WriteLine("Great Job! You'll be able to save by the end of the week if you keep up on doing it.");
            }

            do
            {
                Console.WriteLine("\nDo you want to log expense for another day? ");
                Console.WriteLine("\n[Y] YES      [N] NO");
                char userChoice = Console.ReadKey().KeyChar;
                userChoices = char.ToUpper(userChoice);
                Console.WriteLine();

                if (userChoices != 'Y' && userChoices != 'N')
                {
                    Console.WriteLine("\nPlease enter valid inputs only");
                }
            }

           while (userChoices != 'Y' && userChoices != 'N');

            if (userChoices == 'Y')
            {
                dailyExpense();
            }
            else if (userChoices == 'N')
            {
                financialReport();
                Console.WriteLine("\nGood Bye! See ya next time!");
                Environment.Exit(0);
            }
           
        }

        static void financialReport()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n------------WEEKLY FINANCIAL REPORT-------------");
            Console.WriteLine("\nHere's the summary of your weekly expense:");
            Console.WriteLine(("\n"+ string.Join("\t", dayArray)));
            Console.WriteLine("\n"+ string.Join("\t", dailyExpenses));
            Console.WriteLine("\n");
            Console.WriteLine("We'll se you next week!");
            Console.WriteLine("\nTotal expenses throughout the week: " + weeklyExpense);
            Console.WriteLine("\n------------------------------------------------");

            Console.WriteLine("\nThanks for using Budget Buddy by Arriane Nichole Caraliman");

        }
    }
}

