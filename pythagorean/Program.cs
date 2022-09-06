using System;

namespace pythagorean // Note: actual namespace depends on the project name.
{
    class pytha
    {
        static void pythamethod()
        {
            int user;

            Console.WriteLine("Press 1 for a, 2 for b, 3 for c:");
            user = Convert.ToInt16(Console.ReadLine());

            static void asqrd()
            {   int b, c;
                double ans, formula, c1, b1;

                Console.WriteLine("What is the b? ");
                b = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the c? ");
                c = Convert.ToInt16(Console.ReadLine());

                c1 = Math.Pow(c, 2);
                b1 = Math.Pow(b, 2);
                formula = c1 - b1;
                ans = Math.Sqrt(formula);

                Console.WriteLine(ans);
            }
            static void bsqrd()
            {
                int a, c;
                double ans, formula, c1, a1;

                Console.WriteLine("What is the a? ");
                a = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the c? ");
                c = Convert.ToInt16(Console.ReadLine());

                c1 = Math.Pow(c, 2);
                a1 = Math.Pow(a, 2);
                formula = c1 - a1;
                ans = Math.Sqrt(formula);

                Console.WriteLine(ans);
            }
            static void csqrd()
            {
                int b, a;
                double ans, formula, a1, b1;

                Console.WriteLine("What is the a? ");
                a = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("What is the b? ");
                b = Convert.ToInt16(Console.ReadLine());

                a1 = Math.Pow(a, 2);
                b1 = Math.Pow(b, 2);
                formula = a1 + b1;
                ans = Math.Sqrt(formula);

                Console.WriteLine(ans);
            }
            if (user == 1)
                asqrd();

            else if (user == 2)
                bsqrd();

            else if (user == 3)
                csqrd();
        }
        static void Main(string[] args)
        {
            pythamethod();
        }
    }
}