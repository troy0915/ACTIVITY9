using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Validate input
            if (int.TryParse(input, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }
}





