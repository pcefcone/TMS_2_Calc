using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Calculator;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalc calc = new MyCalc();


            while (true)
            {
            Console.WriteLine("Put first number: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Put second number: ");
            string secondInput = Console.ReadLine();

                if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
                {
                    Console.WriteLine("Please choose the following you want to do");
                    Console.WriteLine("Choose '+' to calculate the addition");
                    Console.WriteLine("Choose '-' to calculate the substraction");
                    Console.WriteLine("Choose '*' to calculate the multiplication");
                    Console.WriteLine("Choose '/' to calculate the division");
                    Console.WriteLine("Choose '^' to calculate the exponentiation");
                    Console.WriteLine("Choose '%' to calculate the module");
                    Console.WriteLine("Your choose is: ");

                    switch (Console.ReadLine())
                    {
                        // addition
                        case "+":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.AddOperation(firstNumber, secondNumber)}");
                            break;

                        // substraction
                        case "-":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.SubOperation(firstNumber, secondNumber)}"); ;
                            break;

                        // multiplication
                        case "*":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.MultiplicationOperation(firstNumber, secondNumber)}");
                            break;

                        // division
                        case "/":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.DivisionOperation(firstNumber, secondNumber)}");
                            break;

                        // square
                        case "^":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.SquareOperation(firstNumber, secondNumber)}");
                            break;

                        // square
                        case "%":
                            Console.WriteLine(value: $"Your result is: " +
                                $"{MyCalc.ModuleOperation(firstNumber, secondNumber)}");
                            break;

                        default:
                            Console.WriteLine("Unknown operaion, please try again");
                            break;
                    }
                    break;
                }
                Console.WriteLine("Input data must be numbers");
            }









            
            Console.ReadKey();
        }
    }
}


