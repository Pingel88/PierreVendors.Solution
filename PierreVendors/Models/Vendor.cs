using System.Collections.Generic;

namespace PierreVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
    }

    public static List<Vendor> GetAll()
    {
      Vendor fakeVendor = new Vendor ("fail", "fail");
      List<Vendor> fail = new List<Vendor> { fakeVendor };
      return fail;
    }
  }
}