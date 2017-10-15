using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ATMMachine : IATMData
    {
        private double _cashInMachine = 200000;
        private string atmState;
        public static readonly string ATM_STATE_WORKING = "Working";
        public static readonly string ATM_STATE_MAINTAINACE = "Under Maintainace";

        public ATMMachine()
        {
            atmState = ATM_STATE_WORKING;
            Console.WriteLine("Initializing ATM machine");
        }
        public void StartMaintainace() {
            atmState = ATM_STATE_MAINTAINACE;
            Console.WriteLine("Starting Maintainance");
        }
        public void StartWorking() {
            atmState = ATM_STATE_WORKING;
            Console.WriteLine("MAchine Working");
        }
        public string getATMState()
        {
            return atmState;
        }
        public double GetCashInMachine()
        {
            return _cashInMachine;
        }
        public void SetCashInATMMachine(double cash) {
            this._cashInMachine = cash;
            Console.WriteLine("Setting Cash in ATM Machine. " + cash);
        }
    }
}
