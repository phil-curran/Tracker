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
      string title = "test order";
      string description = "test description";
      int price = 100;
      string date = "01/01/2020";
      string notes = "test notes";
      Order newOrder = new Order(title, description, price, date, notes);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


    // test List<Order> GetAll()
    [TestMethod]
    public void GetAllOrders_NonEquivalentOrders()
    {
      // Arrange
      Order newOrderOne = new Order("test order 1", "test description 1", 100, "01/01/2020", "test notes 1");
      Order newOrderTwo = new Order("test order 2", "test description 2", 200, "02/02/2020", "test notes 2");
      // Act
      List<Order> newList = new List<Order> { newOrderOne, newOrderTwo };
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreNotEquivalent(newList, result);
    }

    // test List<Order> GetAll()
    [TestMethod]
    public void GetAllOrders_EquivalentOrders()
    {
      // Arrange
      Order.ClearAll();
      Order newOrderOne = new Order("test", "test", 1, "test", "test");
      Order newOrderTwo = new Order("test", "test", 1, "test", "test");
      // Act
      List<Order> newList = new List<Order> { newOrderOne, newOrderTwo };
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEquivalent(newList, result);
    }

    // string title, string description, int price, string date, string notes    

    // test ClearAll()
    [TestMethod]
    public void ClearAllOrders()
    {
      // Arrange
      Order newOrder = new Order("test order 1", "test description 1", 100, "01/01/2020", "test notes 1");
      List<Order> newList1 = new List<Order> { newOrder };
      List<Order> newList2 = new List<Order> { };

      // Act
      Order.ClearAll();

      // Assert
      CollectionAssert.AreNotEquivalent(newList1, newList2);
    }

    // test Order Find(id)
    [TestMethod]
    public void TestName3()
    {
      // Arrange
      Order.ClearAll();
      Order newOrder = new Order("test order 1", "test description 1", 100, "01/01/2020", "test notes 1");
      // Act
      int orderId = newOrder.Id + 1;
      int testOrderId = 1;

      // Assert
      Assert.AreEqual(orderId, testOrderId);
    }

  }
}