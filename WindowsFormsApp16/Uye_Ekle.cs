﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Uye_Ekle : Form
    {
        public Uye_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyeler uye = new Uyeler();
            string str = Convert.ToString(txt_uye_adsoyad);
            string str2 = Convert.ToString(txt_uye_telno);
            string str3 = Convert.ToString(txt_uye_tckimlik);
            uye.uye_kayit(str,str2,str3);

        }
    }
}
