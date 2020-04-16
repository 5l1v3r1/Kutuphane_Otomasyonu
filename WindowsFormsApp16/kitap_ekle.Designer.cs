namespace WindowsFormsApp16
{
    partial class kitap_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_ekle));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.txt_kitapyazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kitapsayfasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_basimyili = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Red;
            this.btn_ekle.Location = new System.Drawing.Point(246, 241);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(179, 36);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP ADI";
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(141, 42);
            this.txt_kitapad.Multiline = true;
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(142, 40);
            this.txt_kitapad.TabIndex = 2;
            // 
            // txt_kitapyazari
            // 
            this.txt_kitapyazari.Location = new System.Drawing.Point(141, 146);
            this.txt_kitapyazari.Multiline = true;
            this.txt_kitapyazari.Name = "txt_kitapyazari";
            this.txt_kitapyazari.Size = new System.Drawing.Size(142, 40);
            this.txt_kitapyazari.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "KİTAP YAZARI";
            // 
            // txt_kitapsayfasi
            // 
            this.txt_kitapsayfasi.Location = new System.Drawing.Point(452, 42);
            this.txt_kitapsayfasi.Multiline = true;
            this.txt_kitapsayfasi.Name = "txt_kitapsayfasi";
            this.txt_kitapsayfasi.Size = new System.Drawing.Size(142, 40);
            this.txt_kitapsayfasi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(328, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "KİTAP SAYFASI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(351, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "BASIM YILI";
            // 
            // txt_basimyili
            // 
            this.txt_basimyili.Location = new System.Drawing.Point(452, 146);
            this.txt_basimyili.Multiline = true;
            this.txt_basimyili.Name = "txt_basimyili";
            this.txt_basimyili.Size = new System.Drawing.Size(142, 40);
            this.txt_basimyili.TabIndex = 2;
            // 
            // kitap_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 330);
            this.Controls.Add(this.txt_basimyili);
            this.Controls.Add(this.txt_kitapsayfasi);
            this.Controls.Add(this.txt_kitapyazari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kitapad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Name = "kitap_ekle";
            this.Text = "kitap_eklecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.TextBox txt_kitapyazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kitapsayfasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_basimyili;
    }
}