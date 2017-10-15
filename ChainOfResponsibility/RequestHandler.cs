using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        protected void ForwardRequest(Request request)
        {
            Console.WriteLine("Forwarding request");
            if (successor != null)
                successor.HandleRequest(request);
        }
        public abstract void HandleRequest(Request request);
    }
}
