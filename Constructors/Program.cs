using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeMenager employeeMenager = new EmployeeMenager(new FileLogger());
            employeeMenager.Add();

            PersonMenager personMenager = new PersonMenager("Product");
            personMenager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Menager.DoSomething();
            Menager menager = new Menager();
            menager.DoSomething2();

            Console.ReadLine();
        }
    }
    class CustomerMenager
    {
        private int _count = 17;
        public CustomerMenager(int count)
        {
            _count = count;
        }
        public CustomerMenager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface Ilogger
    {
        void Log();
    }
    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeMenager
    {
        private Ilogger _logger;
        public EmployeeMenager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonMenager : BaseClass
    {
        public PersonMenager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    static class Teacher
    {
        public static int Number{ get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Menager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done ");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2 ");
        }
    }
}
 