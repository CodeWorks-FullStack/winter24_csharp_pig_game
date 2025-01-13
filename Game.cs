// ✅ need at least 2 players 
// each player takes turns rolling dice
// on your turn, you can roll the dice as many times as you want
// trying to get a score of 50 to win
// you can stop rolling at any time to add all rolls to your score
// if you roll a 1, your turn is over and you get no score

// import
using pig_game.models;

// similar to export
namespace pig_game;

public class Game
{
  // constructor
  public Game()
  {
    Players = [];
    Console.WriteLine("Pig Game is starting!");

    for (int i = 1; i <= 2; i++)
    {
      Console.WriteLine($"Enter player {i} name!");
      string playerName = GetPlayerName();
      Player newPlayer = new Player(playerName);
      Players.Add(newPlayer);
    }

    for (int i = 0; i < Players.Count; i++)
    {
      Player player = Players[i];
      Console.WriteLine($"Player {i + 1} is {player.Name}");
    }
  }

  public List<Player> Players { get; set; }

  public string GetPlayerName()
  {
    string name = Console.ReadLine();
    if (name == null) throw new Exception("You must enter a name!");
    return name;
  }
}