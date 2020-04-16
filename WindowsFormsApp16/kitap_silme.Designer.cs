namespace WindowsFormsApp16
{
    partial class kitap_silme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_silme));
            this.btn_kitap_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitap_sil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kitap_sil
            // 
            this.btn_kitap_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitap_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_kitap_sil.Location = new System.Drawing.Point(217, 174);
            this.btn_kitap_sil.Name = "btn_kitap_sil";
            this.btn_kitap_sil.Size = new System.Drawing.Size(119, 37);
            this.btn_kitap_sil.TabIndex = 0;
            this.btn_kitap_sil.Text = "SİL";
            this.btn_kitap_sil.UseVisualStyleBackColor = true;
            this.btn_kitap_sil.Click += new System.EventHandler(this.btn_kitap_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP ADI";
            // 
            // txt_kitap_sil
            // 
            this.txt_kitap_sil.Location = new System.Drawing.Point(200, 77);
            this.txt_kitap_sil.Multiline = true;
            this.txt_kitap_sil.Name = "txt_kitap_sil";
            this.txt_kitap_sil.Size = new System.Drawing.Size(152, 45);
            this.txt_kitap_sil.TabIndex = 2;
            // 
            // kitap_silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(617, 332);
            this.Controls.Add(this.txt_kitap_sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kitap_sil);
            this.Name = "kitap_silme";
            this.Text = "kitap_silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitap_sil;
    }
}