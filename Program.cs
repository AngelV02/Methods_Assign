using System;

namespace Methods_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            // Create an instance of MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call each method and display the returned integer
            int doubledNumber = mathOperations.DoubleNumber(userInput);
            Console.WriteLine($"Double of {userInput} is: {doubledNumber}");

            int squaredNumber = mathOperations.SquareNumber(userInput);
            Console.WriteLine($"Square of {userInput} is: {squaredNumber}");

            int factorial = mathOperations.CalculateFactorial(userInput);
            Console.WriteLine($"Factorial of {userInput} is: {factorial}");
        }
    }
}
