namespace Bridge
{
    public interface StackImplementation
    {
        void Push(int i);
        int Pop();
        int Top();
        bool IsEmpty();
        bool IsFull();
    }
}