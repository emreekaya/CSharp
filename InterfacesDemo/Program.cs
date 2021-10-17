using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]{
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var calisma in workers)
            {
                calisma.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var yemek in eats)
            {
                yemek.Eat();
            }
            Console.ReadLine();
        }
        
    }

    //SOLID, Interface Segregation
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yiyecek 5 yönetici var.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alacak 5 yönetici var.");
        }

        public void Work()
        {
            Console.WriteLine("Çalışacak 3 yönetici var.");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yiyecek 300 işçi var.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alacak 300 işçi var.");
        }

        public void Work()
        {
            Console.WriteLine("Çalışacak 300 işçi var.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışacak 20 robot var.");
        }
    }
}
