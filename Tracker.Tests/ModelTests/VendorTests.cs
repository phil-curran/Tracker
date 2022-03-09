using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    // test AddNewVendor()
    [TestMethod]
    public void AddNewVendor()
    {
      // Arrange
      Vendor newVendor = new Vendor("test name", "test description");
      // Act
      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    // test List<Vendor> GetAll()
    [TestMethod]
    public void GetAllVendors()
    {
      // Arrange
      Vendor.ClearAll();
      Vendor newVendorOne = new Vendor("test name 1", "test description 1");
      Vendor newVendorTwo = new Vendor("test name 2", "test description 2");
      // Act
      List<Vendor> newList = new List<Vendor> { newVendorOne, newVendorTwo };
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEquivalent(newList, result);
    }

    // test Vendor Find(int searchId)
    [TestMethod]
    public void FindOrGetVendorID()
    {
      // Arrange
      Vendor.ClearAll();
      Vendor newVendorOne = new Vendor("test name 1", "test description 1");
      // Act
      Vendor result = Vendor.Find(1);
      // Assert
      Assert.AreEqual(result.Name, newVendorOne.Name);
    }

  }
}