using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SubtractionHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.GetOperation == Operation.SUBTRACTION)
            {
                Console.WriteLine(request.NumberOne - request.NumberTwo);
            }
            else
            {
                ForwardRequest(request);
            }
        }
    }
}
