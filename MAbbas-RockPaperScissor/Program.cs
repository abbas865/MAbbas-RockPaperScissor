// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Rock-Paper-Scissors Game");
string? userInput = "";
bool playAgain = true;
string? playAgainAns = "Y";
Random rand = new Random();

while (playAgain)
{
    userInput = "";
    while ((!(userInput == null ? "" : userInput.ToUpper()).Equals(PossibleInputVals.ROCK.ToString())) && (!(userInput == null ? "" : userInput.ToUpper()).Equals(PossibleInputVals.PAPER.ToString())) && (!(userInput == null ? "" : userInput.ToUpper()).Equals(PossibleInputVals.SCISSOR.ToString())))
    {
        Console.WriteLine("Please Enter Rock, Paper or Scissor");
        userInput = Console.ReadLine();
      
    }
    var computersSelection = rand.Next(1, 4) switch
    {
        1 => "ROCK",
        2 => "PAPER",
        3 => "SCISSOR",
        _ => "No Match"
    };
    var result = userInput == null ? "" : userInput.ToUpper() switch
    {
        "ROCK" => computersSelection == "ROCK" ? "It's a draw." : computersSelection == "PAPER" ? "You loose" : "You win",
        "PAPER" => computersSelection == "ROCK" ? "You win." : computersSelection == "PAPER" ? "It's a draw" : "You loose",
        "SCISSOR" => computersSelection == "ROCK" ? "You loose." : computersSelection == "PAPER" ? "You win." : "It's a draw.",
        _ => "No Match"
    };
    Console.WriteLine($"Computer Selection:{computersSelection}\n\rPlayer Selection:{userInput}\n\rResult:{result}");
    Console.WriteLine("Would you like to play the game again (Y/N):");
    playAgainAns = Console.ReadLine();
    if (playAgainAns == null)
    {
        playAgain = false;
    }
    else
    {
        if (playAgainAns.ToUpper().Contains("Y"))
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
        }

    }
    
}
Console.WriteLine("Thank you for playing the game");
enum PossibleInputVals
{
    ROCK,
    PAPER,
    SCISSOR
}