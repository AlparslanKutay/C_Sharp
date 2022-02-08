namespace GaleriAdminEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAraclar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAraclar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblFiyatAralıgı = new System.Windows.Forms.Label();
            this.cbSiyah = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBeyaz = new System.Windows.Forms.CheckBox();
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Araç Marka Adı Giriniz";
            // 
            // txtAraclar
            // 
            this.txtAraclar.Location = new System.Drawing.Point(12, 153);
            this.txtAraclar.Name = "txtAraclar";
            this.txtAraclar.Size = new System.Drawing.Size(100, 20);
            this.txtAraclar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(8, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araçlar";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(12, 337);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(121, 21);
            this.cmbAraclar.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnKaydet.Location = new System.Drawing.Point(12, 179);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSec.Location = new System.Drawing.Point(11, 364);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(9, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyat Aralığı : ";
            // 
            // lbAraclar
            // 
            this.lbAraclar.FormattingEnabled = true;
            this.lbAraclar.Location = new System.Drawing.Point(188, 13);
            this.lbAraclar.Name = "lbAraclar";
            this.lbAraclar.Size = new System.Drawing.Size(240, 316);
            this.lbAraclar.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSil.Location = new System.Drawing.Point(188, 335);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblFiyatAralıgı
            // 
            this.lblFiyatAralıgı.AutoSize = true;
            this.lblFiyatAralıgı.Location = new System.Drawing.Point(99, 421);
            this.lblFiyatAralıgı.Name = "lblFiyatAralıgı";
            this.lblFiyatAralıgı.Size = new System.Drawing.Size(13, 13);
            this.lblFiyatAralıgı.TabIndex = 1;
            this.lblFiyatAralıgı.Text = "0";
            // 
            // cbSiyah
            // 
            this.cbSiyah.AutoSize = true;
            this.cbSiyah.Location = new System.Drawing.Point(15, 234);
            this.cbSiyah.Name = "cbSiyah";
            this.cbSiyah.Size = new System.Drawing.Size(52, 17);
            this.cbSiyah.TabIndex = 6;
            this.cbSiyah.Text = "Siyah";
            this.cbSiyah.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Renkler";
            // 
            // cbBeyaz
            // 
            this.cbBeyaz.AutoSize = true;
            this.cbBeyaz.Location = new System.Drawing.Point(15, 257);
            this.cbBeyaz.Name = "cbBeyaz";
            this.cbBeyaz.Size = new System.Drawing.Size(55, 17);
            this.cbBeyaz.TabIndex = 6;
            this.cbBeyaz.Text = "Beyaz";
            this.cbBeyaz.UseVisualStyleBackColor = true;
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Location = new System.Drawing.Point(15, 280);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(55, 17);
            this.cbKirmizi.TabIndex = 6;
            this.cbKirmizi.Text = "Kirmizi";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 451);
            this.Controls.Add(this.cbKirmizi);
            this.Controls.Add(this.cbBeyaz);
            this.Controls.Add(this.cbSiyah);
            this.Controls.Add(this.lbAraclar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbAraclar);
            this.Controls.Add(this.txtAraclar);
            this.Controls.Add(this.lblFiyatAralıgı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAraclar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAraclar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblFiyatAralıgı;
        private System.Windows.Forms.CheckBox cbSiyah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbBeyaz;
        private System.Windows.Forms.CheckBox cbKirmizi;
    }
}

