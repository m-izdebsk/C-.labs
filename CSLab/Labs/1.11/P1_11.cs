namespace CSLab;

internal class P1_11
{
    private readonly Dictionary<string, int> wartosciKart = new()
    {
        { "as", 11 }, { "dziesiatka", 10 }, { "krol", 4 }, { "dama", 3 }, { "walet", 2 }, { "dziewiatka", 0 }
    };

    public void main(string[] args)
    {
        //Gracz podaje słowne wartości pięciu otrzymanych kart.
        //Program liczy sumaryczną wartość tych kart, przyjmując, że: as = 11 pkt., dziesiątka = 10 pkt., król = 4 pkt., dama = 3 pkt., walet = 2 pkt., dziewiątka = 0 pkt.
        // b) Wykonaj to samo zadanie losując dowolnie podaną liczbę kart.
        Console.WriteLine("Black jack game: podaj karty");
        var line = Console.ReadLine();
        Console.WriteLine(line);
        var suma = 0;
        for (var i = 0; i < line.Split().Length; i++)
        {
            var karta = line.Split()[i];
            var value = wartosciKart[karta];
            suma += value;
        }

        Console.WriteLine("Karty maja pkt:" + suma + " pkt.");
        Console.WriteLine("Kasjer : ");
        Console.WriteLine("Podaj liczbe kart");
        var liczbakart = decimal.Parse(Console.ReadLine());
        decimal sumakrupiera = 0;
        for (var i = 0; i < liczbakart; i++)
        {
            var keys = new List<string>(wartosciKart.Keys);
            var rand = new Random();
            var karta = keys[rand.Next(keys.Count)];
            Console.WriteLine(karta);
            sumakrupiera = sumakrupiera + obliczwartosckart(karta);
        }

        Console.WriteLine("Suma krupiera:" + sumakrupiera);
    }


    private decimal obliczwartosckart(string line)
    {
        //zmienna z suma kart
        var suma = 0;

        for (var i = 0; i < line.Split().Length; i++)
        {
            var karta = line.Split()[i];
            //odczyt wartosci z mapy/dictionary za pomoca string-a
            var value = wartosciKart[karta];
            //dodawanie wyniku
            suma += value;
        }

        return suma;
    }
}