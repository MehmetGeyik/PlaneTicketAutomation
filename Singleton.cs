using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton nesne;
        public static Singleton NesneVer()
        {
            if (nesne ==null)
            {
                nesne = new Singleton();
            }
            return nesne;
        }
    }
}
