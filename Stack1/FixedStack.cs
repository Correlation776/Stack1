namespace Stack1;

public struct FixedStack<T>
{
    private T[] items;
    private int current = -1;

    public FixedStack(int length)
    {
        items = new T[length];
    }

    public void Push(T item)
    {
        if (current == items.Length - 1)
        {
            throw new InvalidOperationException("Stack is full!");
        }
        
        items[++current] = item;
    }

    public T Pop()
    {
        if (current == -1)
        {
            throw new InvalidOperationException("Stack is empty!");
        }

        return items[current--];
    }

    public T Peek()
    {
        if (current == -1)
        {
            throw new InvalidOperationException("Stack is empty!");
        }

        return items[current];
    }
}