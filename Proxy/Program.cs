using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATM machine being used directly.
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("Using Machine directly");
            Console.WriteLine(atmMachine.getATMState());
            Console.WriteLine(atmMachine.GetCashInMachine());
            atmMachine.SetCashInATMMachine(50000);
            Console.WriteLine(atmMachine.GetCashInMachine());
            atmMachine.StartMaintainace();
            atmMachine.StartWorking();

            //ATM machine being used as a secure proxy to just get the cash present in machine and check the state.
            IATMData machine = new ATMProxy();
            Console.WriteLine("Using Proxy");
            machine.getATMState();
            machine.GetCashInMachine();

        }
    }
}
