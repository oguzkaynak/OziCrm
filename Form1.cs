﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OziCrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            string isim = tb_isim.Text;
            string Soyad = tb_Soyad.Text;
            int dogumyili = Convert.ToInt32(tb_Dogumyili.Text);
            int Yas = 2022 - dogumyili;
            lbl_Sonuc.Text = isim + " " + Soyad + " " + Yas;
        }
    }
}
