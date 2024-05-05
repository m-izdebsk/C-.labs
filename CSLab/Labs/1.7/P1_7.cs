namespace CSLab;

internal class P1_7
{
    public void main(string[] args)
    {
        if (args.Length == 0) throw new ArgumentException("Missing args");
        //wczytanie wagi
        Console.Write("Podaj wage w kg: ");
        //Wczytanie danych z linii polecen args[0] i args[1]
        var waga = decimal.Parse(args[0]);

        Console.WriteLine("Podaj wzrost w metrach");
        var wzrost = decimal.Parse(args[1]);

        Console.WriteLine("obliczanie BMI");
        Console.WriteLine(waga);
        var bmi = waga / (wzrost * wzrost);
        Console.WriteLine("Twoj BMI wynosi: " + bmi.ToString("0.##"));
    }
}