namespace Bridge
{
    class StackArray : StackImplementation
    {
        private int[] items;
        private int total = -1;

        public StackArray()
        {
            this.items = new int[10];
        }

        public StackArray(int items)
        {
            this.items = new int[items];
        }

        public bool IsEmpty()
        {
            return total == -1;
        }

        public bool IsFull()
        {
            return total == items.Length - 1;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return items[total--];
        }

        public void Push(int i)
        {
            if (!IsFull())
            {
                items[++total] = i;
            }
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return items[total];
        }
    }
}