namespace CSLab.Lab7.Zad12_1;

public class Stos<T> : IKolejkowate<T>
{
    private readonly Stack<T> list = new();

    public void push(T element)
    {
        list.Push(element);
    }

    public T pop()
    {
        if (list.Count == 0)
            Console.WriteLine("Stos pusty");
        else
            return list.Pop();
        throw new ApplicationException("Stos pusty");
    }

    public T? top()
    {
        if (list.Count == 0)
            Console.WriteLine("Stos pusty");
        else
            return list.Peek();

        throw new ApplicationException("Stos pusty");
    }
}