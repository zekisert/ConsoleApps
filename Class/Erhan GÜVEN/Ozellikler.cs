using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Ozellikler
    {
        private int _sayi;
        public int Sayi 
        { 
            get
            {
                return _sayi;
            }
            
            set
            {
                if (value<5)
                {
                    _sayi = 5;

                }
                else
                {
                    _sayi = value;
                }
                
            }
        
        
        }

    }
}
