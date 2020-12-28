using System;

// namespace
namespace numberGuesser
{
    // main class
    class Program
    {
        // entry point method, Void is the return type
        static void Main(string[] args)
        {
            // START CODE //

            // Get app info
            GetAppInfo();

            // Ask for input and greet user
            GreetUser();

            while(true)
            {
                // create random object
                Random random = new Random();

                //get a random num 1-10
                int correctNumber = random.Next(1, 11);

                // set guess variable
                int guess = 0;

                // ask user to guess
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess in not correct
                while (guess != correctNumber)
                {
                    // get input from user
                    string input = Console.ReadLine();

                    // check user input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        // keep going
                        continue;
                    }

                    // cast to int and store in guess var
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }
                // print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!");

                // ask to play again
                Console.WriteLine("play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // METHODS //

        // display app information
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Matthew Cullen";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Dispaly app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // get username and greet a user
        static void GreetUser()
        {
            // Ask user for name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // welcome user
            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // Console.WriteLine with colors
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // dispaly msg
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
 