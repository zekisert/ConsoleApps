using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class StaticYapilar
    {
        //Class static yapılırsa altındaki tüm değişken ve metotlarda static olmak zorundadır.
        public static void StatikOlanIslemYap()
        {
            Console.WriteLine("Statik Olan Metod Çalıştırıldı.");
        }

        public void StatikOlmayanIslemYap()
        {
            Console.WriteLine("Statik Olmayan Metod Çalıştırıldı.");
        }
    }
}
