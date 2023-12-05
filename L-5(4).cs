using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] array = { 1, 2, 3 };
            Console.WriteLine("Attempting to access an element outside the array bounds: " + array[5]);
            Console.WriteLine("Attempting to parse an invalid number: " + int.Parse("abc"));
            throw new InvalidOperationException("Simulated InvalidOperationException");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("FormatException: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("InvalidOperationException: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.ReadLine(); 
    }
}
