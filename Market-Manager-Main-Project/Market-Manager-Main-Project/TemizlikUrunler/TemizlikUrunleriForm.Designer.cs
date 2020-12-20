namespace market_manager.TemizlikUrunler
{
    partial class TemizlikUrunleriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.magaza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAldigiFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunİndirimliFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunSatisFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunKaldigiAded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indirimYapBtn = new System.Windows.Forms.Button();
            this.urunSilBtn = new System.Windows.Forms.Button();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uruAdiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunMagazaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urunAldigiTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urunSatisTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urunAdedTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temizlik Ürünleri";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.magaza,
            this.urunAdi,
            this.urunAldigiFiyat,
            this.urunSatisFiyat,
            this.urunAdedi,
            this.urunİndirimliFiyat,
            this.urunKaldigiAded});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(63, 147);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1094, 467);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // magaza
            // 
            this.magaza.Text = "Mağaza";
            this.magaza.Width = 215;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 279;
            // 
            // urunAldigiFiyat
            // 
            this.urunAldigiFiyat.Text = "Ürün Aldığı Fiyat";
            this.urunAldigiFiyat.Width = 94;
            // 
            // urunİndirimliFiyat
            // 
            this.urunİndirimliFiyat.Text = "Ürün İndirimli Fiyatı";
            this.urunİndirimliFiyat.Width = 109;
            // 
            // urunSatisFiyat
            // 
            this.urunSatisFiyat.DisplayIndex = 4;
            this.urunSatisFiyat.Text = "Ürün Satış Fiyatı";
            this.urunSatisFiyat.Width = 90;
            // 
            // urunAdedi
            // 
            this.urunAdedi.Text = "Ürün Adedi";
            this.urunAdedi.Width = 68;
            // 
            // urunKaldigiAded
            // 
            this.urunKaldigiAded.Text = "Ürün Kaldığı Adedi";
            this.urunKaldigiAded.Width = 109;
            // 
            // indirimYapBtn
            // 
            this.indirimYapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indirimYapBtn.Location = new System.Drawing.Point(63, 89);
            this.indirimYapBtn.Name = "indirimYapBtn";
            this.indirimYapBtn.Size = new System.Drawing.Size(108, 41);
            this.indirimYapBtn.TabIndex = 2;
            this.indirimYapBtn.Text = "İndirim Yap";
            this.indirimYapBtn.UseVisualStyleBackColor = true;
            this.indirimYapBtn.Click += new System.EventHandler(this.indirimYapBtn_Click);
            // 
            // urunSilBtn
            // 
            this.urunSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunSilBtn.Location = new System.Drawing.Point(177, 89);
            this.urunSilBtn.Name = "urunSilBtn";
            this.urunSilBtn.Size = new System.Drawing.Size(108, 41);
            this.urunSilBtn.TabIndex = 2;
            this.urunSilBtn.Text = "Ürün Sil";
            this.urunSilBtn.UseVisualStyleBackColor = true;
            this.urunSilBtn.Click += new System.EventHandler(this.urunSilBtn_Click);
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunEkleBtn.Location = new System.Drawing.Point(1278, 538);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(108, 41);
            this.urunEkleBtn.TabIndex = 2;
            this.urunEkleBtn.Text = "Ürün Ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.urunAdedTxt);
            this.groupBox1.Controls.Add(this.urunSatisTxt);
            this.groupBox1.Controls.Add(this.urunAldigiTxt);
            this.groupBox1.Controls.Add(this.urunMagazaTxt);
            this.groupBox1.Controls.Add(this.uruAdiTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1190, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // uruAdiTxt
            // 
            this.uruAdiTxt.Location = new System.Drawing.Point(6, 47);
            this.uruAdiTxt.Name = "uruAdiTxt";
            this.uruAdiTxt.Size = new System.Drawing.Size(164, 24);
            this.uruAdiTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // urunMagazaTxt
            // 
            this.urunMagazaTxt.Location = new System.Drawing.Point(6, 96);
            this.urunMagazaTxt.Name = "urunMagazaTxt";
            this.urunMagazaTxt.Size = new System.Drawing.Size(164, 24);
            this.urunMagazaTxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mağaza";
            // 
            // urunAldigiTxt
            // 
            this.urunAldigiTxt.Location = new System.Drawing.Point(6, 147);
            this.urunAldigiTxt.Name = "urunAldigiTxt";
            this.urunAldigiTxt.Size = new System.Drawing.Size(164, 24);
            this.urunAldigiTxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aldığı Fiyat";
            // 
            // urunSatisTxt
            // 
            this.urunSatisTxt.Location = new System.Drawing.Point(6, 195);
            this.urunSatisTxt.Name = "urunSatisTxt";
            this.urunSatisTxt.Size = new System.Drawing.Size(164, 24);
            this.urunSatisTxt.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Satış Fiyat";
            // 
            // urunAdedTxt
            // 
            this.urunAdedTxt.Location = new System.Drawing.Point(6, 248);
            this.urunAdedTxt.Name = "urunAdedTxt";
            this.urunAdedTxt.Size = new System.Drawing.Size(164, 24);
            this.urunAdedTxt.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Aded";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hepsini Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TemizlikUrunleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunSilBtn);
            this.Controls.Add(this.indirimYapBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunEkleBtn);
            this.Name = "TemizlikUrunleriForm";
            this.Text = "TemizlikUrunleriForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader urunAldigiFiyat;
        private System.Windows.Forms.ColumnHeader urunİndirimliFiyat;
        private System.Windows.Forms.ColumnHeader urunAdedi;
        private System.Windows.Forms.ColumnHeader urunKaldigiAded;
        private System.Windows.Forms.Button indirimYapBtn;
        private System.Windows.Forms.Button urunSilBtn;
        private System.Windows.Forms.Button urunEkleBtn;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunAdedTxt;
        private System.Windows.Forms.TextBox urunSatisTxt;
        private System.Windows.Forms.TextBox urunAldigiTxt;
        private System.Windows.Forms.TextBox urunMagazaTxt;
        private System.Windows.Forms.TextBox uruAdiTxt;
        public System.Windows.Forms.ColumnHeader magaza;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ColumnHeader urunSatisFiyat;
    }
}