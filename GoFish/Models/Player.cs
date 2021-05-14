using System.Collections.Generic;

namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; set; }
    public string Codeword { get; }
    public bool Ready { get; set; }
    private static readonly List<Player> _allPlayers = new() { };
    public List<Card> _hand = new() { };

    public Player(string name, string codeword)
    {
      Name = name;
      Codeword = codeword;
      Ready = false;
      _allPlayers.Add(this);
    }
  }
}