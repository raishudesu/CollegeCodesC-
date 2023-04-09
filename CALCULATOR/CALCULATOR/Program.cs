using System;
using System.Reflection.Metadata;

namespace CALCULATOR
{
    class Program
    {
        static double add(double x, double y)
        {
            return x + y;
        }
        static double sub(double x, double y)
        {
            return x - y;
        }
        static double mul(double x, double y)
        {
            return x * y;
        }
        static double div(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            double num1, num2, result;
            bool on_going;
            char operation;
            on_going = true;
            while (on_going)
            {
                Console.WriteLine("Enter your first number");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your operation!");
                operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter your second number");
                num2 = Convert.ToDouble(Console.ReadLine());
                
                if (operation == '+')
                {
                    result = add(num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == '-')
                {
                    result = sub(num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == '*')
                {
                    result = mul(num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == '/')
                {
                    result = div(num1, num2);
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

    }
}