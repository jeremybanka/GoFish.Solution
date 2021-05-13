using System.Collections.Generic;

namespace GoFish.Models
{
  public class Deck
  {
    private static readonly List<string> Suits = new()
    {
      "Spades",
      "Clubs",
      "Diamonds",
      "Hearts"
    };
    public List<Card> Cards { get; }
    public Deck()
    {
      Cards = new() { };
      foreach (string suit in Suits)
      {
        for (int i = 1; i <= 13; i++)
        {
          Cards.Add(new Card(suit, i));
        }
      }
    }


  }
}
