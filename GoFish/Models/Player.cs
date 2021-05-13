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

  public class Card
  {
    public string Suit { get; set; }
    public int Value { get; set; }
    public int CardId { get; }
    private List<Card> _instances = new() { };

    public Card(string suit, int value)
    {
      Suit = suit;
      Value = value;
      _instances.Add(this);
      CardId = _instances.Count;
    }
    public string Name()
    {
      return "";
    }
  }

}