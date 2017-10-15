using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Stack
    {
        private StackImplementation impl;

        public Stack(string s)
        {
            if (s == "array")
            {
                impl = new StackArray();
            }
            else if (s == "list")
            {
                impl = new StackList();
            }
            else
            {
                Console.WriteLine("Stack: unknown parameter");
            }
        }

        public Stack() : this("array") { }

        public virtual void Push(int val)
        {
            impl.Push(val);
        }

        public virtual int Pop()
        {
            return impl.Pop();
        }

        public virtual int Top()
        {
            return impl.Top();
        }

        public virtual bool IsEmpty()
        {
            return impl.IsEmpty();
        }

        public virtual bool IsFull()
        {
            return impl.IsFull();
        }
    }
}
