using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class AdditionHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.GetOperation == Operation.ADDITION) {
                Console.WriteLine( request.NumberOne + request.NumberTwo);
            }
            else
            {
                ForwardRequest(request);
            }
        }

    }
}
