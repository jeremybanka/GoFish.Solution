using System.Collections.Generic;

namespace GoFish.Models
{
  public class Lobby
  {
    private static List<Player> _players = new() { };
    public static void AddPlayer(Player p)
    {
      _players.Add(p);
    }
    public static List<Player> GetAll() => _players;
  }

  public class Game
  {
    public Deck Pool { get; }

    public Game()
    {
      foreach (Player player in Lobby.GetAll())
      {
        if (!player.Ready) throw new();
      }
      Pool = new();
      Pool.Shuffle();
    }
  }
}