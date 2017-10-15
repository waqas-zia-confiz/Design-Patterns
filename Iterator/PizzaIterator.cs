using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator
{
    public interface PizzaIterator
    {
        System.Collections.IEnumerator GetEnumerator();
    }
}
