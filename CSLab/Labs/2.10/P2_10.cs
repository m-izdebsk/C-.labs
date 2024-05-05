namespace CSLab;

internal class P2_10
{
    public void main(string[] args)
    {
        var wektor = Labs.Wektor.zbudujWektor();
        wektor.show();
        var randomWektor = new Labs.Wektor(4, 1.0, 2.0);
        randomWektor.show();
    }
}