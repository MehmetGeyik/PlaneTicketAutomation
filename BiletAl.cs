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
    public partial class BiletAl : Form
    {

        public BiletAl()
        {
            InitializeComponent();

        }

      

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-54QD0V8\\SQLEXPRESS;Initial Catalog=ucakbiletotomasyonu;Integrated Security=True");
        private void verilerigoruntule(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void BiletAl_Load(object sender, EventArgs e)
        {
            Singleton nesne1 = Singleton.NesneVer();
            Singleton nesne2 = Singleton.NesneVer();
            if (nesne1.GetHashCode() == nesne2.GetHashCode())
            {
                MessageBox.Show("Giriş yapıldı.");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            // TODO: Bu kod satırı 'ucakbiletotomasyonuDataSet3.yolcu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yolcuTableAdapter2.Fill(this.ucakbiletotomasyonuDataSet3.yolcu);
            
          

            comboBox1.Items.Add("Yetişkin");
            comboBox1.Items.Add("Öğrenci");
            comboBox1.Items.Add("Çocuk");
            comboBox1.Items.Add("Yaşlı");
            comboBox2.Items.Add("Business");
            comboBox2.Items.Add("Ekonomik");
            Listele();

            

        }

        
        private void Listele()
        {
            Yolcu b = new Yolcu();
            DataTable dt = b.BiletListesiGetir();
            dataGridView1.DataSource = dt;

        }

        

        private void textBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
            }
        }

        private void textBox2_keyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
            }
        }
        
        

        private void textBox3_keyPress(object sender, KeyPressEventArgs e)
        { 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox4_keyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from yolcu where Tc=@Tcsi", baglantı);
            komut.Parameters.AddWithValue("@Tcsi", textBox3.Text);
            komut.ExecuteNonQuery();
            verilerigoruntule("Select *from yolcu");
            baglantı.Close();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from yolcu where Tc like '%" + textBox3.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Otomasyon o = new Otomasyon();
            o.Show();
            this.Hide();
        }

        private void cmbHavayolu_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (btn.Text == "Göster" || btn.Text == "Ekle" || btn.Text == "Sil" || btn.Text == "Arama"||btn.Text=="Güncelle" || btn.Text == "")
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

                    koltuk.Click += Koltuk_Click;

                    this.Controls.Add(koltuk);
                    
                }
            }
            
        }

        Button tiklanan;
        private object cmbKategori;
        private object cmbSınıf;
        
        private void Koltuk_Click(object sender, EventArgs e)
        {
            tiklanan = sender as Button;

        }

        public void btnEkle_Click(object sender, EventArgs e)
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
            verilerigoruntule("Select *from yolcu");
            baglantı.Close();
            MessageBox.Show("Bilet kayıt edildi.");
        }

        public int BiletId { get; set; }
        public void Personelbiletal()
        {
            Console.WriteLine("Personel Yolcu kaydı başarılı",BiletId);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            verilerigoruntule("Select *from yolcu");
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         DataTable yenile()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from yolcu", baglantı);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglantı.Close();
            return tablo;
        } 
        private void Button5_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update yolcu set Ad='"+textBox1.Text+"', Soyad='"+textBox2.Text+ "', Telefon='" +textBox4.Text+ "', Havayolu='" +cmbHavayolu.Text+ "', Nereden='" +cmbNereden.Text+ "', Nereye='" +cmbNereye.Text+ "',Koltuk='" +tiklanan.Text + "', Sınıf='" + comboBox2.Text+ "', Kategori='" +comboBox1.Text+ "' where Tc='" +textBox3.Text+ "'", baglantı);
            komut.ExecuteNonQuery();
            verilerigoruntule("select *from yolcu");
            MessageBox.Show("Güncellendi");
            baglantı.Close();
            dataGridView1.DataSource = yenile();

            /*  baglantı.Open();
            SqlCommand komut = new SqlCommand("update bilgiler set (Ad,Soyad,Tc,Telefon,Cinsiyet,Koltuk,Havayolu,Nereden,Nereye,Sınıf,Kategori) values (@Adi,@Soyadi,@Tcsi,@Telefonu,@Cinsiyeti,@Koltugu,@Havayolu,@Nereden,@Nereye,@Sınıf,@Kategori)", baglantı);

            string Ad,Soyad,Tc,Telefon,Cinsiyet,Koltuk,Havayolu,Nereden,Nereye,Sınıf,Kategori;
            Ad = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            Soyad = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            Tc = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            Koltuk = dataGridView1.CurrentRow.Cells["Koltuk"].Value.ToString(); 
            komut.ExecuteNonQuery();
            baglantı.Close();
            dataGridView1.DataSource = yenile();
            MessageBox.Show("Güncellendi"); */
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string Ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Soyad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Tc = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Telefon = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Cinsiyet = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string Koltuk = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string Havayolu = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string Nereden  = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string Nereye = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string Sınıf = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
            string Kategori = dataGridView1.Rows[secilialan].Cells[10].Value.ToString();
            textBox1.Text = Ad;
            textBox2.Text = Soyad;
            textBox3.Text = Tc;
            textBox4.Text = Telefon;
            radioButton1.Text = Cinsiyet;
            radioButton2.Text = Cinsiyet;
            
            cmbHavayolu.Text = Havayolu;
            cmbNereden.Text = Nereden;
            cmbNereye.Text = Nereye;
            comboBox2.Text = Sınıf;
            comboBox1.Text = Kategori;
        }
    }
    }

