using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public int VendorId { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      VendorId = _instances.Count;
      Orders = new List<Order> {};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int vendorId)
    {
      return _instances[vendorId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}

