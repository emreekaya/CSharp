using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //First usage
            //string[] students = new string[4];
            //students[0] = "Emre";
            //students[1] = "Muhammed";
            //students[2] = "Ragıp";
            //Second usage
            //string[] students2 = new string[4] { "Emre", "Muhammed", "Ragıp", "Taylan" };
            //Third usage
            //string[] students3 = new[] {"Emre","Muhammed","Ragıp","Taylan","Tahir" };
            //Fourth usage
            //string[] students4 ={ "Emre", "Muhammed", "Ragıp", "Taylan", "Tahir","Sinan" };

            //foreach (var ogrenci in students)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //foreach (var ogrenci in students2)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //foreach (var ogrenci in students3)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //foreach (var ogrenci in students4)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            //Console.WriteLine();



            string[,] regions = new string[7, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"İzmir","Muğla","Manisa"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Mersin","Adana"},
                {"Tokat","Trabzon","Rize"},
                {"Erzurum","Van","Hakkari"},
                {"Adıyaman","Gaziantep","Diyarbakır"},
            };
            
            for (var i = 0; i <= regions.GetUpperBound(0); i++)
            {
                //Console.WriteLine("{0}. bölgeye ait şehirlerini yazınız:",i);
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    //Console.WriteLine("{0}. şehri yazınız:", j);
                    Console.WriteLine(regions[i,j]);
                    //regions[i,j]=(Console.ReadLine());
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();
        }
    }
}
