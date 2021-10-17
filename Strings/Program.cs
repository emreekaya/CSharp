using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Emre Kaya";

            var result = sentence.Length; // Uzunluğunu (kaç karakterden oluştuğunu) verir.

            var result2 = sentence.Clone(); //İlgili cümlenin bir referansını daha oluşturur.

            sentence = "My name is Muhammed";

            bool result3 = sentence.EndsWith("a");//cümle a ile bitiyo mu ?
            bool result4 = sentence.StartsWith("M");//cümle M ile başlıyo mu ? 
            // Result3 ve result4 için büyük küçük karakter ayrımı var.

            var result5 = sentence.IndexOf("name");//sorguladığımız şey varsa kaçıncı indexten başladığını verir. Yoksa -1 dönderir.
            var result6 = sentence.IndexOf(" ");//Boşluğu kontol ettirdik ama birden fazla boşluk var . İlk bulduğununkini yazdırır.
            var result7 = sentence.LastIndexOf("Muh");//Cümle içinde aramaya sondan başlar  ancak sırasını baştan kaçıncı olduğunu verir. 

            var result8 = sentence.Insert(0, "Hello, ");// İstediğimiz indexten itibaren istediğimiz şeyleri ekler.

            var result9 = sentence.Substring(3); // Cümleyi istediğimiz indexten itibaren okur.
            var result10 = sentence.Substring(3, 4); // İstediğimiz indexten itibaren belirttiğimiz kadar karakter okur.

            var result11 = sentence.ToLower();//Bütün karakterleri küçük yapıyor.
            var result12 = sentence.ToUpper();//Bütün karakterleri büyük yapıyor.

            var result13 = sentence.Replace(" ", "-");// İstediğimiz karakterleri istediğimize dönüştürür.

            var result14 = sentence.Remove(2);// İstediğimiz karakterden itibaren gerisini atar
            var result15 = sentence.Remove(2, 5);//İstediğimiz karakterden itibaren belirttiğimiz kadar karakter atar.


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.WriteLine(result15);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Adıyaman";
            //Console.WriteLine(city[3]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2)); //her iki stringin toplamı olacak şekillde bir string belirleyip bellekte yer kaplamadık.
        }
    }
}
