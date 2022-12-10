
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    
   public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test order", "10", "4", "01/01/01");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Order newOrder = new Order("test", "test order", "10", "4", "01/01/01");
      Assert.AreEqual("test order", newOrder.Description);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      Order newOrder = new Order("test", "test order", "10", "4", "01/01/01");

      //Act
      string updatedDescription = "everything";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyOrderList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> { };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
