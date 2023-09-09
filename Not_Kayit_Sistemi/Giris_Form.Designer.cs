namespace Not_Kayit_Sistemi
{
    partial class Giris_Form
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
            this.ogr_num_lbl = new System.Windows.Forms.Label();
            this.ogr_num_maskedtextbox = new System.Windows.Forms.MaskedTextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogr_num_lbl
            // 
            this.ogr_num_lbl.AutoSize = true;
            this.ogr_num_lbl.Location = new System.Drawing.Point(12, 58);
            this.ogr_num_lbl.Name = "ogr_num_lbl";
            this.ogr_num_lbl.Size = new System.Drawing.Size(134, 18);
            this.ogr_num_lbl.TabIndex = 0;
            this.ogr_num_lbl.Text = "Öğrenci Numara :";
            // 
            // ogr_num_maskedtextbox
            // 
            this.ogr_num_maskedtextbox.Location = new System.Drawing.Point(162, 55);
            this.ogr_num_maskedtextbox.Mask = "0000";
            this.ogr_num_maskedtextbox.Name = "ogr_num_maskedtextbox";
            this.ogr_num_maskedtextbox.Size = new System.Drawing.Size(100, 26);
            this.ogr_num_maskedtextbox.TabIndex = 1;
            this.ogr_num_maskedtextbox.ValidatingType = typeof(int);
            this.ogr_num_maskedtextbox.TextChanged += new System.EventHandler(this.ogr_num_maskedtextbox_TextChanged);
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(162, 96);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(100, 28);
            this.giris_btn.TabIndex = 2;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // Giris_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 145);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.ogr_num_maskedtextbox);
            this.Controls.Add(this.ogr_num_lbl);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris_Form";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Giris_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogr_num_lbl;
        private System.Windows.Forms.MaskedTextBox ogr_num_maskedtextbox;
        private System.Windows.Forms.Button giris_btn;
    }
}

