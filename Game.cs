// ✅ need at least 2 players 
// ✅ each player takes turns rolling dice
// ✅ on your turn, you can roll the dice as many times as you want
// trying to get a score of 50 to win
// you can stop rolling at any time to add all rolls to your score
// ✅ if you roll a 1, your turn is over and you get no score

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

    for (int i = 0; i <= Players.Count; i++)
    {
      // NOTE for loop starts over
      if (i == Players.Count) i = 0;
      Console.Clear();
      Player player = Players[i];
      RollDice(player);
    }
  }

  public List<Player> Players { get; set; }

  // NOTE public is access modifier (allows other methods/classes to run this method)
  // NOTE string is the return type of the method
  public string GetPlayerName()
  {
    string name = Console.ReadLine();
    if (name == null) throw new Exception("You must enter a name!");
    return name;
  }

  public int GetRandomDiceRoll()
  {
    int randomNumber = new Random().Next(1, 7);
    return randomNumber;
  }

  public void RollDice(Player player)
  {
    Console.Clear();
    Console.WriteLine($"{player.Name} | Score: {player.Score}");

    int diceRoll = GetRandomDiceRoll();

    player.DiceRolls.Add(diceRoll);


    Console.WriteLine();

    Console.Write("Rolls: ");

    player.DiceRolls.ForEach(roll =>
    {
      Console.Write(roll + " ");
    });

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Score for this turn is {player.TurnScore}");

    if (diceRoll == 1)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("TOO BAD YOU ROLLED A 1");
      Thread.Sleep(1000);
      Console.ResetColor();
      player.DiceRolls.Clear();
      return; //stop the rolldice method
    }

    Console.WriteLine("Do you want to roll again y/n?");
    char keyPressed = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (keyPressed == 'y')
    {
      // NOTE recursion
      RollDice(player);
    }
    else
    {
      player.Score += player.TurnScore;
      player.DiceRolls.Clear();
      return;
    }
  }
}