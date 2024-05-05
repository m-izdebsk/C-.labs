using System.Diagnostics;

namespace CSLab.Labs._3._2;

internal class P3_2
{
    public void main(string[] args)
    {
        var product2 = new Produkt2("test", 12f, "kg", DateTime.Now, 23.0f);
        //Zdefiniuj indeksator pozwalający odwoływać się do pól obiektu przez klucz będący nazwą pola, np. p[“nazwa”]
        Debug.Assert(product2["nazwa"] == "test");
    }
}