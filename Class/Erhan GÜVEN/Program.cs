using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri = new Musteriler();
            musteri.MusteriEkle("Erhan");
            musteri.MusteriSil("Erhan");

            Hesaplar hesap = new Hesaplar();
            hesap.HesapEkle("Erhan", 500);

            Console.ReadLine();
        }

       
    }

   

    
}
