namespace CSLab.Lab7.Zad12_1;


public interface IKolejkowate<T>
{
    public void push(T element);
    public T? pop();
    public T? top();
}