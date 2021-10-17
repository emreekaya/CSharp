using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            var number7 = 93;
            number7 = 'E';
            decimal number6 = 17.586321483525762872467557863m;
            double number5 = 17.5; 
            char character = 'K';
            bool condition = true;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 17;
            long number2 = 9223372036854775807;
            Console.WriteLine(" Number 1 is {0}", number1);
            Console.WriteLine(" Number 2 is {0}", number2);
            Console.WriteLine(" Number 3 is {0}", number3);
            Console.WriteLine(" Number 3 is {0}", number4);
            Console.WriteLine(" Number 5 is {0}", number5);
            Console.WriteLine(" Number 6 is {0}", number6);
            Console.WriteLine(" Number 7 is {0}", number7);
            Console.WriteLine(" Character is : {0}", (int)character);
            Console.WriteLine(" " + (int)Days.Wednesday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=1,
        Tuesday=5,
        Wednesday=17,
        Thursday=9,
        Friday=96,
        Saturday=58,
        Sunday=23
    }
}
