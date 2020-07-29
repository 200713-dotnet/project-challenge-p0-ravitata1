using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas;
    public int price;
    public List<Pizza> Pizza { get; set; }
    public DateTime DateOrdered { get; set; }

    public Order()
    {
      Pizzas = new List<Pizza>();
    }
    
    public void CreatePizza()
    {
      Pizzas.Add(new Pizza());
    }

    public void addPizza(string c, string s, List<Topping> t)
    {
      Pizzas.Add(new Pizza(t, new Crust(c), new Size(s)));
    }

    public void increasePrice(int x)
    {
      price += x;
    }
  }
}