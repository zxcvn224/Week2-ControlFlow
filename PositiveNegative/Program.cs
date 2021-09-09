using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit - 10 kuni 10
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "positiivne"
            //kui number on negatiivne, konsool kuvab "negatiivne"
            //kui number on 0, siis konsool kuvab "null";

            Console.WriteLine("Please enter a number from -10 to 10");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("null");
            }
            






        }

    }
}
