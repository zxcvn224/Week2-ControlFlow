using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age to continue");

            //programm küsib kasutaja vanust
            //kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("Old enough, you may pass.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("YOU NEED TO BE 18 TO ENTER THE CLUB!!!");
            }
            else
            {
                Console.WriteLine("Nice, right this way sir.");
            }

            Console.WriteLine("Goodbye");
            

        }
    }      
}
