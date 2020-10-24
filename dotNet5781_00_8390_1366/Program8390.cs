using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_00_8390_1366
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome8390();
            Welcome1366();
            Console.ReadKey();
        }
        static partial void Welcome1366();
        private static void Welcome8390()
        {
            Console.WriteLine("Enter your name: ");
            string myStr = Console.ReadLine();
            Console.WriteLine("{0}, welcome to my first console application", myStr);
        }
    }
}
