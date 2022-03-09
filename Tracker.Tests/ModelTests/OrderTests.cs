using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {

      // string title, string description, int price, string date, string notes     
      string title = "test order";
      string description = "test description";
      int price = 100;
      string date = "01/01/2020";
      string notes = "test notes";
      Order newOrder = new Order(title, description, price, date, notes);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }





  }
}