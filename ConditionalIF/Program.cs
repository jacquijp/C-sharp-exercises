//Space to practice IF through a BlackJack game as an example.

int totalPlayer = 0;
int totalDealer = 15;
string message = "";

//BlackJack goal: to gather 21 points with the cards. Or, if less, to have a higher score than the dealer's.

if (totalPlayer > totalDealer)
{
    message = "You won!! Congratulations nwn";
}
else if (totalPlayer <= totalDealer)
{ 
    message = "You lost. I'm sorry";
}
else
{
    message = "Invalid condition";
}
