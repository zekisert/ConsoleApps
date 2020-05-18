using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutu k = new Kutu();
            //Kutu k = new Kutu(5,6,7);
            //Console.WriteLine(k._uzunluk);

            k.SetUzunluk(-100);
            Console.WriteLine(k.GetUzunluk());

            Console.ReadLine();
        }
    }
}
