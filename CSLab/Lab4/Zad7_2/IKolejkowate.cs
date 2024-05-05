namespace CSLab.Labs._3._4.Lab4.Zad7_2;

public interface IKolejkowate<T>
{
    public void dodaj(T element);
    public T? usun();
    public T? pierwszy();
    
}