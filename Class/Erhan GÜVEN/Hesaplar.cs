using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Hesaplar
    {
        public Hesaplar(int sayi,string isim)
        {
            Console.WriteLine($"{sayi} {isim}  Constructor Metodu Çalıştırıldı.");
        }
        
        public void HesapEkle(string MusteriAdi, int hesapNo)
        {
            Console.WriteLine($"{MusteriAdi} adlı müşterinin {hesapNo} hesabı eklendi.");
        }

        public void HesapSil(string MusteriAdi, int hesapNo)
        {
            Console.WriteLine($"{MusteriAdi} adlı müşterinin {hesapNo} hesabı silindi.");
        }
    }
}
