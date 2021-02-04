using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class Yasli:Yolcu
    {
        private string kategori = "Yaşlı";

        public string Kategori
        {
            get
            {
                return kategori;
            }

        }
    }
}
