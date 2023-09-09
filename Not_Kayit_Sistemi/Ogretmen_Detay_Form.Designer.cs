namespace Not_Kayit_Sistemi
{
    partial class Ogretmen_Detay_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.soyad_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_txtbx = new System.Windows.Forms.TextBox();
            this.ogr_num_mskdtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sinav3_txtbx = new System.Windows.Forms.TextBox();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sinav2_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sinav1_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kalan_lbl = new System.Windows.Forms.Label();
            this.gecen_lbl = new System.Windows.Forms.Label();
            this.ortalama_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnot1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnot2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnot3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.derstabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notKayitDataSet = new Not_Kayit_Sistemi.NotKayitDataSet();
            this.ders_tabloTableAdapter = new Not_Kayit_Sistemi.NotKayitDataSetTableAdapters.ders_tabloTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derstabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kaydet_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.soyad_txtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ad_txtbx);
            this.groupBox1.Controls.Add(this.ogr_num_mskdtxtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(95, 158);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(139, 31);
            this.kaydet_btn.TabIndex = 6;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // soyad_txtbx
            // 
            this.soyad_txtbx.Location = new System.Drawing.Point(95, 116);
            this.soyad_txtbx.Name = "soyad_txtbx";
            this.soyad_txtbx.Size = new System.Drawing.Size(139, 26);
            this.soyad_txtbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // ad_txtbx
            // 
            this.ad_txtbx.Location = new System.Drawing.Point(95, 84);
            this.ad_txtbx.Name = "ad_txtbx";
            this.ad_txtbx.Size = new System.Drawing.Size(139, 26);
            this.ad_txtbx.TabIndex = 2;
            // 
            // ogr_num_mskdtxtbx
            // 
            this.ogr_num_mskdtxtbx.Location = new System.Drawing.Point(95, 52);
            this.ogr_num_mskdtxtbx.Mask = "0000";
            this.ogr_num_mskdtxtbx.Name = "ogr_num_mskdtxtbx";
            this.ogr_num_mskdtxtbx.Size = new System.Drawing.Size(139, 26);
            this.ogr_num_mskdtxtbx.TabIndex = 1;
            this.ogr_num_mskdtxtbx.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sinav3_txtbx);
            this.groupBox2.Controls.Add(this.guncelle_btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sinav2_txtbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sinav1_txtbx);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Düzenle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sınav3:";
            // 
            // sinav3_txtbx
            // 
            this.sinav3_txtbx.Location = new System.Drawing.Point(83, 116);
            this.sinav3_txtbx.Name = "sinav3_txtbx";
            this.sinav3_txtbx.Size = new System.Drawing.Size(139, 26);
            this.sinav3_txtbx.TabIndex = 7;
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(83, 158);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(139, 31);
            this.guncelle_btn.TabIndex = 6;
            this.guncelle_btn.Text = "Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav2:";
            // 
            // sinav2_txtbx
            // 
            this.sinav2_txtbx.Location = new System.Drawing.Point(83, 84);
            this.sinav2_txtbx.Name = "sinav2_txtbx";
            this.sinav2_txtbx.Size = new System.Drawing.Size(139, 26);
            this.sinav2_txtbx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav1:";
            // 
            // sinav1_txtbx
            // 
            this.sinav1_txtbx.Location = new System.Drawing.Point(83, 52);
            this.sinav1_txtbx.Name = "sinav1_txtbx";
            this.sinav1_txtbx.Size = new System.Drawing.Size(139, 26);
            this.sinav1_txtbx.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kalan_lbl);
            this.groupBox3.Controls.Add(this.gecen_lbl);
            this.groupBox3.Controls.Add(this.ortalama_lbl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(537, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ortalama";
            // 
            // kalan_lbl
            // 
            this.kalan_lbl.AutoSize = true;
            this.kalan_lbl.Location = new System.Drawing.Point(114, 119);
            this.kalan_lbl.Name = "kalan_lbl";
            this.kalan_lbl.Size = new System.Drawing.Size(28, 18);
            this.kalan_lbl.TabIndex = 5;
            this.kalan_lbl.Text = "00";
            // 
            // gecen_lbl
            // 
            this.gecen_lbl.AutoSize = true;
            this.gecen_lbl.Location = new System.Drawing.Point(114, 87);
            this.gecen_lbl.Name = "gecen_lbl";
            this.gecen_lbl.Size = new System.Drawing.Size(28, 18);
            this.gecen_lbl.TabIndex = 4;
            this.gecen_lbl.Text = "00";
            // 
            // ortalama_lbl
            // 
            this.ortalama_lbl.AutoSize = true;
            this.ortalama_lbl.Location = new System.Drawing.Point(114, 60);
            this.ortalama_lbl.Name = "ortalama_lbl";
            this.ortalama_lbl.Size = new System.Drawing.Size(28, 18);
            this.ortalama_lbl.TabIndex = 3;
            this.ortalama_lbl.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 283);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrnumaraDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrnot1DataGridViewTextBoxColumn,
            this.ogrnot2DataGridViewTextBoxColumn,
            this.ogrnot3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.derstabloBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogr_id";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogr_id";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrnumaraDataGridViewTextBoxColumn
            // 
            this.ogrnumaraDataGridViewTextBoxColumn.DataPropertyName = "ogr_numara";
            this.ogrnumaraDataGridViewTextBoxColumn.HeaderText = "ogr_numara";
            this.ogrnumaraDataGridViewTextBoxColumn.Name = "ogrnumaraDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ogr_ad";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ogr_ad";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogr_soyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogr_soyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrnot1DataGridViewTextBoxColumn
            // 
            this.ogrnot1DataGridViewTextBoxColumn.DataPropertyName = "ogr_not1";
            this.ogrnot1DataGridViewTextBoxColumn.HeaderText = "ogr_not1";
            this.ogrnot1DataGridViewTextBoxColumn.Name = "ogrnot1DataGridViewTextBoxColumn";
            // 
            // ogrnot2DataGridViewTextBoxColumn
            // 
            this.ogrnot2DataGridViewTextBoxColumn.DataPropertyName = "ogr_not2";
            this.ogrnot2DataGridViewTextBoxColumn.HeaderText = "ogr_not2";
            this.ogrnot2DataGridViewTextBoxColumn.Name = "ogrnot2DataGridViewTextBoxColumn";
            // 
            // ogrnot3DataGridViewTextBoxColumn
            // 
            this.ogrnot3DataGridViewTextBoxColumn.DataPropertyName = "ogr_not3";
            this.ogrnot3DataGridViewTextBoxColumn.HeaderText = "ogr_not3";
            this.ogrnot3DataGridViewTextBoxColumn.Name = "ogrnot3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // derstabloBindingSource
            // 
            this.derstabloBindingSource.DataMember = "ders_tablo";
            this.derstabloBindingSource.DataSource = this.notKayitDataSet;
            // 
            // notKayitDataSet
            // 
            this.notKayitDataSet.DataSetName = "NotKayitDataSet";
            this.notKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ders_tabloTableAdapter
            // 
            this.ders_tabloTableAdapter.ClearBeforeFill = true;
            // 
            // Ogretmen_Detay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ogretmen_Detay_Form";
            this.Text = "Ogretmen_Detay_Form";
            this.Load += new System.EventHandler(this.Ogretmen_Detay_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derstabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyad_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad_txtbx;
        private System.Windows.Forms.MaskedTextBox ogr_num_mskdtxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sinav3_txtbx;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sinav2_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sinav1_txtbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label kalan_lbl;
        private System.Windows.Forms.Label gecen_lbl;
        private System.Windows.Forms.Label ortalama_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotKayitDataSet notKayitDataSet;
        private System.Windows.Forms.BindingSource derstabloBindingSource;
        private NotKayitDataSetTableAdapters.ders_tabloTableAdapter ders_tabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnot1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnot2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnot3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}