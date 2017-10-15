namespace Bridge
{
    public class StackList : StackImplementation
    {
        private Node last;
        public bool IsEmpty()
        {
            return last == null;
        }

        public bool IsFull()
        {
            return false;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int ret = last.Value;
            last = last.Prev;
            return ret;
        }

        public void Push(int i)
        {
            if (last == null)
            {
                last = new Node(i);
            }
            else
            {
                last.Next = new Node(i);
                last.Next.Prev = last;
                last = last.Next;
            }
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return last.Value;
        }
    }
}