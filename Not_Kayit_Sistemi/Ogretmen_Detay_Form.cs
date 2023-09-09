using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class Ogretmen_Detay_Form : Form
    {
        public Ogretmen_Detay_Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RGQV57Q;Initial Catalog=NotKayit;Integrated Security=True");

        private void Ogretmen_Detay_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notKayitDataSet.ders_tablo' table. You can move, or remove it, as needed.
            this.ders_tabloTableAdapter.Fill(this.notKayitDataSet.ders_tablo);
            try
            {
                baglanti.Open();
                int kalan = 0, gecen = 0;
                SqlCommand komut = new SqlCommand("Select * from ders_tablo", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["durum"].ToString() == "True")
                    {
                        gecen++;
                    }
                    else
                    {
                        kalan++;
                    }
                }

                gecen_lbl.Text = gecen.ToString();
                kalan_lbl.Text = kalan.ToString();

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

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sql_command =
                    new SqlCommand(
                        "Insert into ders_tablo (ogr_numara,ogr_ad,ogr_soyad) values (@ogrnum,@ograd,@ogrsoyad)",
                        baglanti);
                sql_command.Parameters.AddWithValue("@ogrnum", ogr_num_mskdtxtbx.Text);
                sql_command.Parameters.AddWithValue("@ograd", ad_txtbx.Text);
                sql_command.Parameters.AddWithValue("@ogrsoyad", soyad_txtbx.Text);
                int a = sql_command.ExecuteNonQuery();
                //MessageBox.Show(a.ToString());
                if (a>0)
                {
                    MessageBox.Show("Öğrenci Sisteme Eklendi");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu");
                }
                this.ders_tabloTableAdapter.Fill(this.notKayitDataSet.ders_tablo);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            ogr_num_mskdtxtbx.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad_txtbx.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad_txtbx.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            sinav1_txtbx.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sinav2_txtbx.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sinav3_txtbx.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            ortalama_lbl.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(sinav1_txtbx.Text);
            s2 = Convert.ToDouble(sinav2_txtbx.Text);
            s3 = Convert.ToDouble(sinav3_txtbx.Text);
            ortalama = (s1 + s2 + s3) / 3;
            ortalama_lbl.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                durum = "True";

            }
            else
            {
                durum = "False";
            }

            try
            {
                baglanti.Open();
                SqlCommand sql_command =
                    new SqlCommand(
                        "UPDATE ders_tablo set ogr_not1=@ogrnot1,ogr_not2=@ogrnot2,ogr_not3=@ogrnot3,ortalama=@ort,durum=@drm where ogr_numara=@ogrnum",
                        baglanti);
                sql_command.Parameters.AddWithValue("@ogrnot1", sinav1_txtbx.Text);
                sql_command.Parameters.AddWithValue("@ogrnot2", sinav2_txtbx.Text);
                sql_command.Parameters.AddWithValue("@ogrnot3", sinav3_txtbx.Text);
                sql_command.Parameters.AddWithValue("@ort", decimal.Parse(ortalama_lbl.Text));
                sql_command.Parameters.AddWithValue("@drm", durum);
                sql_command.Parameters.AddWithValue("@ogrnum", ogr_num_mskdtxtbx.Text);
                sql_command.ExecuteNonQuery();
                MessageBox.Show("Notlar Güncellendi");
                this.ders_tabloTableAdapter.Fill(this.notKayitDataSet.ders_tablo);

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
