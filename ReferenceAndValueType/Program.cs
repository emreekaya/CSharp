using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 17;
            int number2 = 24;
            number2 = number1;
            number1 = 41;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Adana", "Ankara", "Adıyaman" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
            
            Console.ReadLine();

            //Value types: "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
            //Reference types: "string", "object", "class", "interface", "array", "delegate", "pointer"
        }
    }
}
