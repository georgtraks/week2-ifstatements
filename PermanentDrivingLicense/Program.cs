using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Sisesta Oma Sünniaasta?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());

            int age = 2021 - YearOfBirth;

            if (age >= 18)
            {
                Console.WriteLine("oled piisavalt vana, et juhilub saada.");
            }
            else
            {
                Console.WriteLine("liiga noor, et juhiluba saada.");
            }
   
            /*if (age > 18)
            {
                Console.WriteLine("oled piisavalt vana, et juhiluba saada.");
            }
            else if(age < 18)
            {
                Console.WriteLine("oled liiga noor, et juhiluba saada");
            }
            else
            {
                Console.WriteLine("oled 18, nüüd saadjuhiluba saada.");
            }*/

            





        }
    }
}
