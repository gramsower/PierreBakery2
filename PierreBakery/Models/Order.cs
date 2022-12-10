using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title)
    {
      Title = title;
      _instances.Add(this);
    }
  }
}