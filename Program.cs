internal class Program
{
    private static void Main(string[] args)
    {
        static string GetComputerChoice()
        {
            Random rand = new Random();
            int choice = rand.Next(1, 4);
            switch (choice)
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
            }
            return "SCISSORS";
        }

        static string GetPlayerChoice()
        {
            while (true)
            {
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                string userInput = Console.ReadLine().Trim().ToUpper();

                if (userInput == "ROCK" || userInput == "PAPER" || userInput == "SCISSORS")
                {
                    return userInput;
                }

                else if (userInput == "R")
                {
                    userInput = "ROCK";
                    return userInput;
                }

                else if (userInput == "P")
                {
                    userInput = "PAPER";
                    return userInput;
                }

                else if (userInput == "S")
                {
                    userInput = "SCISSORS";
                    return userInput;
                }

                else
                {
                    Console.WriteLine("Didn't understand, try again.\n");
                }
            }
        }


        static void PlayGame(string playerChoice, string computerChoice)
        {
            Console.WriteLine($"\nYou chose {playerChoice}");
            Console.WriteLine($"I chose {computerChoice}\n");
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a draw!\n");
            }
            else if (playerChoice == "ROCK" && computerChoice == "SCISSORS")
            {
                Console.WriteLine("You win!\n");
            }
            else if (playerChoice == "PAPER" && computerChoice == "ROCK")
            {
                Console.WriteLine("You win!\n");
            }
            else if (playerChoice == "SCISSORS" && computerChoice == "PAPER")
            {
                Console.WriteLine("You win!\n");
            }
            else
            {
                Console.WriteLine("I win!\n");
            }
        }

        while (true)
        {
            PlayGame(GetPlayerChoice(), GetComputerChoice());
        }
    }
}