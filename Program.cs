using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bileti_Otomasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Otomasyon());


            BiletAl biletAl = new BiletAl() { BiletId = 123 };

            //BiletAl nesnesini Adapter sınıfımız ile Yolcubiletal tipine çeviriyoruz
            Yolcubiletal yolcubiletal = new Adapter(biletAl);
             /*Console.ReadKey(); */ 




            Guncelleyolcu guncelleyolcu = new Guncelleyolcu();
            

            // İlgili gözlemleyicimizi guncelleyolcu nesnemize ekliyoruz ki değişim sonrasında notify edebilelim.
            guncelleyolcu.Attach(new CustomerObserver());

            // Yolcu koltuğu değiştiriyoruz.
            guncelleyolcu.Koltukupdate();
            MessageBox.Show("Güncellendi");
        }
    }
}
