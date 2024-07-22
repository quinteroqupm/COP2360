using System;

namespace DivisionAndConversionExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            PerformDivision(input1, input2);
        }

        static void PerformDivision(string num1, string num2)
        {
            try
            {
                int number1 = Convert.ToInt32(num1);
                int number2 = Convert.ToInt32(num2);

                int result = Divide(number1, number2);
                Console.WriteLine($"The result of dividing {number1} by {number2} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs are not valid integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One or both numbers are too large.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}