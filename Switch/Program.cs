//Space to practice switch through a BlackJack game as an example.

using System.ComponentModel.Design;

int totalPlayer = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string switchControl = "menu";

//BlackJack goal: to gather 21 points with the cards. Or, if less, to have a higher score than the dealer's.

while (true)
{
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Welcome to \n BackJack!");
            Console.WriteLine("Select an option (number): ");
            Console.WriteLine("1 - PLAY");
            string swtitchControl = Console.ReadLine();
            break;

        case "1":
            do
            {
                System.Random random = new System.Random();
                num = random.Next(1, 12);
                totalPlayer = totalPlayer + num;
                Console.WriteLine("Pick a cart");
                Console.WriteLine($"You got: {num} ");
                Console.WriteLine("Do you wish another card?");
            } while (Console.ReadLine() == "Yes" ||
            Console.ReadLine() == "yes"
            || Console.ReadLine() == "yes");
            if (totalPlayer > totalDealer && totalPlayer < 22)
            {
                message = "You won!! Congratulations nwn";
                switchControl = "menu";
            }
            else if (totalPlayer >= 22)
            {
                message = "You're over 21. You've lost";
                switchControl = "menu";
            }
            else if (totalPlayer <= totalDealer)
            {
                message = "You lost";
                switchControl = "menu";
            }
            else
            {
                message = "invalid condition";
            }
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Type a valid value");
            break;
    }

}