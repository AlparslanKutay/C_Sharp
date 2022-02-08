namespace Enc_OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSemt = new System.Windows.Forms.TextBox();
            this.txtOdaSay = new System.Windows.Forms.TextBox();
            this.txtKatNo = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbSemt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbOdaSay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbKat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAlan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(316, 79);
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Size = new System.Drawing.Size(100, 22);
            this.txtSemt.TabIndex = 0;
            // 
            // txtOdaSay
            // 
            this.txtOdaSay.Location = new System.Drawing.Point(316, 130);
            this.txtOdaSay.Name = "txtOdaSay";
            this.txtOdaSay.Size = new System.Drawing.Size(100, 22);
            this.txtOdaSay.TabIndex = 1;
            // 
            // txtKatNo
            // 
            this.txtKatNo.Location = new System.Drawing.Point(316, 177);
            this.txtKatNo.Name = "txtKatNo";
            this.txtKatNo.Size = new System.Drawing.Size(100, 22);
            this.txtKatNo.TabIndex = 2;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(316, 229);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(100, 22);
            this.txtAlan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kat No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alan";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(316, 266);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 37);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lbSemt,
            this.lbOdaSay,
            this.lbKat,
            this.lbAlan});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(869, 185);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbSemt
            // 
            this.lbSemt.Text = "Semt";
            this.lbSemt.Width = 147;
            // 
            // lbOdaSay
            // 
            this.lbOdaSay.Text = "Oda Sayısı";
            this.lbOdaSay.Width = 134;
            // 
            // lbKat
            // 
            this.lbKat.Text = "Kat Numarası";
            this.lbKat.Width = 137;
            // 
            // lbAlan
            // 
            this.lbAlan.Text = "Alan";
            this.lbAlan.Width = 136;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 523);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtKatNo);
            this.Controls.Add(this.txtOdaSay);
            this.Controls.Add(this.txtSemt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemt;
        private System.Windows.Forms.TextBox txtOdaSay;
        private System.Windows.Forms.TextBox txtKatNo;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader lbSemt;
        public System.Windows.Forms.ColumnHeader lbOdaSay;
        public System.Windows.Forms.ColumnHeader lbKat;
        public System.Windows.Forms.ColumnHeader lbAlan;
    }
}

