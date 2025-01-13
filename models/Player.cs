namespace pig_game.models;

public class Player
{
  public Player(string name)
  {
    // this.Name = name;
    Name = name;
    Score = 0;
    DiceRolls = [];
  }

  public string Name { get; set; }
  public int Score { get; set; }
  public List<int> DiceRolls { get; set; }

  // getter (computed property)
  public int TurnScore
  {
    get
    {
      // only a collection of ints has the sum method
      return DiceRolls.Sum();
    }
  }
}