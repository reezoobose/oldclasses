using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Recursion
{
    public  class UserInterface
    {
        public UserInterface()
        {
            UserChoice();
        }

        /// <summary>
        /// User choice .
        /// </summary>
        private void UserChoice()
        {
            while (true)
            {

                Console.WriteLine("[0] Base Conversion.");
                Console.WriteLine("[1] Fibonacci Number.");
                Console.WriteLine("[2] Factorial.");
                Console.WriteLine("[3] GCD.");
                Console.WriteLine("[4] Sum of digits.");
                Console.Write("Please Enter Your choice : ");
                var userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 0:
                        Console.Write("Number : ");
                        var number = int.Parse(Console.ReadLine());
                        Console.Write("Base :");
                        var basePoint = int.Parse(Console.ReadLine());
                        Console.Write("Process: 0 Recursion. \t 1 Iteration  :");
                        var process = int.Parse(Console.ReadLine());
                        switch (process)
                        {
                            case 0:
                                BaseConversion.BaseConversionProcess(basePoint,number);
                                break;
                            case 1:
                                Console.Write("Result: "+BaseConversion.BaseConversionProcessIterative(basePoint, number)+"\n");
                                break;
                        }
                        break;
                    case 1:
                        Console.Write("nth Element of fibonacci series : ");
                        var fibonacci = int.Parse(Console.ReadLine());
                        Console.Write("Process: 0 Recursion. 1 Iteration :");
                        var fibonacciProcess = int.Parse(Console.ReadLine());
                        switch (fibonacciProcess)
                        {
                            case 0:
                                Console.Write("Result: " + FibonacciSeries.FindFibonacciNumberOfTheSeries(fibonacci)+"\n");
                                break;
                            case 1:
                                Console.Write("Result: " + FibonacciSeries.GetFibonacciNumberOfTheSeries(fibonacci)+"\n");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("nth Factorial:");
                        var factorialNumber = int.Parse(Console.ReadLine());
                        Console.Write("Process: 0 Recursion. 1 Iteration :");
                        var factorialProcess = int.Parse(Console.ReadLine());
                        switch (factorialProcess)
                        {
                            case 0:
                               Console.Write("Result: "+ Factorial.GetFactorial(factorialNumber) + "\n"); ;
                                break;
                            case 1:
                                Console.Write("Result: " + Factorial.FindFactorial(factorialNumber) + "\n");
                                break;
                        }
                        break;
                    case 3:
                        Console.Write("GCD of numbers.");
                        Console.Write("First number : ");
                        var firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Second number : ");
                        var secondNumber = int.Parse(Console.ReadLine());
                        Console.Write("Result: " + GreatestCommonDivisor.FindGreatestCommonDivisor(firstNumber, secondNumber) + "\n");
                        break;
                    case 4:
                        Console.WriteLine("Enter the number:");
                        var numberToAddSum = int.Parse(Console.ReadLine());
                        Console.Write("Process: 0 Recursion. 1 Iteration :");
                        var addSumProcess = int.Parse(Console.ReadLine());
                        switch (addSumProcess)
                        {
                            case 0:
                                Console.Write("Result: " + SumOfDigits.FindSumOfDigits(numberToAddSum) + "\n"); ;
                                break;
                            case 1:
                                Console.Write("Result: " + SumOfDigits.GetSumOgDigits(numberToAddSum) + "\n");
                                break;
                        }
                        break;

                }
            }
        }
    }
}
