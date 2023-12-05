using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block started.");

            try
            {
                Console.WriteLine("Inner try block started.");
                throw new InvalidOperationException("Exception in the inner block");

                Console.WriteLine("This line will not be reached in the inner block.");
            }
            catch (Exception exInner)
            {
                Console.WriteLine("Inner catch block: " + exInner.Message);
            }
            finally
            {
                Console.WriteLine("Inner finally block executed.");
            }

            Console.WriteLine("This line will not be reached in the outer try block.");
        }
        catch (Exception exOuter)
        {
            Console.WriteLine("Outer catch block: " + exOuter.Message);
        }
        finally
        {
            Console.WriteLine("Outer finally block executed.");
        }

        Console.ReadLine(); 
    }
}
