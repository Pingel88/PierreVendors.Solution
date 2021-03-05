using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendors.Models;

namespace PierreVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Bread";
      Order newOrder = new Order();
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

  }
}