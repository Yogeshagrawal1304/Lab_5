using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            int index = 10;
            int value = numbers[index];
            Console.WriteLine("Value at index {index} is {value}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"An exception occurred: {e.Message}");
        }

        Console.WriteLine("Program continues...");
    }
}
