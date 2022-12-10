
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests // : IDisposable
  {
    
   /* public void Dispose()
    {
      Order.ClearALL();
    }
*/
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test order", "10", "4", "01/01/01");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}
