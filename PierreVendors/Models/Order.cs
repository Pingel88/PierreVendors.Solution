using System.Collections.Generic;
namespace PierreVendors.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public string Date { get; }
    public int Id { get; }
    private static List<Order> _instances = new List <Order> {};

    public Order (string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = 1;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}