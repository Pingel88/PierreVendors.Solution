using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendors.Models;

namespace PierreVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Brad's Butter Emporium", "Typically buys a lot of bread to butter");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Brad's Butter Emporium";
      Vendor newVendor = new Vendor(name, "Typically buys a lot of bread to butter");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Typically buys a lot of bread to butter";
      Vendor newVendor = new Vendor("Brad's Butter Emporium", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      Vendor newVendorA = new Vendor("Brad's Butter Emporium", "Typically buys a lot of bread to butter");
      Vendor newVendorB = new Vendor("Sammy's Sandwiches", "Frequently purchases hoagie rolls");
      List<Vendor> newList = new List<Vendor> { newVendorA, newVendorB };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor("Brad's Butter Emporium", "Typically buys a lot of bread to butter");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}