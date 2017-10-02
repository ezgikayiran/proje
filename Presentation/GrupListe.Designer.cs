namespace Presentation
{
    partial class GrupListe
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
            this.lst_GrupListe = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GrupEkle = new System.Windows.Forms.Button();
            this.txt_GrupAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_GrupListe
            // 
            this.lst_GrupListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_GrupListe.FormattingEnabled = true;
            this.lst_GrupListe.ItemHeight = 29;
            this.lst_GrupListe.Location = new System.Drawing.Point(0, 0);
            this.lst_GrupListe.Name = "lst_GrupListe";
            this.lst_GrupListe.Size = new System.Drawing.Size(261, 314);
            this.lst_GrupListe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GrupEkle);
            this.groupBox1.Controls.Add(this.txt_GrupAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(282, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Grup Ekle";
            // 
            // btn_GrupEkle
            // 
            this.btn_GrupEkle.Location = new System.Drawing.Point(230, 141);
            this.btn_GrupEkle.Name = "btn_GrupEkle";
            this.btn_GrupEkle.Size = new System.Drawing.Size(133, 45);
            this.btn_GrupEkle.TabIndex = 2;
            this.btn_GrupEkle.Text = "Ekle";
            this.btn_GrupEkle.UseVisualStyleBackColor = true;
            this.btn_GrupEkle.Click += new System.EventHandler(this.btn_GrupEkle_Click);
            // 
            // txt_GrupAdi
            // 
            this.txt_GrupAdi.Location = new System.Drawing.Point(145, 63);
            this.txt_GrupAdi.Name = "txt_GrupAdi";
            this.txt_GrupAdi.Size = new System.Drawing.Size(218, 35);
            this.txt_GrupAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GrupListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst_GrupListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "GrupListe";
            this.Text = "Gruplar";
            this.Load += new System.EventHandler(this.GrupListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_GrupListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_GrupAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GrupEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}