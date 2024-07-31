//Space to practice switch through a BlackJack game as an example.

using System.ComponentModel.Design;

int totalPlayer = 21;
int totalDealer = 15;
string message = "";
string switchControl = "menu";

//BlackJack goal: to gather 21 points with the cards. Or, if less, to have a higher score than the dealer's.

switch (switchControl)
{
    case "menu":
        Console.WriteLine("Welcome to \n BackJack!");
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1 - PLAY");
        string swtitchControl = Console.ReadLine();
        break;

    case "play":
        if (totalPlayer > totalDealer && totalPlayer < 22)
        {
            message = "You won!! Congratulations nwn";
        }
        /* else if (totalPlayer <= totalDealer)
        { 
            message = "You lost. I'm sorry uwu";
        } */

        else if (totalPlayer >= 22)
        {
            message = "You're over 22. You've lost";
        }
        else
        {
            message = "Invalid condition";
        }

        Console.WriteLine(message);
        break;

}