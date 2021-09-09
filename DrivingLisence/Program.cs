using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)
            Console.WriteLine("how old are you");
            Console.WriteLine("You have to be 18 to get a licence");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            if (Age >= 18)
            {
                Console.WriteLine("Here is your driving licence.");
            }
            else
            {
                Console.WriteLine("You are too young for a licence!");
            }





        }
    }
}
