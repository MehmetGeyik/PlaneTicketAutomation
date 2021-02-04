using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class Yetiskin:Yolcu
    {
        private string kategori = "Yetişkin";

        public string Kategori
        {
            get
            {
                return kategori;
            }

        }
    }

}
