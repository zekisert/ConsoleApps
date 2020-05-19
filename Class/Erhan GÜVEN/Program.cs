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
            
       /*
            //Değer Tip Ataması
            int a = 50;
            int b = a;
            b = 30;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //Referans Tip Ataması
            Musteriler muster1 = new Musteriler();
            Musteriler musteri2 = muster1;
            musteri2.MusteriIsmi = "Erhan";
            Console.WriteLine(muster1.MusteriIsmi);
            Console.WriteLine(musteri2.MusteriIsmi);
       */
            
       /*
            StaticYapilar statikyapilar = new StaticYapilar();
            statikyapilar.StatikOlmayanIslemYap();
            StaticYapilar.StatikOlanIslemYap();
       */
            Hesaplar hesap = new Hesaplar();

            Console.ReadLine();
        }

       
    }

   

    
}
