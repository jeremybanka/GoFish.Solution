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
      Card c = new("Club", 3);
      Assert.AreEqual(typeof(Card), c.GetType());
    }
  }
}