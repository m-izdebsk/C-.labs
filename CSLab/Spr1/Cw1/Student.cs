namespace CSLab.Spr1.Cw1
{
    public class Student : IOsoba, IComparable<Student>
    {
        //atrybut z interfejsu nazwa
        public string Nazwa { get; set; }
        
        public Student(string nazwa)
        {
            Nazwa = nazwa;
        }
        //metoda opisz 
        public void Opisz()
        {
            Console.WriteLine($"Student: {Nazwa}");
        }

        //implementacja komparatora, pomocna przy sortowaniu elementow
        public int CompareTo(Student other)
        {
            return string.Compare(this.Nazwa, other.Nazwa, StringComparison.Ordinal);
        }

      
    }
}
