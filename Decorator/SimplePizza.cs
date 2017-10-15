using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimplePizza : IPizza
    {
        public double GetCost()
        {
            return 200;
        }

        public string GetDescription()
        {
            return "Plain pizza";
        }

        public string GetDough()
        {
            return "Thin Dough";
        }
    }
}
