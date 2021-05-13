using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class DeckTests
  {
    [TestMethod]
    public void DeckCtor_CreatesInstanceOf_Deck()
    {
      Deck myDeck = new();
      Assert.AreEqual(typeof(Deck), myDeck.GetType());
    }

    [TestMethod]
    public void DeckCtor_CreatesValidCardNames_Strings()
    {
      // Arrange
      string aceSpades = "Ace of Spades";
      string twoClubs = "Two of Clubs";
      string queenDiamonds = "Queen of Diamonds";
      string kingHearts = "King of Hearts";

      // Act
      Deck d = new();
      string resultCard0 = d.Cards[0].Name;
      string resultCard14 = d.Cards[14].Name;
      string resultCard37 = d.Cards[37].Name;
      string resultCard51 = d.Cards[51].Name;

      Assert.AreEqual(aceSpades, resultCard0);
      Assert.AreEqual(twoClubs, resultCard14);
      Assert.AreEqual(queenDiamonds, resultCard37);
      Assert.AreEqual(kingHearts, resultCard51);
    }
  }
}