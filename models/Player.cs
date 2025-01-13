namespace pig_game.models;

public class Player
{
  public Player(string name)
  {
    // this.Name = name;
    Name = name;
    Score = 0;
  }

  public string Name { get; set; }
  public int Score { get; set; }
}