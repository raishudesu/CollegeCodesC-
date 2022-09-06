using System;

namespace PYTHON2C
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double dNum1, dNum2;
            string op;

            Console.WriteLine("Enter first number: ");
            dNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator: + - * / ");
            op = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            dNum2 = Convert.ToDouble(Console.ReadLine());


            if (op == "+")
                Console.WriteLine(dNum1 + dNum2);

            else if (op == "-")
                Console.WriteLine(dNum1 - dNum2);

            else if (op == "*")
                Console.WriteLine(dNum1 * dNum2);

            else if (op == "/")
                Console.WriteLine((double)dNum1 / dNum2);

            else Console.WriteLine("Invalid operator!");

           
        }
    }
}
