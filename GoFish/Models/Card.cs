using System.Collections.Generic;

namespace GoFish.Models
{
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