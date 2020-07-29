using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class User
  {
    public Name name;
    public List<Order> orders;
    public List<Order> Orders { get; set; }
    public Name Name { get; set; }
  }
}