namespace WindowsFormsApp16
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_uye_kaydi = new System.Windows.Forms.Button();
            this.btn_kitap_ekleme = new System.Windows.Forms.Button();
            this.btn_kitap_sil = new System.Windows.Forms.Button();
            this.btn_kitap_sorgusu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_uye_kaydi
            // 
            this.btn_uye_kaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uye_kaydi.ForeColor = System.Drawing.Color.Red;
            this.btn_uye_kaydi.Location = new System.Drawing.Point(100, 54);
            this.btn_uye_kaydi.Name = "btn_uye_kaydi";
            this.btn_uye_kaydi.Size = new System.Drawing.Size(193, 51);
            this.btn_uye_kaydi.TabIndex = 0;
            this.btn_uye_kaydi.Text = "ÜYE KAYIT";
            this.btn_uye_kaydi.UseVisualStyleBackColor = true;
            this.btn_uye_kaydi.Click += new System.EventHandler(this.btn_uye_kaydi_Click);
            // 
            // btn_kitap_ekleme
            // 
            this.btn_kitap_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_ekleme.ForeColor = System.Drawing.Color.Red;
            this.btn_kitap_ekleme.Location = new System.Drawing.Point(100, 132);
            this.btn_kitap_ekleme.Name = "btn_kitap_ekleme";
            this.btn_kitap_ekleme.Size = new System.Drawing.Size(193, 51);
            this.btn_kitap_ekleme.TabIndex = 0;
            this.btn_kitap_ekleme.Text = "KİTAP EKLE";
            this.btn_kitap_ekleme.UseVisualStyleBackColor = true;
            this.btn_kitap_ekleme.Click += new System.EventHandler(this.btn_kitap_ekleme_Click);
            // 
            // btn_kitap_sil
            // 
            this.btn_kitap_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_kitap_sil.Location = new System.Drawing.Point(381, 54);
            this.btn_kitap_sil.Name = "btn_kitap_sil";
            this.btn_kitap_sil.Size = new System.Drawing.Size(196, 51);
            this.btn_kitap_sil.TabIndex = 0;
            this.btn_kitap_sil.Text = "KİTAP SİL";
            this.btn_kitap_sil.UseVisualStyleBackColor = true;
            this.btn_kitap_sil.Click += new System.EventHandler(this.btn_kitap_sil_Click);
            // 
            // btn_kitap_sorgusu
            // 
            this.btn_kitap_sorgusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_sorgusu.ForeColor = System.Drawing.Color.Red;
            this.btn_kitap_sorgusu.Location = new System.Drawing.Point(381, 132);
            this.btn_kitap_sorgusu.Name = "btn_kitap_sorgusu";
            this.btn_kitap_sorgusu.Size = new System.Drawing.Size(196, 51);
            this.btn_kitap_sorgusu.TabIndex = 0;
            this.btn_kitap_sorgusu.Text = "KİTAP SORGUSU";
            this.btn_kitap_sorgusu.UseVisualStyleBackColor = true;
            this.btn_kitap_sorgusu.Click += new System.EventHandler(this.btn_kitap_sorgusu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 327);
            this.Controls.Add(this.btn_kitap_sorgusu);
            this.Controls.Add(this.btn_kitap_sil);
            this.Controls.Add(this.btn_kitap_ekleme);
            this.Controls.Add(this.btn_uye_kaydi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_uye_kaydi;
        private System.Windows.Forms.Button btn_kitap_ekleme;
        private System.Windows.Forms.Button btn_kitap_sil;
        private System.Windows.Forms.Button btn_kitap_sorgusu;
    }
}

