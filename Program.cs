using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- Welcome To the Simple Calculator ----------------------------");
            try
            {
                Console.WriteLine("Enter de first number");
                string input1 = Console.ReadLine();
                double firstNumber;
                bool isFirstDouble = double.TryParse(input1, out firstNumber);
                if (!isFirstDouble)
                {
                    throw new Exception("The convertion to a number failed");
                }
                Console.WriteLine("Enter operation");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter de second number");
                string input3 = Console.ReadLine();
                double secondNumber;
                bool isSecondDouble = double.TryParse(input3, out secondNumber);
                if (!isSecondDouble)
                {
                    throw new Exception("The convertion to a number failed");
                }
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("= " + (firstNumber + secondNumber));
                        break;
                    case "-":
                        Console.WriteLine("= " + (firstNumber - secondNumber));
                        break;
                    case "*":
                        Console.WriteLine("= " + (firstNumber * secondNumber));
                        break;
                    case "/":
                        Console.WriteLine("= " + (firstNumber / secondNumber));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid mathematical operation");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
            

        }
    }
}
