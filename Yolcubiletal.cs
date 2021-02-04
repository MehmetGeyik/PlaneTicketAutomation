using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Uçak_Bileti_Otomasyonu
{
    public partial class Yolcubiletal : Form
    {
        public Yolcubiletal()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-54QD0V8\\SQLEXPRESS;Initial Catalog=ucakbiletotomasyonu;Integrated Security=True");
      

        Button tiklanan;
        private object cmbKategori;
        private object cmbSınıf;

        private void Koltuk_Click1(object sender, EventArgs e)
        {
            tiklanan = sender as Button;

        }

      
        private void BtnEkle_ClickYolcu(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into yolcu (Ad,Soyad,Tc,Telefon,Cinsiyet,Koltuk,Havayolu,Nereden,Nereye,Sınıf,Kategori) values (@Adi,@Soyadi,@Tcsi,@Telefonu,@Cinsiyeti,@Koltugu,@Havayolu,@Nereden,@Nereye,@Sınıf,@Kategori)", baglantı);
            komut.Parameters.AddWithValue("@Adi", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyadi", textBox2.Text);
            komut.Parameters.AddWithValue("@Tcsi", textBox3.Text);
            komut.Parameters.AddWithValue("@Telefonu", textBox4.Text);
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@Cinsiyeti", radioButton1.Text);
                tiklanan.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@Cinsiyeti", radioButton2.Text);
                tiklanan.BackColor = Color.Pink;
            }
            komut.Parameters.AddWithValue("@Koltugu", tiklanan.Text);
            komut.Parameters.AddWithValue("@Havayolu", cmbHavayolu.Text);
            komut.Parameters.AddWithValue("@Nereden", cmbNereden.Text);
            komut.Parameters.AddWithValue("@Nereye", cmbNereye.Text);
            komut.Parameters.AddWithValue("@Sınıf", comboBox2.Text);
            komut.Parameters.AddWithValue("@Kategori", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Bilet rezerve edilmiştir.");
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Otomasyon o = new Otomasyon();
            o.Show();
            this.Hide();
        }

        private void Yolcubiletal_Load(object sender, EventArgs e)
        {

        }

        private void CmbHavayolu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmbHavayolu.Text)
            {
                case "THY":
                    KoltukDoldur(15);
                    break;
                case "Anadolujet":
                    KoltukDoldur(13);
                    break;
                case "Pegasus":
                    KoltukDoldur(12);
                    break;

                default:
                    break;
            }
        }
        void KoltukDoldur(int sira)
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Satın Al" || btn.Text == "")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j == 3)
                        continue;
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 600 + (j * 45);

                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;

                    koltuk.Click += Koltuk_Click1;

                    this.Controls.Add(koltuk);

                }
            }
        }
        int _yolcuBiletAlId{ get; set; }

        public int YolcuBiletAlId
        {
            get
            {
                return _yolcuBiletAlId;
            }
            set
            {
                _yolcuBiletAlId = value;
            }
        }
        public void Musteribiletal()
        {
            Console.WriteLine("Koltuk kaydı başarı", YolcuBiletAlId);
        }
    }
   
}
