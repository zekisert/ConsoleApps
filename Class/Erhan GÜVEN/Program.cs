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
            /*
            Musteriler musteri = new Musteriler();
            musteri.MusteriEkle("Erhan");
            musteri.MusteriSil("Erhan");

            Hesaplar hesap = new Hesaplar();
            hesap.HesapEkle("Erhan", 500);
            */

            /*
            Değer Tip Ataması
            int a = 50;
            int b = a;
            b = 30;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Referans Tip Ataması
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

            //Hesaplar hesap = new Hesaplar(50, "Erhan");

            /*    
            Ozellikler ozellik = new Ozellikler();
            ozellik.Sayi = 3;
            Console.WriteLine(ozellik.Sayi);
            */

            /*
            Console.WriteLine(Sabitler.pi);
            Sabitler sabit = new Sabitler();
            Console.WriteLine(sabit.Sayi);
            */

            /*
            Hesaplar hesap = new Hesaplar(50,"Erhan");
            hesap.HesapEkle();
            Hesaplar hesap2 = new Hesaplar(60, "Toprak");
            hesap2.HesapEkle();
            */

            /*
            Yapilar yapi = new Yapilar();
            yapi.Sayi = 20;
            BenimYapim benimYapim = new BenimYapim();
            benimYapim.Sayi = 0;

            BenimYapim benimYapim1 = new BenimYapim();
            BenimYapim benimYapim2 = new BenimYapim();
            benimYapim1.Sayi = 35;
            benimYapim2 = benimYapim1;
            benimYapim2.Sayi = 50;
            Console.WriteLine(benimYapim1.Sayi);
            Console.WriteLine(benimYapim2.Sayi);
            */

            /*
            Console.WriteLine(Cariler.ALICI);

            EnumYapisi yapi = new EnumYapisi();
            yapi.KayitEkle(Cariler.PERSONEL);
            */

            OtoparkUygulamasi uygulama = new OtoparkUygulamasi();
            uygulama.Calistir();
           
            Console.ReadLine();
        }
    }
}

