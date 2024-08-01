//Space to practice switch and do while through a BlackJack game as an example.

using System.ComponentModel.Design;

int totalPlayer = 0;
int totalDealer = 0;
int num = 0;
int coinsCredit = 0;
string message = "";
string switchControl = "menu";

//BlackJack goal: to gather 21 points with the cards. Or, if less, to have a higher score than the dealer's.

while (true)
{
    Console.WriteLine("******************************************'");
    Console.WriteLine("Welcome to BlackJack!");
    Console.WriteLine("******************************************'");
    Console.WriteLine("Get credits to play \n 1 credit per game \n " +
        "How many credits do you want to get?");
    coinsCredit = int.Parse(Console.ReadLine());

    for (int i = 0; i < coinsCredit; i++)
    {

        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("Select an option (number): ");
                Console.WriteLine("1 - PLAY \n");
                switchControl = Console.ReadLine();
                break;

            case "1":
                do
                {
                    System.Random random = new System.Random();
                    num = random.Next(1, 12);
                    totalPlayer = totalPlayer + num;
                    Console.WriteLine("Pick a card");
                    Console.WriteLine($"You got: {num} ");
                    Console.WriteLine("Do you wish another card? (Yes/No)");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() != "yes")

                    {
                        break;
                    }

                } while (true);

                // Calculate dealer's total after player decides to stop
                System.Random randomDealer = new System.Random();
                totalDealer = randomDealer.Next(12, 23);

                Console.WriteLine($"The dealer's total is: {totalDealer}");

                if (totalPlayer > totalDealer && totalPlayer < 22)
                {
                    message = "You won!! Congratulations nwn";
                }
                else if (totalPlayer > 22)
                {
                    message = "You're over 21. You've lost";
                }
                else
                {
                    message = "You lost";
                }
                Console.WriteLine(message);

                totalPlayer = 0;
                totalDealer = 0;
                switchControl = "menu";
                break;

            default:
                Console.WriteLine("Type a valid value");
                switchControl = "menu";
                break;
        }

    }
}