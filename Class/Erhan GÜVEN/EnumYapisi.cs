using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class EnumYapisi
    {
        public void KayitEkle(Cariler cari)
        {
            Console.WriteLine($"{cari} veritabanına eklendi.");
        }
    }

    public enum Cariler
    {
        ALICI=32,
        SATICI=27,
        PERSONEL=45,
        TOPTANCI=99
    }
}
