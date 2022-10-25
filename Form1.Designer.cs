
namespace OziCrm
{
    partial class Form1
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
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.tb_Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Dogumyili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(149, 38);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(100, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Location = new System.Drawing.Point(63, 143);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(35, 13);
            this.lbl_Sonuc.TabIndex = 2;
            this.lbl_Sonuc.Text = "label2";
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.Location = new System.Drawing.Point(184, 116);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_Yazdir.TabIndex = 3;
            this.btn_Yazdir.Text = "Yazdır";
            this.btn_Yazdir.UseVisualStyleBackColor = true;
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // tb_Soyad
            // 
            this.tb_Soyad.Location = new System.Drawing.Point(149, 64);
            this.tb_Soyad.Name = "tb_Soyad";
            this.tb_Soyad.Size = new System.Drawing.Size(100, 20);
            this.tb_Soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim";
            // 
            // tb_Dogumyili
            // 
            this.tb_Dogumyili.Location = new System.Drawing.Point(149, 90);
            this.tb_Dogumyili.Name = "tb_Dogumyili";
            this.tb_Dogumyili.Size = new System.Drawing.Size(100, 20);
            this.tb_Dogumyili.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doğum Yılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Dogumyili);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Soyad);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_isim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Windows.Forms.TextBox tb_Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Dogumyili;
        private System.Windows.Forms.Label label3;
    }
}

