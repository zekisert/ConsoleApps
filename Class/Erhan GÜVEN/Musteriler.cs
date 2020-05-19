using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Musteriler
    {
        public void MusteriEkle(string MusteriAdi)
        {
            Console.WriteLine(MusteriAdi + " adlı müşteri Eklendi.");
        }

        public void MusteriDuzenle(string MusteriAdi)
        {
            Console.WriteLine(MusteriAdi + " adlı müşteri Düzenlendi.");
        }

        public void MusteriSil(string MusteriAdi)
        {
            Console.WriteLine(MusteriAdi + " adlı müşteri Silindi.");
        }
    }
}
