using DesignPattern.Iterator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class CheesePizza : IEnumerable
    {
        HashSet<PizzaInfo> pizzaList;

        public CheesePizza()
        {
            pizzaList = new HashSet<PizzaInfo>();
            pizzaList.Add(new PizzaInfo("Fajita"));
            pizzaList.Add(new PizzaInfo("Supreme"));
            pizzaList.Add(new PizzaInfo("Cheese Madness"));
        }
        public IEnumerator GetPizzaList()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return pizzaList.GetEnumerator();
        }
    }
}
