using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class StackFIFO : Stack
    {
        private StackImplementation stackImpl = new StackList();

        public StackFIFO():base("array"){}

        public StackFIFO(String s) : base(s) { }

        public override int Pop()
        {
            while (!IsEmpty())
            {
                stackImpl.Push(base.Pop());
            }
            int ret = stackImpl.Pop();
            while (!stackImpl.IsEmpty())
            {
                Push(stackImpl.Pop());
            }
            return ret;
        }
    }
}
