namespace WindowsFormsApp16
{
    partial class kitap_sorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_sorgu));
            this.btn_teslim_tamam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teslimedilen_kitap = new System.Windows.Forms.TextBox();
            this.txt_teslimalankisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_teslimi_sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_teslim_tamam
            // 
            this.btn_teslim_tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslim_tamam.ForeColor = System.Drawing.Color.Red;
            this.btn_teslim_tamam.Location = new System.Drawing.Point(53, 180);
            this.btn_teslim_tamam.Name = "btn_teslim_tamam";
            this.btn_teslim_tamam.Size = new System.Drawing.Size(129, 37);
            this.btn_teslim_tamam.TabIndex = 0;
            this.btn_teslim_tamam.Text = "TAMAM";
            this.btn_teslim_tamam.UseVisualStyleBackColor = true;
            this.btn_teslim_tamam.Click += new System.EventHandler(this.btn_teslim_tamam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TESLİM EDİLEN KİTAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TESLİM ALAN KİŞİ";
            // 
            // txt_teslimedilen_kitap
            // 
            this.txt_teslimedilen_kitap.Location = new System.Drawing.Point(60, 56);
            this.txt_teslimedilen_kitap.Multiline = true;
            this.txt_teslimedilen_kitap.Name = "txt_teslimedilen_kitap";
            this.txt_teslimedilen_kitap.Size = new System.Drawing.Size(122, 30);
            this.txt_teslimedilen_kitap.TabIndex = 3;
            // 
            // txt_teslimalankisi
            // 
            this.txt_teslimalankisi.Location = new System.Drawing.Point(56, 126);
            this.txt_teslimalankisi.Multiline = true;
            this.txt_teslimalankisi.Name = "txt_teslimalankisi";
            this.txt_teslimalankisi.Size = new System.Drawing.Size(122, 31);
            this.txt_teslimalankisi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(359, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SORGULANACAK KİTAP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 30);
            this.textBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 95);
            this.listBox1.TabIndex = 7;
            // 
            // btn_teslimi_sorgula
            // 
            this.btn_teslimi_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslimi_sorgula.ForeColor = System.Drawing.Color.Red;
            this.btn_teslimi_sorgula.Location = new System.Drawing.Point(384, 97);
            this.btn_teslimi_sorgula.Name = "btn_teslimi_sorgula";
            this.btn_teslimi_sorgula.Size = new System.Drawing.Size(129, 33);
            this.btn_teslimi_sorgula.TabIndex = 8;
            this.btn_teslimi_sorgula.Text = "SORGULA";
            this.btn_teslimi_sorgula.UseVisualStyleBackColor = true;
            // 
            // kitap_sorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 329);
            this.Controls.Add(this.btn_teslimi_sorgula);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teslimalankisi);
            this.Controls.Add(this.txt_teslimedilen_kitap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_teslim_tamam);
            this.Name = "kitap_sorgu";
            this.Text = "kitap_sorgu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_teslim_tamam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teslimedilen_kitap;
        private System.Windows.Forms.TextBox txt_teslimalankisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_teslimi_sorgula;
    }
}