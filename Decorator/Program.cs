using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basicPizza = new SimplePizza();
            Console.WriteLine(basicPizza.GetDescription());

            basicPizza = new ExtraCheeseTopping(basicPizza);
            Console.WriteLine(basicPizza.GetDescription());
            basicPizza = new OlivesTopping(basicPizza);

            Console.WriteLine(basicPizza.GetDescription());

        }
    }
}
