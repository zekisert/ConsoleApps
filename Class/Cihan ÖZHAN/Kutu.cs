using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Kutu
    {
        public double uzunluk;
        private double genislik;
        private double yukseklik;

        public Kutu()
        {
            //uzunluk = 5;
            //Console.WriteLine("Nesne Kuruldu");
        }

        public Kutu(double uzunluk,double genislik,double yukseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        public double GetUzunluk()
        {
            return uzunluk;
        }

        public void SetUzunluk(double uzunluk)
        {
            if (uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }
        }

    }
}
