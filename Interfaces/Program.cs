using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro ();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServercustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonMenager menager = new PersonMenager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Emre",
                LastNeme = "Kaya",
                Adress = "Adıyaman"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Celaleddin",
                LastNeme = "Kızılkaya",
                Departmant = "Computer Engineering"
            };
            menager.Add(customer);
            menager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastNeme { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastNeme { get; set; }

            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastNeme { get; set; }

            public string Departmant { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastNeme { get; set; }

            public string Departmant { get; set; }

        }
        class PersonMenager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }



}
