using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust
            Console.WriteLine("When were you born?");

            int Age = Convert.ToInt32(Console.ReadLine());
            int Year = 2021 - Age;

            Console.WriteLine($"You are {Year} years old!");

        }
    }
}
