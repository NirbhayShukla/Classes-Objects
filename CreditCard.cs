using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class CreditCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Balance");
            double balance=int.Parse(Console.ReadLine());
            int month = 1;
            int totalPayments = 0;
            while(balance>0)
            {
                Console.WriteLine("Enter Monthly Payment");
                int pay=int.Parse(Console.ReadLine());
                totalPayments += pay;
                Console.WriteLine($"Month {month} : balance : {balance} total payment : {totalPayments}");
                balance -= pay;
                balance *= 1.015;
                month++;
            }
        }

    }
}
