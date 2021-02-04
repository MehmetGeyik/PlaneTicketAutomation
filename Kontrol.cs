using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bileti_Otomasyonu
{
    class Kontrol
    {
        public bool kontrolEt(ComboBox comboBox1,ComboBox comboBox2,TextBox textBox1,TextBox textBox2,TextBox textBox3,TextBox textBox4)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Öncelikle Kategori Seçin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Boş alanları doldurun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            else
                return false;
        }        
    }
}
