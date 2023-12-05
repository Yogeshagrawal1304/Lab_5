using System;

class Program
{
    static void Main()
    {
        try
        {
            ThrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught exception: " + ex.Message);
        }

        Console.ReadLine(); 
    }

    static void ThrowException()
    {
        try
        {
            throw new InvalidOperationException("Original exception");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught exception within ThrowException method: " + ex.Message);
            throw; 
        }
    }
}
