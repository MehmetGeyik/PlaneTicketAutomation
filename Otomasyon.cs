using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Uçak_Bileti_Otomasyonu
{
    public partial class Otomasyon : Form
    {

        BiletAl Bilet = new BiletAl();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);
        Cursor myCursor;

        public Otomasyon()
        {
            IntPtr handle = LoadCursorFromFile("plane.cur");
            myCursor = new Cursor(handle);
            Bilet.Cursor = myCursor;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            KullaniciGiris kg = new KullaniciGiris();
            kg.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Yolcubiletal yba = new Yolcubiletal(); 
            yba.Show();
            this.Hide();
            MessageBox.Show("Yolcu bilgileri güncellendi. Kontrol ediniz.");
        }
    }
}