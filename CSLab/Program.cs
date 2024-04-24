namespace CSLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get text number in N.N format e.g. 1.1 :");
            string name = Console.ReadLine();

            switch(name)
            {
                case "1.1":
                    new P1_1().main(args);
                    break;
                case "1.2":
                    new P1_2().main(args);
                    break;
                case "1.3":
                    new P1_2().main(args);
                    break;
                case "1.4":
                    new P1_2().main(args);
                    break;
                case "1.5":
                    new P1_2().main(args);
                    break;
                case "1.6":
                    new P1_2().main(args);
                    break;
                case "1.7":
                    new P1_2().main(args);
                    break;
                case "1.8":
                    new P1_2().main(args);
                    break;
                case "1.9":
                    new P1_2().main(args);
                    break;
                case "1.10":
                    new P1_2().main(args);
                    break;
                case "1.11":
                    new P1_2().main(args);
                    break;
                case "2.1":
                    new P2_1().main(args);
                    break;

                case "2.2":
                    new P2_2().main(args);
                    break;

                case "2.3":
                    new P2_3().main(args);
                    break;

                case "2.4":
                    new P2_4().main(args);

                    break;

                default:
                    new Exception();
                    break;

            }


        }
    }
}
