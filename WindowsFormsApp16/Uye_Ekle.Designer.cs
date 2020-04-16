namespace WindowsFormsApp16
{
    partial class Uye_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uye_Ekle));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_uye_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_uye_telno = new System.Windows.Forms.TextBox();
            this.txt_uye_tckimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(263, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "KAYIT ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_uye_adsoyad
            // 
            this.txt_uye_adsoyad.Location = new System.Drawing.Point(131, 40);
            this.txt_uye_adsoyad.Multiline = true;
            this.txt_uye_adsoyad.Name = "txt_uye_adsoyad";
            this.txt_uye_adsoyad.Size = new System.Drawing.Size(117, 34);
            this.txt_uye_adsoyad.TabIndex = 1;
            // 
            // txt_uye_telno
            // 
            this.txt_uye_telno.Location = new System.Drawing.Point(311, 138);
            this.txt_uye_telno.Multiline = true;
            this.txt_uye_telno.Name = "txt_uye_telno";
            this.txt_uye_telno.Size = new System.Drawing.Size(117, 34);
            this.txt_uye_telno.TabIndex = 1;
            // 
            // txt_uye_tckimlik
            // 
            this.txt_uye_tckimlik.Location = new System.Drawing.Point(447, 40);
            this.txt_uye_tckimlik.Multiline = true;
            this.txt_uye_tckimlik.Name = "txt_uye_tckimlik";
            this.txt_uye_tckimlik.Size = new System.Drawing.Size(117, 34);
            this.txt_uye_tckimlik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "AD-SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(333, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC KİMLİK NO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(197, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON NO.";
            // 
            // Uye_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_uye_tckimlik);
            this.Controls.Add(this.txt_uye_telno);
            this.Controls.Add(this.txt_uye_adsoyad);
            this.Controls.Add(this.button1);
            this.Name = "Uye_Ekle";
            this.Text = "Uye_Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_uye_adsoyad;
        private System.Windows.Forms.TextBox txt_uye_telno;
        private System.Windows.Forms.TextBox txt_uye_tckimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}