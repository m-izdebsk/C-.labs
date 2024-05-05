using System.Collections;

namespace CSLab;

internal class P2_4
{
    public decimal randUniqueNumber(int start, int end, ArrayList values)
    {
        var random = new Random();
        var randomNumber = random.Next(start, end);
        if (values.Contains(randomNumber))
            return randUniqueNumber(start, end, values);
        return randomNumber;
    }

    public void main(string[] args)
    {
        //Wylosuj 5 liczb całkowitych w zakresie od 0 do 1000.
        //Następnie zbuduj tablicę, której wiersze będą tablicami
        //przechowującymi kolejne cyfry każdej z liczb.
        //
        //Użyj możliwie najmniej elementów tablicy.
        var randoms = new ArrayList();
        var list = new object[5];
        for (var i = 0; i < 5; i++)
        {
            var random = randUniqueNumber(1, 5000, randoms);
            var newdecimal = new decimal[random.ToString().Length];
            for (var k = 0; k < random.ToString().Length; k++)
            {
                var vkey = random.ToString()[k];
                newdecimal[k] = decimal.Parse(vkey.ToString());
            }

            list[i] = newdecimal;
        }

        foreach (var item in list)
        {
            foreach (var value in (decimal[])item) Console.Write(value);
            Console.WriteLine();
        }
    }
}