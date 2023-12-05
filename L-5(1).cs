using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num =50;
            int den = 0;
            try
            {
                int result = DivideNumbers(num, den);
                Console.WriteLine($"Result={result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"An exception occurred: {e.Message}");
            }

            Console.WriteLine("Program continues...");
        }

        static int DivideNumbers(int num, int den)
        {
            if (den == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return num / den;
        }
    }
}
