using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ToppingDecorator : IPizza
    {
        protected IPizza simplePizza;

        public ToppingDecorator(IPizza simplePizza)
        {
            this.simplePizza = simplePizza;
        }

        public virtual double GetCost()
        {
            return simplePizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return simplePizza.GetDescription();
        }

        public virtual string GetDough()
        {
            return simplePizza.GetDough();
        }
    }
}
