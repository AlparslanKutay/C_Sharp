namespace OOPGiris
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMarka = new System.Windows.Forms.Label();
            this.lbSeri = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbRenk = new System.Windows.Forms.Label();
            this.lbVites = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vites Tipi";
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.Location = new System.Drawing.Point(230, 200);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(16, 17);
            this.lbMarka.TabIndex = 6;
            this.lbMarka.Text = "0";
            // 
            // lbSeri
            // 
            this.lbSeri.AutoSize = true;
            this.lbSeri.Location = new System.Drawing.Point(230, 261);
            this.lbSeri.Name = "lbSeri";
            this.lbSeri.Size = new System.Drawing.Size(16, 17);
            this.lbSeri.TabIndex = 7;
            this.lbSeri.Text = "0";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(239, 337);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(16, 17);
            this.lbModel.TabIndex = 8;
            this.lbModel.Text = "0";
            // 
            // lbRenk
            // 
            this.lbRenk.AutoSize = true;
            this.lbRenk.Location = new System.Drawing.Point(239, 388);
            this.lbRenk.Name = "lbRenk";
            this.lbRenk.Size = new System.Drawing.Size(16, 17);
            this.lbRenk.TabIndex = 9;
            this.lbRenk.Text = "0";
            // 
            // lbVites
            // 
            this.lbVites.AutoSize = true;
            this.lbVites.Location = new System.Drawing.Point(230, 439);
            this.lbVites.Name = "lbVites";
            this.lbVites.Size = new System.Drawing.Size(16, 17);
            this.lbVites.TabIndex = 10;
            this.lbVites.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 78);
            this.button2.TabIndex = 11;
            this.button2.Text = "İkinci Oto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(453, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(453, 383);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(453, 434);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 22);
            this.textBox5.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 531);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbVites);
            this.Controls.Add(this.lbRenk);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbSeri);
            this.Controls.Add(this.lbMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMarka;
        private System.Windows.Forms.Label lbSeri;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbRenk;
        private System.Windows.Forms.Label lbVites;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

