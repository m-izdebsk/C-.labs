namespace CSLab;

internal class P1_3
{
    public void main(string[] args)
    {
        //Napisz program, który od podanej ceny netto i stawki VAT oblicza kwotę VAT i cenę brutto.
        //Np. cena netto 100 zł, stawka 22% daje kwotę VAT 22 zł i cenę brutto 122 zł. 
        //Wyświetlaj kwoty z dwoma miejscami po przecinku, wyświetlając dodawaj symbol waluty i znak  % (procent).
        Console.WriteLine("Program 1.3:\nIle zarabiasz netto na F/V?:");
        try
        {
            var netto = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ile % F/Vat?:");
            var vat = decimal.Parse(Console.ReadLine());
            var kwota = Math.Round(netto + netto * (vat / 100), 2);
            Console.WriteLine("Kwota brutto:" + kwota);
            Console.WriteLine("Kwota vat:" + vat + "%");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Wrong data!");
            main(args);
        }
    }
}