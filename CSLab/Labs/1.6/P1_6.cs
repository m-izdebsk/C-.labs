using CSLab.Labs._1._6;

namespace CSLab;

internal class P1_6
{
    public void main(string[] args)
    {
        //wczytanie wagi
        Console.Write("Podaj wage w kg: ");
        //Wczytanie danych z linii polecen args[0] i args[1]
        var waga = decimal.Parse(Console.ReadLine());


        Console.WriteLine("Podaj wzrost w metrach");
        var wzrost = decimal.Parse(Console.ReadLine());

        Console.WriteLine("obliczanie BMI:");
        BmiCalcService.printBmiStatus(BmiCalcService.calculateBmi(waga, wzrost));
    }
}