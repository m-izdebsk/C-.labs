namespace CSLab;

internal class P1_2
{
    public void main(string[] args)
    {
        //Napisz program przeliczający km/h na m/s. Program prosi o podanie wartości w km/h, dokonuje przeliczenia i wypisuje tę wartość w m/s.
        Console.WriteLine("Enter km/h");
        try
        {
            var data = decimal.Parse(Console.ReadLine());
            var mps = data * 1000 / 3600;
            Console.WriteLine("m/s=" + mps);
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong data!");
            main(args);
        }
    }
}