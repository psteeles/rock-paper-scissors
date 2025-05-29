static string GetComputerChoice()
{
    Random rand = new Random();
    int choice = rand.Next(1, 4);
    if (choice == 1)
    {
        return "ROCK";
    }
    else if (choice == 2)
    {
        return "PAPER";
    }
    return "SCISSORS";
}

static string GetPlayerChoice()
{
    while (true)
    {
        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
        string userInput = Console.ReadLine()!.Trim().ToUpper();

        if (userInput == "ROCK" || userInput == "PAPER" || userInput == "SCISSORS")
        {
            return userInput;
        }
        else
        {
            Console.WriteLine("Didn't understand, try again.");
        }
    }
}


static void PlayGame(string playerChoice, string computerChoice)
{
    Console.WriteLine($"You chose {playerChoice}");
    Console.WriteLine($"I chose {computerChoice}");
    if (playerChoice == computerChoice)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (playerChoice == "ROCK" && computerChoice == "SCISSORS")
    {
        Console.WriteLine("You win!");
    }
    else if (playerChoice == "PAPER" && computerChoice == "ROCK")
    {
        Console.WriteLine("You win!");
    }
    else if (playerChoice == "SCISSORS" && computerChoice == "PAPER")
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("I win!");
    }
}

while (true){
    PlayGame(GetPlayerChoice(), GetComputerChoice());
}