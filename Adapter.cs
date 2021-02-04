using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{

    class Adapter : Yolcubiletal
    {
        private BiletAl _biletAl ;

        public   Adapter(BiletAl biletAl)
        { 
       
            _biletAl = biletAl;
        }

        public int YolcuBiletAlID
        {
            get
            {
                return _biletAl.BiletId;
            }
            set
            {
                _biletAl.BiletId = value;
            }
        }

        public void Musteribiletal()
        {
            _biletAl.Personelbiletal();
        }

    }

}
