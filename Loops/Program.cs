using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForEachLoop();
            

            if (IsPrimeNumber(1))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is a not prime number");
            }
        

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 )
                {
                    result = false;
                    //i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students2 = new string[4] { "Emre", "Muhammed", "Ragıp", "Taylan" };
            foreach (var ogrenci in students2)
            {
                Console.WriteLine(ogrenci);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
