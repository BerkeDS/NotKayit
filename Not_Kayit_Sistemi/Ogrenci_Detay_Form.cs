using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class Ogrenci_Detay_Form : Form
    {
        public Ogrenci_Detay_Form()
        {
            InitializeComponent();
        }

        private SqlConnection baglanti =
            new SqlConnection(@"Data Source=DESKTOP-RGQV57Q;Initial Catalog=NotKayit;Integrated Security=True");
        
        public string numara;
        private void Ogrenci_Detay_Form_Load(object sender, EventArgs e)
        {
            ogr_numara_lbl.Text = numara;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from ders_tablo where ogr_numara=@ogrnumara",baglanti);
                komut.Parameters.AddWithValue("@ogrnumara", numara);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    ogr_ad_soyad_lbl.Text = dr[2].ToString() + " " + dr[3].ToString();
                    sinav1_lbl.Text = dr[4].ToString();
                    sinav2_lbl.Text = dr[5].ToString();
                    sinav3_lbl.Text = dr[6].ToString();
                    ortalama_lbl.Text = dr[7].ToString();
                    //durum_lbl.Text = dr[8].ToString();
                    if (dr[8].ToString()=="True")
                    {
                        durum_lbl.Text = "Geçti";
                    }
                    else
                    {
                        durum_lbl.Text = "Kaldı";
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
