using System;

// Custom exception class
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");

        try
        {
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number < 0)
            {
                throw new CustomException("Negative numbers are not allowed.");
            }

            Console.WriteLine("Entered positive integer: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine(); 
    }
}
