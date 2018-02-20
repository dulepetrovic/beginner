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

            //var sezona = Season.Zima;

            ///* switch */

            //switch(sezona){
            //    case Season.Leto:
            //        Console.WriteLine("Leto je");
            //        break;
            //    case Season.Prolece:
            //        Console.WriteLine("Sada je prolece");
            //        break;
            //    case Season.Jesen:
            //        Console.WriteLine("Sada je Jesen");
            //        break;
            //    case Season.Zima:
            //        Console.WriteLine("Sada je zima");
            //        break;
            //    default:
            //        Console.WriteLine("Nijedno od ponudjenih");
            //        break;
            //}


            /* for loop */

            //for (int i = 0; i < 10; i++)
            //{
            //    if(i%2 == 0){
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            /* foreach petlja */

            //int[] brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var broj in brojevi)
            //{
            //    Console.WriteLine   (broj);
            //}


            /* while petlja */
            //while(true){
            //    Console.WriteLine("Unesite ime");
            //    var unos = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(unos))
            //    {
            //        Console.WriteLine("Ime "+unos);
            //        continue;
            //    }
            //    break;
            //}


            /*PRVI ZADATAK */
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            ///

            //Console.WriteLine("Unesite broj od 1 do 10");
            //var unos = Console.ReadLine();
            //var broj = Convert.ToInt32(unos);

            //if(broj>=1 && broj <= 10){
            //    Console.WriteLine("Valid");
            //}else{
            //    Console.WriteLine("Invalid");
            //}


            // Write a program which takes two numbers from the console and displays the maximum of the two. 

            //Console.WriteLine("Unesite prvi broj");
            //var unos1 = Console.ReadLine();
            //var broj1 = Convert.ToInt32(unos1);

            //Console.WriteLine("Unesite drugi broj");
            //var unos2 = Console.ReadLine();
            //var broj2 = Convert.ToInt32(unos2);

            //var max = (broj1 > broj2) ? broj1 : broj2;
            //Console.WriteLine("Maksimum je "+max);


            //Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.

            //Console.WriteLine("Unesite sirinu");
            //var sirina = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Unesite visinu");
            //var visina = Convert.ToInt32(Console.ReadLine());

            //if (sirina > visina)
            //{
            //    Console.WriteLine("Slika je landscape");
            //}
            //else{
            //    Console.WriteLine("Slika je portrait");
            //}


            ///// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.


            //Console.WriteLine("Unesite speed limit");
            //var limit = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Unesite brzinu vozila");
            //var brzina = Convert.ToInt32(Console.ReadLine());

            //if(brzina < limit){
            //    Console.WriteLine("Ok");
            //}else{
            //    const int kmPerDemeritPoints = 5;
            //    var demeritPoint = (brzina - limit) / kmPerDemeritPoints;
            //    if(demeritPoint>12){
            //        Console.WriteLine("License suspended");
            //    }else{
            //        Console.WriteLine("Demerit point" +demeritPoint);
            //    }
            //}



            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            /// Display the result on the console.

            //int brojac = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%3==0){
            //        brojac++;
            //    }
            //}
            //Console.WriteLine(brojac);


            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            ///
            //var zbir = 0;
            //while(true){
            //    Console.WriteLine("Unesite broj");
            //    var unos = Console.ReadLine();

            //    if (unos.ToLower() == "ok") break;

            //    zbir += Convert.ToInt32(unos);
            //}
            //Console.WriteLine("Zbir je "+zbir);



            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.

            //Console.WriteLine("Unesite broj");
            //var broj = Convert.ToInt32(Console.ReadLine());


            //int faktorijel = 1;
            //for (int i = 1; i < broj; i++)
            //{
            //    faktorijel *= i;
            //}
            //Console.WriteLine("Faktorijel je "+faktorijel);


            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            //var random = new Random().Next(1, 10);

            //Console.WriteLine("Broj je "+random);
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Izaberite broj");
            //    var broj = Convert.ToInt32(Console.ReadLine());
            //    if(broj == random){
            //        Console.WriteLine("You won");
            //    }else{
            //        Console.WriteLine("You lost");
            //    }
            //}



            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
            Console.WriteLine("Unesite brojeve odvojene zarezom");
            var unos = Console.ReadLine();

            var brojevi = unos.Split(' ');

            var max = Convert.ToInt32(brojevi[0]);
            foreach (var str in brojevi)
            {
                var broj = Convert.ToInt32(str);
                if (broj > max) max = broj;
            }
            Console.WriteLine("Najveci broj je "+max);
        }
    }
}
