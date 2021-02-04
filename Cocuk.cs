using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class Cocuk:Yolcu
    {
        private string kategori = "Çocuk";

        public string Kategori
        {
            get
            {
                return kategori;
            }

        }
    }
}

