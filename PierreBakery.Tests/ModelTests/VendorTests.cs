using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
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
      Vendor newVendor = new Vendor("Julie\'s pie shoppe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      //Arrange
      string vendorName = "Julie\'s Pie Shoppe";
      Vendor newVendor = new Vendor(vendorName);

      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Julie\'s Pie Shoppe";
      Vendor newVendor = new Vendor(vendorName);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      //Arrange
      string vendor01 = "Julie\'s Pie Shoppe";
      string vendor02 = "Coffee Cabana";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
     }

     [TestMethod]
     public void Find_ReturnsCorrectVendor_Vendor()
     {
      //Arrange
      string vendor01 = "Julie\'s Pie Shoppe";
      string vendor02 = "Coffee Cabana";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
     }

     [TestMethod]
     public void AddOrder_AssociatesOrderWithVendor_OrderList()
     {
      //Arrange.
      string vendor01 = "Julie\'s Pie Shoppe";
      string vendor02 = "Coffee Cabana";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      Order newOrder = new Order("Julie\'s Pie Shoppe", "test order", "10", "4", "01/01/01");
      List<Order> newList = new List<Order> { newOrder };
      newVendor1.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor1.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
     }
  }   
}