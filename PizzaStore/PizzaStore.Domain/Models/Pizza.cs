using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
      public int price;
      public List<Topping> Toppings;
      public Crust crust;
      public Size size;
        public Pizza()
        {
            Toppings = new List<Topping>();
            crust = new Crust("thin");
            size = new Size("small");
            price = 5;
        }

        public Pizza(List<Topping> t, Crust c, Size s)
        {
          Toppings = t;
          crust = c;
          size = s;
          price = 5;

          price += t.Count * 2;
          if(c.crustType == "thin")
          {
            price += 3;
          }

          else if(c.crustType == "thick")
          {
            price += 5;
          }

          else
          {
            price += 7;
          }

          if(s.size == "small")
          {
            price = price * 2;
          }

          else if(s.size == "medium")
          {
            price = price * 3;
          }

          else
          {
            price = price * 4;
          }
        }
    }
}