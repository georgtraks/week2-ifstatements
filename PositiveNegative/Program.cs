using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrid
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab"number on positiivne";
            //kui number on negatiivne, konsool kuvab "number on negatiivne";
            //kui sisestatud number on 0, siis konsool kuvab "null";
            //NB! int32parse asemel kasutame convert.toint32(console.readline());

            Console.WriteLine("palun sisesta number.");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("number on negatiivne.");
            }
            else if (number > 0)
            {
                Console.WriteLine("number on positiivne");
            }
            else
            {
                Console.WriteLine("null.");
            }

















        }
    }
}
