using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Quantity { get; set; }
    public string Date { get; set; }
    // public int OrdId { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, string price, string quantity, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Quantity = quantity;
      Date = date;
      _instances.Add(this);
      // OrdId = _instances.Count;
    }
  }
}