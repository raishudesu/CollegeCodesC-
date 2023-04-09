using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankop
{
    class Program
    {
        static double deposit()
        {
            double dep;
            dep = 0;
            while (dep <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter amount to deposit: ");
                dep = Convert.ToDouble(Console.ReadLine());
                if (dep > 1)
                {
                    Console.WriteLine(dep);
                }
            }
        }
        public static void bankoperation()
        {
            double user, dep, totalbalance;
            
         
            List<Record> main_record = new List<Record>();
            dep = 0;
            totalbalance = 0;

            while (1==1)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter your choice!: ");
                user = Convert.ToDouble(Console.ReadLine());

                if (user == 1)
                {
                    dep = deposit();
                    totalbalance += dep;
                    Console.WriteLine("You deposited: " + dep);
                    Console.WriteLine("Your balance is now: " + totalbalance);
                    main_record.Add(["Deposit: " + dep]);

                }

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("***WELCOME TO BSIT BANK!***\n[1] Deposit\r\n[2] Withdraw\r\n[3] Transaction History\r\n[4] Exit");

        }
    }
}