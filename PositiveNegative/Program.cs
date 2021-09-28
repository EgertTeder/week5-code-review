using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");

            int UserNumber = Convert.ToInt32(Console.ReadLine());
            
            
            if(UserNumber > 0)
            {
                Console.WriteLine("Negative");
            } 
            else
            {
                Console.WriteLine("null");
            }

        }
    }
}
