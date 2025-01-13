

// NOTE using is similar to import 
using pig_game;
using pig_game.models;

class Program
{
  // NOTE entry point
  public static void Main()
  {
    Console.Clear();
    new Game();
  }

  public List<Player> Players = [];
}