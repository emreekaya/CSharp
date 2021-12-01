using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<YolcuTasit> yolcuTasits = new List<YolcuTasit>();
            List<YukTasit> yukTasits = new List<YukTasit>();

            yolcuTasits.Add(new Otobüs("Mercedes Tourismo", 40, 10, 1));
            yolcuTasits.Add(new Otobüs("Mercedes Tourismo", 45, 10, 2));
            yolcuTasits.Add(new Otobüs("Mercedes Travego", 50, 10, 3));
            yolcuTasits.Add(new Otobüs("Mercedes Travego", 55, 15, 4));
            yolcuTasits.Add(new Otobüs("Mercedes Neoplan", 80, 10, 5));
            yolcuTasits.Add(new Otobüs("Mercedes Neoplan", 100, 15, 6));
            yolcuTasits.Add(new Minibüs("Ford Transit", 20, 5, 7));
            yolcuTasits.Add(new Minibüs("Ford Transit", 25, 10, 8));
            yolcuTasits.Add(new Minibüs("Karsan Jest", 30, 5, 9));
            yolcuTasits.Add(new Minibüs("Karsan Jest", 35, 10, 10));
            yolcuTasits.Add(new Otomobil("Mercedes Tourismo", 1, 10, 1));//burdan itibaren düzelt
            yolcuTasits.Add(new Otomobil("Mercedes Tourismo", 7, 10, 2));
            yolcuTasits.Add(new Otomobil("Mercedes Travego", 12, 10, 3));
            yolcuTasits.Add(new Otomobil("Mercedes Travego", 16, 15, 4));
            yolcuTasits.Add(new Otomobil("Mercedes Neoplan", 19, 10, 5));
            yolcuTasits.Add(new Vapur("Mercedes Neoplan", 100, 15, 6));
            yolcuTasits.Add(new Vapur("Ford Transit", 60, 5, 7));
            yolcuTasits.Add(new Vapur("Ford Transit", 80, 10, 8));
            yolcuTasits.Add(new Vapur("Karsan Jest", 150, 5, 9));
            yolcuTasits.Add(new Vapur("Karsan Jest", 300, 10, 10));


            Console.WriteLine("Merhaba, hoşgeldiniz. \n");
            int number=1;
            Console.WriteLine("Yolcu taşımak için 1'e basınız\nYük taşımak için 2'ye basınız");
            tekrar:
            Console.WriteLine("Lütfen seçiminizi yapınız:");
            number = Convert.ToInt16(Console.ReadLine());
            int yolcusayisi;
            float yükagirligi;
            
            if (number==1)
            {
                Console.WriteLine("Kaç yolcunuz var ?");
                yolcusayisi = Convert.ToInt32(Console.ReadLine());
            }
            else if (number==2)
            {
                Console.WriteLine("Kaç kg yükünüz var ?");
                yükagirligi = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Belirtilen seçimler dışında seçim yapamazsınız.Lütfen doğru seçim yapınız.");
                goto tekrar;
                
            }

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Kaç yolcunuz var ?");
            //        yolcusayisi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    case 2:
            //        Console.WriteLine("Kaç kg yükünüz var ?");
            //        yükagirligi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    default:
            //        break;
            //}
            Console.ReadLine();
        }

        public static void delete(YolcuTasit yolcuTasit)
        {
        }
    }
}
