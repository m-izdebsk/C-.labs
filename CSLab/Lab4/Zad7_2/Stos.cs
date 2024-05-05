using System.Collections;

namespace CSLab.Labs._3._4.Lab4.Zad7_2;

public class Stos<T>: IKolejkowate<T>
{
    private Stack<T> list = new Stack<T>();
    public void dodaj(T element)
    {
        list.Push(element);
    }

    public T usun()
    {
         if (list.Count == 0)
        {
            Console.WriteLine("Stos pusty");
        }
        else
        {
            return list.Pop();
        }
        throw new ApplicationException("Stos pusty");

    }

    public T? pierwszy()
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Stos pusty");
        }else{

        return list.Peek();}

        throw new ApplicationException("Stos pusty");
    }
}