using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Hesaplar
    {
        private int _sayi;
        private string _isim;
        public Hesaplar(int sayi,string isim)
        {
            Console.WriteLine($"{sayi} {isim}  Constructor Metodu Çalıştırıldı.");
            _sayi = sayi;
            _isim = isim;
        }

        /*
        public void HesapEkle(string MusteriAdi, int hesapNo)
        {
            Console.WriteLine($"{MusteriAdi} adlı müşterinin {hesapNo} hesabı eklendi.");
        }
        */

        public void HesapEkle()
        {
            Console.WriteLine($"{_isim} adlı müşterinin {_sayi} hesabı eklendi.");
        }

        /*
        public void HesapSil(string MusteriAdi, int hesapNo)
        {
            Console.WriteLine($"{MusteriAdi} adlı müşterinin {hesapNo} hesabı silindi.");
        }
        */

        
        public void HesapSil()
        {
            Console.WriteLine($"{_isim} adlı müşterinin {_sayi} hesabı silindi.");
        }
        
    }
}

