using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class DivisionHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.GetOperation == Operation.DIVISION)
            {
                if (request.NumberTwo != 0) 
                    Console.WriteLine(request.NumberOne / request.NumberTwo);
                else
                    Console.WriteLine("Cannot Divide By Zero");

            }
            else
            {
                ForwardRequest(request);
            }
        }
    }
}
