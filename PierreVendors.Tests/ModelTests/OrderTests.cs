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
      Order newOrder = new Order("Bread", "10 loaves of bread", 50, "03/05/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Bread";
      Order newOrder = new Order(title, "10 loaves of bread", 50, "03/05/2021");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "10 loaves of bread";
      Order newOrder = new Order("Bread", description, 50, "03/05/2021");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      int price = 50;
      Order newOrder = new Order("Bread", "10 loaves of bread", price, "03/05/2021");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string date = "03/05/2021";
      Order newOrder = new Order("Bread", "10 loaves of bread", 50, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

  }
}