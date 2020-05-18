using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager can = new CustomerManager(20);
            can.List();

            Product canan = new Product { Id = 1, Name = "Computer" };
            Product urun = new Product(2, "Laptop");
            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        private int _count = 10;
        public CustomerManager(int a)
        {
            _count = a;

        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(int id,string isim)
        {

        }

        public void Hoba()
        {
            Console.WriteLine();
        }

    }
}
