using System;

namespace PROG12B22 // Note: actual namespace depends on the project name.
{
    class OOP
    {
        static void Main(string[] args)
        {
            int iage = 8, inum2;
            double dheight = 1.5, dnum2, mod, div, sample, sample1;
            string fName, lName;
            char letter = 'P';
            bool condition;

            Console.WriteLine("Hello World!");
            Console.WriteLine(iage);
            Console.WriteLine(iage + dheight);

            fName = (Console.ReadLine());
            lName = (Console.ReadLine());
            Console.WriteLine("Name: " + fName + " Last name: " + lName);

            //typecasting or conversion
            dnum2 = 5.76;
            inum2 = (int)dnum2;

            Console.WriteLine(dnum2);
            Console.WriteLine(inum2);

            //conversion method
            Console.WriteLine("_____________________");
            int age = 15;
            double weight = 2.5;

            Console.WriteLine(Convert.ToString(age));

            //weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(weight);
            Console.WriteLine(Convert.ToInt16(weight));


            // for modulus
            Console.WriteLine("____________");
            div = (double)5 / 2;
            mod = 5 % 2;
            
            Console.WriteLine(div);
            Console.WriteLine(mod);

            
            sample1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToInt16(sample1));

        }
    }
}