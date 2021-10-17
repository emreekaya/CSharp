using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number3=5000;
            //int number4 = 300;
            //var result2 = Add3(out number3,number4);
            //Console.WriteLine(result2);
            //Console.WriteLine(number3);
            //var result = Add2(17);
            //Console.WriteLine("Add1: ",result);
            //Console.WriteLine(Multiply(17,24));
            //Console.WriteLine(Multiply(17, 24, 2));
            //Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1, int number2=24)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(out int number3,int number4)
        {
            number3 = 1000;
            return number3 + number4;
        }
        static int Multiply(int number4, int number5)
        {
            return number4 * number5;
        }
        static int Multiply(int number4, int number5, int number6)
        {
            return number4 * number5 * number6;
        }
        static int Add4(int number7,params int [] numbers)
        {
            return numbers.Sum();
        }
    }
}
