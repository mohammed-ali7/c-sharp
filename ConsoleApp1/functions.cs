using System;
using System.Threading.Tasks;

namespace FunctionExamples
{
    // 1. Simple Function
    public class SimpleFunction
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void RunExample()
        {
            int result = Sum(5, 3);
            Console.WriteLine($"The sum of 5 and 3 is: {result}");
        }
    }

    // 2. Function with Default Parameters
    public class RectangleArea
    {
        public double CalculateArea(double width, double height = 1)
        {
            return width * height;
        }

        public void RunExample()
        {
            double squareArea = CalculateArea(5);
            double rectangleArea = CalculateArea(5, 3);

            Console.WriteLine($"Area of square with side 5: {squareArea}");
            Console.WriteLine($"Area of rectangle with width 5 and height 3: {rectangleArea}");
        }
    }

    // 3. Function Overloading
    public class MessagePrinter
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintMessage(string message, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(message);
            }
        }

        public void RunExample()
        {
            PrintMessage("Hello, World!");
            PrintMessage("Function overloading", 3);
        }
    }

    // 4. Return Multiple Values using out
    public class MultipleReturns
    {
        public void CalculateSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        public void RunExample()
        {
            int sum, product;
            CalculateSumAndProduct(5, 3, out sum, out product);
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }
    }

    // 5. Interface for Advanced Functions
    public interface IAdvancedFunctions
    {
        int Factorial(int n);
        Func<int, int> GetSquareFunction();
        Task<string> SimulateFileDownloadAsync();
    }

    // Implementation of IAdvancedFunctions
    public class AdvancedFunctions : IAdvancedFunctions
    {
        // 5. Recursive Function
        public int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        // 6. Anonymous Functions and Lambda Expressions
        public Func<int, int> GetSquareFunction()
        {
            return x => x * x;
        }

        // 7. Asynchronous Function with async/await
        public async Task<string> SimulateFileDownloadAsync()
        {
            await Task.Delay(2000); // Simulate a 2-second delay
            return "File downloaded successfully!";
        }

        public async Task RunExampleAsync()
        {
            Console.WriteLine($"Factorial of 5: {Factorial(5)}");

            var square = GetSquareFunction();
            Console.WriteLine($"Square of 7: {square(7)}");

            string result = await SimulateFileDownloadAsync();
            Console.WriteLine(result);
        }
    }

    class functions
    {
        static async Task Main(string[] args)
        {
            var simpleFunction = new SimpleFunction();
            simpleFunction.RunExample();

            var rectangleArea = new RectangleArea();
            rectangleArea.RunExample();

            var messagePrinter = new MessagePrinter();
            messagePrinter.RunExample();

            var multipleReturns = new MultipleReturns();
            multipleReturns.RunExample();

            var advancedFunctions = new AdvancedFunctions();
            await advancedFunctions.RunExampleAsync();

            Console.ReadLine();
        }
    }
}