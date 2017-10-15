using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{

    public class PizzaInfo
    {

        private string _pizzaName;

        public PizzaInfo(string pizzaName)
        {
            this._pizzaName = pizzaName;
        }

        public string PizzaName { get => _pizzaName; }
    }
}
