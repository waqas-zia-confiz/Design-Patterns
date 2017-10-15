using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ExtraCheeseTopping : ToppingDecorator
    {
        public ExtraCheeseTopping(IPizza simplePizza) : base(simplePizza)
        {
            Console.WriteLine("Adding Extra Cheese");
        }
        public override string GetDescription()
        {
            return base.GetDescription() +", Extra Cheese";
        }
        public override double GetCost()
        {
            return base.GetCost() + 50;
        }
    }
}
