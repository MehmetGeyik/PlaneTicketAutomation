using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class CustomerObserver : Observer
    {
        public override void Update()
        {

            Console.WriteLine("Yolcu bilgileri güncellendi. Kontrol ediniz.");
            Console.ReadLine();
        }
    }
}
