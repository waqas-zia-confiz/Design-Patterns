using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.GetHashCode());

            Singleton obj = Singleton.GetInstance();
            Console.WriteLine(obj.GetHashCode());
        }
    }
}
