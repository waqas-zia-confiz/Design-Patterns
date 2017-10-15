using DesignPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Iterator
{
    public class OlivesPizza : IEnumerable
    {
        LinkedList<PizzaInfo> pizzaList;

        public OlivesPizza() {
            pizzaList = new LinkedList<PizzaInfo>();
            pizzaList.AddFirst(new PizzaInfo("Fajita"));
            pizzaList.AddFirst(new PizzaInfo("Supreme"));
            pizzaList.AddFirst(new PizzaInfo("OliveSmoke"));
        }
        public IEnumerator GetPizzaList() {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return pizzaList.GetEnumerator();
        }
    }
}
