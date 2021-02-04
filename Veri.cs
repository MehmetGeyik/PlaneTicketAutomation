using System.Data.SqlClient;

namespace Uçak_Bileti_Otomasyonu
{
    class Veri
    {
        private Veri()
        {

        }
        private static Veri nesne;

        public static Veri NesneVer()
        {
            if(nesne==null)
            {
                nesnem = new Veri();

            }
            return nesne;
        }
        
    }
}
