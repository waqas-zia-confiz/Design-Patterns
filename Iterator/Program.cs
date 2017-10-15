using DesignPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            CheesePizza iterator = new CheesePizza();
            OlivesPizza olivesIterator = new OlivesPizza();

            Console.WriteLine("Best Pizzas with Cheese");
            foreach (PizzaInfo pizza in iterator) {
                Console.WriteLine(pizza.PizzaName);
            }
            Console.WriteLine("Best Pizzas with Olive");
            foreach (PizzaInfo pizza in olivesIterator)
            {
                Console.WriteLine(pizza.PizzaName);
            }
        }
    }
}
