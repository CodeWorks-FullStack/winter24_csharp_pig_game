// need at least 2 players 
// each player takes turns rolling dice
// on your turn, you can roll the dice as many times as you want
// trying to get a score of 50 to win
// you can stop rolling at any time to add all rolls to your score
// if you roll a 1, your turn is over and you get no score

// NOTE using is similar to import 
using pig_game;

class Program
{
  // NOTE entry point
  public static void Main()
  {
    Console.WriteLine("Application is starting!");
    new Game();
  }
}