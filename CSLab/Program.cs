using CSLab.Labs._2._7;
using CSLab.Labs._2._9;
using CSLab.Labs._3._1;
using CSLab.Labs._3._2;
using CSLab.Labs._3._3;
using CSLab.Labs._3._5;
using CSLab.Labs._3._6;

namespace CSLab.Labs._3._4
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
                    new P1_3().main(args);
                    break;
                case "1.4":
                    new P1_4().main(args);
                    break;
                case "1.5":
                    new P1_5().main(args);
                    break;
                case "1.6":
                    new P1_6().main(args);
                    break;
                case "1.7":
                    new P1_7().main(args);
                    break;
                case "1.8":
                    new P1_8().main(args);
                    break;
                case "1.9":
                    new P1_9().main(args);
                    break;
                case "1.10":
                    new P1_10().main(args);
                    break;
                case "1.11":
                    new P1_11().main(args);
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
                    
                case "2.5":
                    new P2_5().main(args);

                break;           
                    

                case "2.6":
                    new P2_6().main(args);
                break;

                case "2.7":
                    new P2_7().main(args);
                break;

                case "2.8":
                    new P2_8().main(args);
                break;
                    
                case "2.9":
                    new P2_9().main(args);
                break;
                    
                case "2.10":
                    new P2_10().main(args);
                break;
                    
                case "2.11":
                    new P2_11().main(args);
                break;
                    

                case "2.12":
                    new P2_12().main(args);
                break;
                    
                case "3.1":
                    new P3_1().main(args);
                break;
                    
                case "3.2":
                    new P3_2().main(args);
                break;
                    
                case "3.3":
                    new P3_3().main(args);
                break;
                                        
                case "3.4":
                    new P3_4().main(args);
                break;
                    
                                                        
                case "3.5":
                    new P3_5().main(args);
                break;
                    
                                                        
                case "3.6":
                    new P3_6().main(args);
                break;

                default:
                    new Exception();
                break;

            }


        }
    }
}
