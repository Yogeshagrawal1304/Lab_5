using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1} + {num2} = {Addition(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1} - {num2} = {Subtraction(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1} * {num2} = {Multiplication(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result: {num1} / {num2} = {Division(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        Console.WriteLine("Calculator closed.");
    }

    static double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }

        return num1 / num2;
    }
}
