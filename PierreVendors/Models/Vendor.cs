using System.Collections.Generic;

namespace PierreVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> Orders { get; }

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}