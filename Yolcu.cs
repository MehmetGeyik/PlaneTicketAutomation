using System.Data;

namespace Uçak_Bileti_Otomasyonu
{
    public class Yolcu
    {
        private string ad;
        private string soyad;
        private string tcNo;
        private string cepTel;
        private string sınıf;
        private string koltukNo;
        private string havayolu;
        private string nereden;
        private string nereye;
        private string cinsiyet;
        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string TcNo
        {
            get
            {
                return tcNo;
            }

            set
            {
                tcNo = value;
            }
        }

        public string CepTel
        {
            get
            {
                return cepTel;
            }

            set
            {
                cepTel = value;
            }
        }

       


        public string Sınıf
        {
            get
            {
                return sınıf;
            }

            set
            {
                sınıf = value;
            }
        }

        public string KoltukNo
        {
            get
            {
                return koltukNo;
            }

            set
            {
                koltukNo = value;
            }
        }

        public string Havayolu
        {
            get
            {
                return havayolu;
            }

            set
            {
                havayolu = value;
            }
        }

        public string Nereden
        {
            get
            {
                return nereden;
            }

            set
            {
                nereden = value;
            }
        }

        public string Nereye
        {
            get
            {
                return nereye;
            }

            set
            {
                nereye = value;
            }
        }

        public string Cinsiyet
        {
            get
            {
                return cinsiyet;
            }

            set
            {
                cinsiyet = value;
            }
        }

        public static string dosyaYol = "Bilet.xml";
        private DataSet dSetBiletler = new DataSet("Bilet Listesi");
        private DataTable dtBilet = new DataTable("Bilet");

        public Yolcu()
        {
            DataSetOlustur();
        }

        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYol))
            {
                dSetBiletler.ReadXml(dosyaYol);
                dtBilet = dSetBiletler.Tables[0];
            }
            else
            {
                dtBilet.Columns.Add("KoltukNo:");
                dtBilet.Columns.Add("Adi:");
                dtBilet.Columns.Add("Soyadi:");
                dtBilet.Columns.Add("Tc No:");
                dtBilet.Columns.Add("Cep Tel:");
                dtBilet.Columns.Add("Kategori:");
                dtBilet.Columns.Add("Sınıf:");
                dtBilet.Columns.Add("Havayolu:");
                dtBilet.Columns.Add("Nereden");
                dtBilet.Columns.Add("Nereye");
                dtBilet.Columns.Add("Cinsiyet:");

                dSetBiletler.Tables.Add(dtBilet);
                dSetBiletler.WriteXml(dosyaYol, XmlWriteMode.WriteSchema);
            }

        }
        public void BiletEkle(string Kategori)
        {
            DataRow row = dtBilet.NewRow();
            row["KoltukNo:"] = KoltukNo;
            row["Adi:"]=Ad;
            row["Soyadi:"] = Soyad;
            row["Tc No:"] = TcNo;
            row["Cep Tel:"] = CepTel;
            row["Kategori:"] = Kategori;
            row["Sınıf:"] = Sınıf;
            row["Havayolu:"] = Havayolu;
            row["Nereden:"] = Nereden;
            row["Nereye:"] = Nereye;
            row["Cinsiyet:"] = Cinsiyet;
            dtBilet.Rows.Add(row);
            dSetBiletler.WriteXml(dosyaYol,XmlWriteMode.WriteSchema);
        }
        public DataTable BiletListesiGetir()
        {

            return dtBilet;
        }

        public void BiletEkle(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dSetBiletler.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dtBilet = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dSetBiletler.Tables.Add(dtBilet);

            dSetBiletler.WriteXml(dosyaYol, XmlWriteMode.WriteSchema);
        }
        public void satırSil(int a)
        {
            
            
            dtBilet.Rows[a].Delete();
            dtBilet.AcceptChanges();
            
            dSetBiletler.WriteXml(dosyaYol, XmlWriteMode.WriteSchema);

        }

       
    }
}
