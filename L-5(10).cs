using System;

public class NegativePriceException : Exception
{
    public NegativePriceException(string message) : base(message) { }
}

public class PriceTooHighException : Exception
{
    public PriceTooHighException(string message) : base(message) { }
}

class ShoppingCartProgram
{
    static void Main()
    {
        const int MaxPrice = 10000;

        int[] shoppingCart = new int[10]; 
        int itemCount = 0;

        Console.WriteLine("Welcome to the Shopping Cart!");

        while (true)
        {
            try
            {
                Console.Write("Enter the price of the item (or enter '0' to finish): ");
                string userInput = Console.ReadLine();

                if (userInput == "0")
                {
                    break;
                }

                int price = ValidateAndAddToCart(userInput, MaxPrice);

                shoppingCart[itemCount] = price;
                itemCount++;

                Console.WriteLine($"Item added to the cart: ${price}");
            }
            catch (NegativePriceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid price.");
            }
            catch (PriceTooHighException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        DisplayTotal(shoppingCart, itemCount);

        Console.ReadLine(); 
    }

    static int ValidateAndAddToCart(string userInput, int maxPrice)
    {
        if (!int.TryParse(userInput, out int price))
        {
            throw new FormatException();
        }

        if (price < 0)
        {
            throw new NegativePriceException("Negative prices are not allowed.");
        }

        if (price > maxPrice)
        {
            throw new PriceTooHighException($"Price exceeds the maximum allowed (${maxPrice}).");
        }

        return price;
    }

    static void DisplayTotal(int[] shoppingCart, int itemCount)
    {
        if (itemCount == 0)
        {
            Console.WriteLine("No items in the cart.");
        }
        else
        {
            int total = 0;
            for (int i = 0; i < itemCount; i++)
            {
                total += shoppingCart[i];
            }
            Console.WriteLine($"Total Price of Items in the Cart: ${total}");
        }
    }
}
