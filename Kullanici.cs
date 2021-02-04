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
using System.Data.Sql;

namespace Uçak_Bileti_Otomasyonu
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
           try {
                 SqlConnection mehmetbaglan = new SqlConnection();
                 mehmetbaglan.ConnectionString = "Data Source=DESKTOP-54QD0V8\\SQLEXPRESS;Initial Catalog=ucakbiletotomasyonu;Integrated Security=True";
                 mehmetbaglan.Open();
                 SqlParameter prm1 = new SqlParameter("@141", txtKullaniciadi.Text);
                 SqlParameter prm2 = new SqlParameter("@142", txtSifre.Text);
                 string sql = "";
                 sql = "SELECT * FROM calisan WHERE kulad = @141 AND sifre = @142";
                 SqlCommand cmd = new SqlCommand(sql, mehmetbaglan);
                 cmd.Parameters.Add(prm1);
                 cmd.Parameters.Add(prm2);

                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 if (dt.Rows.Count > 0)
                 {

                     lblDogrulama.Text = "Giriş Başarılı";
                     BiletAl bl = new BiletAl();
                     bl.Show();
                 }
                 else
                 {
                   
                    lblHata.Text = "HATA! Yanlış Kullanıcı Adı veya Şifre Girdiniz.";
                    return;
                }
                
                
                mehmetbaglan.Close();
             }

             catch(Exception ex)
             {
                 exHata.Text = ex.Message;
             }
            this.Hide();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Otomasyon o = new Otomasyon();
            o.Show();
            this.Hide();
        }
    }
}
