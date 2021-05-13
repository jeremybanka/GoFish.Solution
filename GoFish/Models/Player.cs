using System.Collections.Generic;

namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; set; }
    private static readonly List<Player> _allPlayers = new() { };
    public List<Card> _hand = new() { };

    public Player(string name)
    {
      Name = name;
      _allPlayers.Add(this);
    }
  }
}