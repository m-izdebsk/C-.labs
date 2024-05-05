namespace CSLab;

internal class P1_4
{
    public void main(string[] args)
    {
        //Napisz program, który sprawdza, czy podana liczba naturalna jest parzysta. 
        Console.WriteLine("Program 1.4:\nEnter a number:");

        var intput = Console.ReadLine();
        Console.WriteLine("Entered: " + intput + " number");

        //ternary operator
        string GetWeatherDisplay(string number)
        {
            return int.Parse(number) % 2 == 0 ? "Parzysta" : "Nieparzysta";
        }

        Console.WriteLine("Wprowadzona liczba jest:" + GetWeatherDisplay(intput));
    }
}