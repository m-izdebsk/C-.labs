using CSLab.Lab3.zad4._1;
using CSLab.Lab3.Zad4._2;
using CSLab.Lab3.Zad4._3;
using CSLab.Lab3.Zad4._4;
using CSLab.Lab3.Zad4._5;
using CSLab.Lab3.Zad5_1;
using CSLab.Lab3.Zad5_2;
using CSLab.Lab3.Zad5_3;
using CSLab.Lab4.Zad6_1;
using CSLab.Lab4.Zad6_2;
using CSLab.Lab4.Zad6_3;
using CSLab.Lab4.Zad7_1;
using CSLab.Lab4.Zad7_2;
using CSLab.Lab5.Zad8_1;
using CSLab.Lab5.Zad8_2;
using CSLab.Lab5.Zad8_3;
using CSLab.Lab5.Zad8_4;
using CSLab.Lab5.Zad9_1;
using CSLab.Lab5.Zad9_2;
using CSLab.Lab5.Zad9_3;
using CSLab.Lab6.Zad10_1;
using CSLab.Lab6.Zad11_1;
using CSLab.Lab7.Zad12_1;
using CSLab.Lab7.Zad13_1;
using CSLab.Lab7.Zad14_1;
using CSLab.Labs._2._6;
using CSLab.Labs._2._7;
using CSLab.Labs._2._9;
using CSLab.Labs._3._1;
using CSLab.Labs._3._2;
using CSLab.Labs._3._3;
using CSLab.Labs._3._5;
using CSLab.Labs._3._6;
using CSLab.Narzedzia.Zad1;
using CSLab.Narzedzia.Zad2;
using CSLab.Spr1.Cw1;
using CSLab.Spr1.Cw2;
using CSLab.Spr2.Zad2_1;
using CSLab.Spr2.Zad2_2;
using CSLab.Zad2._1;

namespace CSLab.Labs._3._4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Get text number in N.N format e.g. 1.1 :");
        var name = Console.ReadLine();

        switch (name)
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
            case "a4.1":
                new ZA4_1().main(args);
                break;
            case "a4.2":
                new ZadA4_2().main(args);
                break;




            case "4.1":

                new Zad4_1().main(args);
                break;






            case "4.2":

                new Zad4_2().main(args);
                break;



            case "4.3":

                new Zad4_3().main(args);
                break;




            case "4.4":
                new Zad4_4().main(args);
                break;
            case "4.5":
                new Zad4_5().main(args);
                break;



            case "5.1":
                new Zad5_1().main(args);
                break;

            case "5.2":
                new Zad5_2().main(args);
                break;

            case "5.3":
                new Zad5_3().main(args);
                break;
            case "6.1":
                new Zad6_1().main(args);
                break;
            case "6.2":
                new Zad6_2().main(args);
                break;
            case "6.3":
                new Zad6_3().main(args);
                break;
            case "7.1":
                new Zad7_1().main(args);
                break;
            case "7.2":
                new Zad7_2().main(args);
                break;
            case "spr1":
                new Sprawdzian1().main(args);
                break; 
            case "spr2":
                new Cwiczenie2().main(args);
                break;
                case "spr3":
                new Zad2_1().main(args);
                break;    
            case "spr4":
                new Zad2_2().main(args);
                break;

            case "8.1":
                new Zad8_1().main(args);
                break;
            case "8.2":
                new Zad8_2().main(args);
                break;
            case "8.3":
                new Zad8_3().main(args);
                break;
            case "8.4":
                new Zad8_4().main(args);
                break;
            case "9.1":
                new Zad9_1().main(args);
                break;            
            case "9.2":
                new Zad9_2().main(args);
                break;
            case "9.3":
                new Zad9_3().main(args);
                break;            
            case "10.1":
                new Zad10_1().main(args);
                break;            
            case "11.1":
                new Zad11_1().main(args);
                break;     
            case "12.1":
                new Zad12_1().main(args);
                break;
            case "13.1":
                new Zad13_1().main(args);
                break;            
            case "14.1":
                new Zad14_1().main(args);
                break;           
            case "s2.1":
                new Spr2_1().main(args);
                break;

            default:
                new Exception();
                break;
        }
    }
}