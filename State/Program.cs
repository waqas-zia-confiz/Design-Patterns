using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atmMachine = new ATMMachine();

            atmMachine.insertCard();

            atmMachine.ejectCard();

            atmMachine.insertCard();

            atmMachine.insertPin(1234);

            atmMachine.requestCash(2000);

            atmMachine.insertCard();

            atmMachine.insertPin(1234);

            atmMachine.requestCash(30000);
        }
    }
}
