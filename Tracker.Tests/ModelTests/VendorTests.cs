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

    // test List<Order> GetAll()
    [TestMethod]
    public void Test1()
    {
      // Arrange

      // Act

      // Assert

    }

    // test List<Order> GetAll()
    [TestMethod]
    public void Test2()
    {
      // Arrange

      // Act

      // Assert

    }

  }
}