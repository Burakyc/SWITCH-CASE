# SWITCH-CASE
using System;

namespace SWITCH_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime. Now. Month;
            //Expression
            switch (month){
            case 1:

            Console.WriteLine("Ocak ayındasiniz!");
            break;
            case 2:
            Console.WriteLine("Subat ayındasiniz!");
            break;
            case 4:

            Console.WriteLine("Nisan ayındasiniz!");
            break;
            case 3:
            Console.WriteLine("mart ayındasiniz!");

            break;
            default:

            Console.WriteLine("Yanlis veri girisi");
            break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:

                Console.WriteLine("Kis ayindasiniz!");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("ilkbahar ayindasaniz!");

                break;
                case 6:
                case 7:
                case 8:

                Console.WriteLine("Yaz ayındasiniz!");
                break;
                default:
                break;
                case 9:

                case 10:
                case 11:
                Console.WriteLine("Yaz ayındasinız!");
                break;
            }


        }
    }
}
