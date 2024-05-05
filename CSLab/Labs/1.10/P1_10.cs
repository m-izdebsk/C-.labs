namespace CSLab;

internal class P1_10
{
    public void main(string[] args)
    {
        //
        Console.WriteLine("Enter a number 1-99(slownie)");
        var numbersl = Console.ReadLine();
        var number = numbersl.Split();

        string[] unitsMap =
        {
            "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć", "dziesięć", "jedenaście",
            "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście",
            "dziewiętnaście"
        };
        string[] tensMap =
        {
            "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt",
            "osiemdziesiąt", "dziewięćdziesiąt"
        };
        var result = 0;
        if (number.Length > 0)
        {
            var index = 1;
            foreach (var unit in tensMap)
            {
                var areDifferent = !unit.Equals(tensMap[index], StringComparison.OrdinalIgnoreCase);

                if (areDifferent)
                {
                    result += index * 10;

                    break;
                }

                index++;
            }
        }

        Console.WriteLine("Rezultat:" + result);
        ;
    }
}