using System;
using PizzaStore.Domain.Models;
using System.Collections.Generic;

namespace PizzaTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring order
            Order o = new Order();

            Console.WriteLine("Here are the menu options.");
            Console.WriteLine("Press 1 to add a pizza to the order.");
            Console.WriteLine("Press 2 to view the order history.");
            
            int x = Convert.ToInt32(Console.ReadLine());

            if(x == 1)
            {
                //needed string variables to design pizza
                string c, s, loc;
                List<Topping> t = new List<Topping>();

                Console.WriteLine("Enter the store you'd like to order from: ");
                loc = Console.ReadLine();

                //crust
                Console.WriteLine("Select your crust.");
                Console.WriteLine("Press 1 for thin crust.");
                Console.WriteLine("Press 2 for thick crust.");
                Console.WriteLine("Press 3 for stuffed crust.");

                int cr = Convert.ToInt32(Console.ReadLine());

                if(cr == 1)
                {
                    c = "thin";
                }

                else if (cr == 2)
                {
                    c = "thick";
                }

                else
                {
                    c = "stuffed";
                }

                Console.WriteLine("Select your toppings.");
                Console.WriteLine("Select 1 for pepperoni.");
                Console.WriteLine("Select 2 for onions.");
                Console.WriteLine("Select 3 for black olives.");
                Console.WriteLine("Select 4 for tomatoes.");
                Console.WriteLine("Select 5 for banana peppers.");
                Console.WriteLine("Select 6 to proceed once you've selected two toppings.");
                
                //minimum number of toppings
                for(int count = 0; count < 2; count++)
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if(choice == 1)
                    {
                        t.Add(new Topping("pepperoni"));
                    }

                    else if(choice == 2)
                    {
                        t.Add(new Topping("onions"));
                    }
                    else if(choice == 3)
                    {
                        t.Add(new Topping("black olives"));
                    }
                    else if(choice == 4)
                    {
                        t.Add(new Topping("tomatoes"));
                    }
                    else if(choice == 5)
                    {
                        t.Add(new Topping("banana peppers"));
                    }
                }

                //additional toppings
                int toppingsToGo = 1;

                while(toppingsToGo < 4)
                {
                    int choiceOne = Convert.ToInt32(Console.ReadLine());

                    if(choiceOne == 1)
                    {
                        t.Add(new Topping("pepperoni"));
                    }

                    else if(choiceOne == 2)
                    {
                        t.Add(new Topping("onions"));
                    }
                    else if(choiceOne == 3)
                    {
                        t.Add(new Topping("black olives"));
                    }
                    else if(choiceOne == 4)
                    {
                        t.Add(new Topping("tomatoes"));
                    }
                    else if(choiceOne == 5)
                    {
                        t.Add(new Topping("banana peppers"));
                    }

                    else
                    {
                        toppingsToGo += 3;
                    }
                }

                //done with toppings

                //size
                Console.WriteLine("Select your size.");
                Console.WriteLine("Press 1 for small.");
                Console.WriteLine("Press 2 for medium.");
                Console.WriteLine("Press 3 for large.");

                int choiceTwo = Convert.ToInt32(Console.ReadLine());

                if(choiceTwo == 1)
                {
                    s = "small";
                }

                else if(choiceTwo == 2)
                {
                    s = "medium";
                }

                else
                {
                    s = "large";
                }
                
                //order
                int sum = 0;
                for(int counter = 0; counter < o.Pizzas.Count; counter++)
                {
                    sum += o.Pizzas[counter].price;
                }
                if(sum > 250)
                {
                    o.addPizza(c, s, t);
                    Console.WriteLine("Exceeded limit per order!");
                }

                else
                {
                    Console.WriteLine("Price: $" + sum);
                }
            }

            if(x == 2)
            {
                for(int ab = 0; ab < o.Pizzas.Count; ab++)
                {
                    Console.WriteLine(o.Pizzas[ab].size + " pizza with " + o.Pizzas[ab].crust + " crust with the following toppings:");
                    for(int xy = 0; xy < o.Pizzas[ab].Toppings.Count; xy++)
                    {
                        Console.WriteLine(o.Pizzas[ab].Toppings[xy]);
                    }
                }
            }
        }
    }
}
