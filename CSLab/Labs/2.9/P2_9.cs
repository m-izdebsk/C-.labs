namespace CSLab.Labs._2._9;

internal class P2_9
{
    public void main(string[] args)
    {
        var group = new Grupa[1];
        var kurs = new Kurs("Cybersecurity", 600, new Osoba("Ipp.", "Sec"), group);
        kurs.printData();
    }
}