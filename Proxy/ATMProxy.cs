using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ATMProxy : IATMData
    {
        IATMData atmachine;

        public ATMProxy()
        {
            atmachine = new ATMMachine();
        }

        public string getATMState()
        {
            return atmachine.getATMState();
        }

        public double GetCashInMachine()
        {
            return atmachine.GetCashInMachine();
        }
    }
}
