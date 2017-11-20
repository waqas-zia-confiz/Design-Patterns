using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User john = new User("John");
            User lennon = new User("Lennon");

            john.sendMessage("Hi Lennon!");
            lennon.sendMessage("Hi John!");

        }
    }
}
