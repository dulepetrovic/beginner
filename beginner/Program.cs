using System;

namespace beginner
{
    partial class MainClass
    {
        public static void Main(string[] args)
        {
            /* if conditional */

            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon");
            //}else
            //{
            //    Console.WriteLine("It's evening");
            //}


            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            var sezona = Season.Zima;

            /* switch */

            switch(sezona){
                case Season.Leto:
                    Console.WriteLine("Leto je");
                    break;
                case Season.Prolece:
                    Console.WriteLine("Sada je prolece");
                    break;
                case Season.Jesen:
                    Console.WriteLine("Sada je Jesen");
                    break;
                case Season.Zima:
                    Console.WriteLine("Sada je zima");
                    break;
                default:
                    Console.WriteLine("Nijedno od ponudjenih");
                    break;
            }

        }
    }
}
