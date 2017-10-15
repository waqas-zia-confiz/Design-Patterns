using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OlivesTopping : ToppingDecorator
    {
        public OlivesTopping(IPizza simplePizza) : base(simplePizza)
        {
            Console.WriteLine("Adding Olives");
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Olives";
        }
        public override double GetCost()
        {
            return base.GetCost() + 50;
        }
    }
}
