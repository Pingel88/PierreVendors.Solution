using System.Collections.Generic;

namespace PierreVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}