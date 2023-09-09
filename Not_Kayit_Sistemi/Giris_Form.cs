using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class Giris_Form : Form
    {
        public Giris_Form()
        {
            InitializeComponent();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            Ogrenci_Detay_Form a = new Ogrenci_Detay_Form();
            a.numara = ogr_num_maskedtextbox.Text;
            a.Show();
        }

        
        private void Giris_Form_Load(object sender, EventArgs e)
        {

        }

        private void ogr_num_maskedtextbox_TextChanged(object sender, EventArgs e)
        {
            if (ogr_num_maskedtextbox.Text=="1111")
            {
                Ogretmen_Detay_Form b = new Ogretmen_Detay_Form();
                b.Show();
            }
        }
    }
}
