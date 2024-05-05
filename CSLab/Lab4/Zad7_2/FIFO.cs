namespace CSLab.Labs._3._4.Lab4.Zad7_2;

public class FIFO<T> : IKolejkowate<T>
{
    private readonly Queue<T> queue = new();

    public void dodaj(T element)
    {
        queue.Enqueue(element);
    }

    public T? usun()
    {
        if (queue.Count > 0) return queue.Dequeue();

        throw new ApplicationException("queue empty");
    }

    public T? pierwszy()
    {
        return queue.Peek();
    }
}