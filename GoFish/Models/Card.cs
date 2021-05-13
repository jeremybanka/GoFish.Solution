using System.Collections.Generic;

namespace GoFish.Models
{
  public class Card
  {
    private static readonly Dictionary<int, string> cardTiers = new()
    {
      { 1, "Ace" },
      { 2, "Two" },
      { 3, "Three" },
      { 4, "Four" },
      { 5, "Five" },
      { 6, "Six" },
      { 7, "Seven" },
      { 8, "Eight" },
      { 9, "Nine" },
      { 10, "Ten" },
      { 11, "Jack" },
      { 12, "Queen" },
      { 13, "King" }
    };
    public string Suit { get; set; }
    public int Value { get; set; }
    public int CardId { get; }
    public string Name { get; }
    private List<Card> _instances = new() { };

    public Card(string suit, int value)
    {
      Suit = suit;
      Value = value;
      string tier = cardTiers[value];
      Name = $"{tier} of {suit}";
      _instances.Add(this);
      CardId = _instances.Count;
    }

  }
}