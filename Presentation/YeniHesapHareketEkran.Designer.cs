namespace Presentation
{
    partial class YeniHesapHareketEkran
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_CariHesap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nm_Tutar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_NakitTediye = new System.Windows.Forms.RadioButton();
            this.rb_NakitTahsilat = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_islemtarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_vadetarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nm_vadegun = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_EvrakCins = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_EvrakTip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EvrakNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_vadegun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Hesap:";
            // 
            // cmb_CariHesap
            // 
            this.cmb_CariHesap.FormattingEnabled = true;
            this.cmb_CariHesap.Location = new System.Drawing.Point(193, 39);
            this.cmb_CariHesap.Name = "cmb_CariHesap";
            this.cmb_CariHesap.Size = new System.Drawing.Size(351, 37);
            this.cmb_CariHesap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar:";
            // 
            // nm_Tutar
            // 
            this.nm_Tutar.Location = new System.Drawing.Point(193, 94);
            this.nm_Tutar.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nm_Tutar.Name = "nm_Tutar";
            this.nm_Tutar.Size = new System.Drawing.Size(149, 35);
            this.nm_Tutar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "İşlem:";
            // 
            // rb_NakitTediye
            // 
            this.rb_NakitTediye.AutoSize = true;
            this.rb_NakitTediye.Location = new System.Drawing.Point(193, 147);
            this.rb_NakitTediye.Name = "rb_NakitTediye";
            this.rb_NakitTediye.Size = new System.Drawing.Size(172, 33);
            this.rb_NakitTediye.TabIndex = 6;
            this.rb_NakitTediye.TabStop = true;
            this.rb_NakitTediye.Text = "Nakit Tediye";
            this.rb_NakitTediye.UseVisualStyleBackColor = true;
            // 
            // rb_NakitTahsilat
            // 
            this.rb_NakitTahsilat.AutoSize = true;
            this.rb_NakitTahsilat.Location = new System.Drawing.Point(394, 147);
            this.rb_NakitTahsilat.Name = "rb_NakitTahsilat";
            this.rb_NakitTahsilat.Size = new System.Drawing.Size(185, 33);
            this.rb_NakitTahsilat.TabIndex = 7;
            this.rb_NakitTahsilat.TabStop = true;
            this.rb_NakitTahsilat.Text = "Nakit Tahsilat";
            this.rb_NakitTahsilat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşlem Tarihi:";
            // 
            // dtp_islemtarih
            // 
            this.dtp_islemtarih.Location = new System.Drawing.Point(193, 198);
            this.dtp_islemtarih.Name = "dtp_islemtarih";
            this.dtp_islemtarih.Size = new System.Drawing.Size(386, 35);
            this.dtp_islemtarih.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vade Tarihi:";
            // 
            // dtp_vadetarih
            // 
            this.dtp_vadetarih.Location = new System.Drawing.Point(193, 251);
            this.dtp_vadetarih.Name = "dtp_vadetarih";
            this.dtp_vadetarih.Size = new System.Drawing.Size(386, 35);
            this.dtp_vadetarih.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vade Günü:";
            // 
            // nm_vadegun
            // 
            this.nm_vadegun.Location = new System.Drawing.Point(193, 304);
            this.nm_vadegun.Name = "nm_vadegun";
            this.nm_vadegun.Size = new System.Drawing.Size(149, 35);
            this.nm_vadegun.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_EvrakCins);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_EvrakTip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_EvrakNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(624, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 305);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evraklar";
            // 
            // cmb_EvrakCins
            // 
            this.cmb_EvrakCins.FormattingEnabled = true;
            this.cmb_EvrakCins.Items.AddRange(new object[] {
            "Fatura",
            "Dekont"});
            this.cmb_EvrakCins.Location = new System.Drawing.Point(10, 254);
            this.cmb_EvrakCins.Name = "cmb_EvrakCins";
            this.cmb_EvrakCins.Size = new System.Drawing.Size(242, 37);
            this.cmb_EvrakCins.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Evrak Cinsi:";
            // 
            // cmb_EvrakTip
            // 
            this.cmb_EvrakTip.FormattingEnabled = true;
            this.cmb_EvrakTip.Items.AddRange(new object[] {
            "Alış faturası",
            "Alacak dekontu",
            "Borç dekontu"});
            this.cmb_EvrakTip.Location = new System.Drawing.Point(10, 170);
            this.cmb_EvrakTip.Name = "cmb_EvrakTip";
            this.cmb_EvrakTip.Size = new System.Drawing.Size(242, 37);
            this.cmb_EvrakTip.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Evrak Tipi:";
            // 
            // txt_EvrakNo
            // 
            this.txt_EvrakNo.Location = new System.Drawing.Point(10, 97);
            this.txt_EvrakNo.Name = "txt_EvrakNo";
            this.txt_EvrakNo.Size = new System.Drawing.Size(242, 35);
            this.txt_EvrakNo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Evrak No:";
            // 
            // YeniHesapHareketEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nm_vadegun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_vadetarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_islemtarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_NakitTahsilat);
            this.Controls.Add(this.rb_NakitTediye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nm_Tutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_CariHesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "YeniHesapHareketEkran";
            this.Text = "Yeni Hesap Hareketi Tanımla";
            this.Load += new System.EventHandler(this.YeniHesapHareketEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_Tutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_vadegun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_CariHesap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nm_Tutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_NakitTediye;
        private System.Windows.Forms.RadioButton rb_NakitTahsilat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_islemtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_vadetarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nm_vadegun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_EvrakCins;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_EvrakTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_EvrakNo;
        private System.Windows.Forms.Label label7;
    }
}