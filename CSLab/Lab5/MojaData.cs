
namespace CSLab.Lab5
{
    public class MojaData
    {

        private DateTime data;

        public MojaData(DateTime data)
        {
            this.data = data;
        }

        //konwersja niejawna
        public static implicit operator int(MojaData mojaData)
        {
            TimeSpan interval = DateTime.Now - mojaData.data;
            return (int)(interval.TotalDays / 365);
        }
        //konwersja jawna
        public static explicit operator float(MojaData mojaData)
        {
            TimeSpan interval = DateTime.Now - mojaData.data;
            return (float)(interval.TotalDays / 365);
        }


    }
}
