using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo to get info

            GreetUser(); //Run GreetUser to greet user

            while (true)
            {


                //Init correct number
                // int correctNumber = 7;

                // Create a new random number
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;


                //Ask user for number
                Console.WriteLine("Guess the number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    { 
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                      
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please Try Again!!!");

                    }

                }

                //Print success message
                PrintColorMessage(ConsoleColor.Green, "Correct, You guessed the right number.");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //Get app information
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Anish Duwal";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        //Ask users name and greet
        static void GreetUser()
        {
            // Ask user name
            Console.Write("What is your name:");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play game.", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Tell user its a wrong number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
        
    }
}
