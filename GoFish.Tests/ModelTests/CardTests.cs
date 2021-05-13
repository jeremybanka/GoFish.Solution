using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class CardTests
  {
    [TestMethod]
    public void CardCtor_CreatesInstanceOf_Card()
    {
      Card c = new("Clubs", 13);
      Assert.AreEqual(typeof(Card), c.GetType());
    }
    [TestMethod]
    public void Name_Returns_StringNameOfCard()
    {
      //Arrange aka Expected
      string expectedName = "King of Clubs";

      //Act aka Actual/Returned
      Card c = new("Clubs", 13);
      string result = c.Name;

      //Assert aka Expected vs. Actual
      Assert.AreEqual(expectedName, result);
    }
  }
}