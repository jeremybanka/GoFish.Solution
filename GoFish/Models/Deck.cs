using System;
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
    public List<Card> Cards { get; set; }
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

    public void Shuffle()
    {
      List<Card> unshuffledCards = new(Cards);
      List<Card> shuffledCards = new();
      Random random = new();
      while (shuffledCards.Count <= 52)
      {
        Card anyCard = unshuffledCards[random.Next(unshuffledCards.Count)];
        shuffledCards.Add(anyCard);
        unshuffledCards.Remove(anyCard);
      }
      Cards = shuffledCards;
    }

  }
}
