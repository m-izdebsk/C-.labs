namespace CSLab;

internal class P1_9
{
    public void main(string[] args)
    {
        //Napisz program, który dodaje n kolejnych liczb naturalnych  przy użyciu pętli. 
        //Zliczanie ma trwać dotąd dopóki suma nie przekroczy określonej granicy. 
        //Wówczas program ma skończyć działanie bez doliczenia tego składnika, który spowodował przekroczenie ustalonego progu.
        //Program powinien podać, ile składników policzył i ile wynosi suma.
        //Napisz trzykrotnie ten program -przy użyciu pętli for, while, do while.

        var maxValue = 100;
        var currentValue = 0;
        var step = 0;
        for (var i = 0; i < maxValue; i += step)
        {
            step++;
            currentValue = i;
        }

        Console.WriteLine("for:" + currentValue);
        currentValue = 0;
        step = 0;
        while (currentValue <= maxValue)
        {
            currentValue = currentValue + step;
            step++;
        }

        Console.WriteLine("do:" + (currentValue - step + 1));
        currentValue = 0;
        step = 0;
        do
        {
            currentValue += step;
            step++;
        } while (currentValue < maxValue);

        Console.WriteLine("do while:" + (currentValue - step + 1));
    }
}