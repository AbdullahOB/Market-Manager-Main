using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace market_manager
{
    public partial class CalisanDurumuTakibi : Form
    {
        private Button clsnEklBtn;
        private ListView listView1;
        private ColumnHeader adSoyadColumn;
        private ColumnHeader evAdresiColumn;
        private ColumnHeader cepTelColumn;
        private ColumnHeader subeAdresColumn;
        private ColumnHeader kalanIzinColumn;
        private ColumnHeader maasColumn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox adSoyadTextBox;
        private TextBox adresTextBox;
        private TextBox telTextBox;
        private TextBox subeTextBox;
        private TextBox maasTextBox;
        private Button clsnSilBtn;
        private BindingSource bindingSource1;
        private IContainer components;
        private Button kaydetBtn;
        private Button listLoadBtn;
        private Button listSaveBtn;
        private ColumnHeader hIzinSay;
        private ColumnHeader yIzninSay;
        private TextBox kalanIzinTextBox;
        private Label kalanIzinLabel;
        private GroupBox groupBox1;
        private BackgroundWorker backgroundWorker1;
        private ComboBox pozisyonCmb;
        private PictureBox pictureBox1;
        private ColumnHeader pozisyonColumn;

        public CalisanDurumuTakibi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mahmud ELSEYYİDÖMER",
            "İZMİR",
            "5306606048",
            "KONAK",
            "5000",
            "4",
            "14",
            "12",
            "Müdür"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Salam AL HASAN",
            "MANİSA",
            "5306556410",
            "TURGUTLU",
            "4800",
            "4",
            "14",
            "5",
            "Müdür Yardımcısı"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Abdullah OBAİD",
            "MANİSA",
            "5538774934",
            "TURGUTLU",
            "4200",
            "4",
            "14",
            "8",
            "Kasiyer"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanDurumuTakibi));
            this.label1 = new System.Windows.Forms.Label();
            this.clsnEklBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adSoyadColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evAdresiColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cepTelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeAdresColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maasColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIzinSay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yIzninSay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalanIzinColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pozisyonColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.subeTextBox = new System.Windows.Forms.TextBox();
            this.maasTextBox = new System.Windows.Forms.TextBox();
            this.clsnSilBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.listLoadBtn = new System.Windows.Forms.Button();
            this.listSaveBtn = new System.Windows.Forms.Button();
            this.kalanIzinTextBox = new System.Windows.Forms.TextBox();
            this.kalanIzinLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pozisyonCmb = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışanların Durumu";
            // 
            // clsnEklBtn
            // 
            this.clsnEklBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.clsnEklBtn.Font = new System.Drawing.Font("Euphemia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsnEklBtn.ForeColor = System.Drawing.Color.Black;
            this.clsnEklBtn.Location = new System.Drawing.Point(3, 363);
            this.clsnEklBtn.Name = "clsnEklBtn";
            this.clsnEklBtn.Size = new System.Drawing.Size(94, 38);
            this.clsnEklBtn.TabIndex = 1;
            this.clsnEklBtn.Text = "Çalışan Ekle";
            this.clsnEklBtn.UseVisualStyleBackColor = false;
            this.clsnEklBtn.Click += new System.EventHandler(this.clsnEklBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.adSoyadColumn,
            this.evAdresiColumn,
            this.cepTelColumn,
            this.subeAdresColumn,
            this.maasColumn,
            this.hIzinSay,
            this.yIzninSay,
            this.kalanIzinColumn,
            this.pozisyonColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(303, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(945, 424);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // adSoyadColumn
            // 
            this.adSoyadColumn.Text = "Adı Soyadı";
            this.adSoyadColumn.Width = 171;
            // 
            // evAdresiColumn
            // 
            this.evAdresiColumn.Text = "Ev Adresi";
            this.evAdresiColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evAdresiColumn.Width = 74;
            // 
            // cepTelColumn
            // 
            this.cepTelColumn.Text = "Cep Telefonu";
            this.cepTelColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cepTelColumn.Width = 92;
            // 
            // subeAdresColumn
            // 
            this.subeAdresColumn.Text = "Şubenin Adresi";
            this.subeAdresColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subeAdresColumn.Width = 103;
            // 
            // maasColumn
            // 
            this.maasColumn.Text = "Maaş";
            this.maasColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maasColumn.Width = 73;
            // 
            // hIzinSay
            // 
            this.hIzinSay.Text = "Haftalık İzin Hakkı";
            this.hIzinSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hIzinSay.Width = 118;
            // 
            // yIzninSay
            // 
            this.yIzninSay.Text = "Yıllık İzin Hakkı";
            this.yIzninSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yIzninSay.Width = 101;
            // 
            // kalanIzinColumn
            // 
            this.kalanIzinColumn.Text = "Kalan İzin Hakkı";
            this.kalanIzinColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kalanIzinColumn.Width = 106;
            // 
            // pozisyonColumn
            // 
            this.pozisyonColumn.Text = "Pozisyon";
            this.pozisyonColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pozisyonColumn.Width = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ev Adrsi     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(4, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cep Tel      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(2, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şube Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(3, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maaş          :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(3, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pozisyonu  :";
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSoyadTextBox.Location = new System.Drawing.Point(107, 80);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(166, 27);
            this.adSoyadTextBox.TabIndex = 9;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresTextBox.Location = new System.Drawing.Point(107, 114);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(166, 27);
            this.adresTextBox.TabIndex = 10;
            // 
            // telTextBox
            // 
            this.telTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.Location = new System.Drawing.Point(107, 154);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(166, 27);
            this.telTextBox.TabIndex = 11;
            // 
            // subeTextBox
            // 
            this.subeTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subeTextBox.Location = new System.Drawing.Point(107, 195);
            this.subeTextBox.Name = "subeTextBox";
            this.subeTextBox.Size = new System.Drawing.Size(166, 27);
            this.subeTextBox.TabIndex = 12;
            // 
            // maasTextBox
            // 
            this.maasTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maasTextBox.Location = new System.Drawing.Point(107, 233);
            this.maasTextBox.Name = "maasTextBox";
            this.maasTextBox.Size = new System.Drawing.Size(166, 27);
            this.maasTextBox.TabIndex = 13;
            // 
            // clsnSilBtn
            // 
            this.clsnSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clsnSilBtn.Font = new System.Drawing.Font("Euphemia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsnSilBtn.ForeColor = System.Drawing.Color.White;
            this.clsnSilBtn.Location = new System.Drawing.Point(173, 363);
            this.clsnSilBtn.Name = "clsnSilBtn";
            this.clsnSilBtn.Size = new System.Drawing.Size(100, 38);
            this.clsnSilBtn.TabIndex = 15;
            this.clsnSilBtn.Text = "Çalışan Çıkar";
            this.clsnSilBtn.UseVisualStyleBackColor = false;
            this.clsnSilBtn.Click += new System.EventHandler(this.clsnSilBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.kaydetBtn.Font = new System.Drawing.Font("Euphemia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydetBtn.ForeColor = System.Drawing.Color.White;
            this.kaydetBtn.Location = new System.Drawing.Point(96, 363);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(78, 38);
            this.kaydetBtn.TabIndex = 18;
            this.kaydetBtn.Text = "Düzelt";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // listLoadBtn
            // 
            this.listLoadBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listLoadBtn.Location = new System.Drawing.Point(1145, 90);
            this.listLoadBtn.Name = "listLoadBtn";
            this.listLoadBtn.Size = new System.Drawing.Size(102, 35);
            this.listLoadBtn.TabIndex = 20;
            this.listLoadBtn.Text = "&Listeyi Aç";
            this.listLoadBtn.UseVisualStyleBackColor = false;
            this.listLoadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSaveBtn
            // 
            this.listSaveBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listSaveBtn.Location = new System.Drawing.Point(1035, 90);
            this.listSaveBtn.Name = "listSaveBtn";
            this.listSaveBtn.Size = new System.Drawing.Size(103, 35);
            this.listSaveBtn.TabIndex = 21;
            this.listSaveBtn.Text = "&Liste Kaydet";
            this.listSaveBtn.UseVisualStyleBackColor = false;
            this.listSaveBtn.Click += new System.EventHandler(this.listSaveBtn_Click);
            // 
            // kalanIzinTextBox
            // 
            this.kalanIzinTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalanIzinTextBox.Location = new System.Drawing.Point(106, 307);
            this.kalanIzinTextBox.Name = "kalanIzinTextBox";
            this.kalanIzinTextBox.Size = new System.Drawing.Size(166, 27);
            this.kalanIzinTextBox.TabIndex = 23;
            // 
            // kalanIzinLabel
            // 
            this.kalanIzinLabel.AutoSize = true;
            this.kalanIzinLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.kalanIzinLabel.ForeColor = System.Drawing.Color.Blue;
            this.kalanIzinLabel.Location = new System.Drawing.Point(3, 311);
            this.kalanIzinLabel.Name = "kalanIzinLabel";
            this.kalanIzinLabel.Size = new System.Drawing.Size(101, 19);
            this.kalanIzinLabel.TabIndex = 22;
            this.kalanIzinLabel.Text = "Kalan izin   :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pozisyonCmb);
            this.groupBox1.Controls.Add(this.adSoyadTextBox);
            this.groupBox1.Controls.Add(this.kalanIzinTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kaydetBtn);
            this.groupBox1.Controls.Add(this.kalanIzinLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clsnSilBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clsnEklBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.adresTextBox);
            this.groupBox1.Controls.Add(this.telTextBox);
            this.groupBox1.Controls.Add(this.maasTextBox);
            this.groupBox1.Controls.Add(this.subeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Euphemia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Location = new System.Drawing.Point(13, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 426);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Ekle / Düzelt";
            // 
            // pozisyonCmb
            // 
            this.pozisyonCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pozisyonCmb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozisyonCmb.FormattingEnabled = true;
            this.pozisyonCmb.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Kasiyer"});
            this.pozisyonCmb.Location = new System.Drawing.Point(107, 268);
            this.pozisyonCmb.Name = "pozisyonCmb";
            this.pozisyonCmb.Size = new System.Drawing.Size(165, 27);
            this.pozisyonCmb.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CalisanDurumuTakibi
            // 
            this.ClientSize = new System.Drawing.Size(1264, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listSaveBtn);
            this.Controls.Add(this.listLoadBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalisanDurumuTakibi";
            this.Text = "Durum Takip Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void addClsn(string adSoyad, string adres, long cepTel, string subeAdi, double maas, int hIzinSayisi, int yIzinSayisi, int kalanIzinSayisi, string poz)
        {
            string[] row = { adSoyad,adres,Convert.ToString(cepTel),subeAdi,Convert.ToString(maas),Convert.ToString(hIzinSayisi),Convert.ToString(yIzinSayisi),Convert.ToString(kalanIzinSayisi),poz };

            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);

        }

        private void clsnEklBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adSoyadTextBox.Text) || string.IsNullOrEmpty(adresTextBox.Text) || string.IsNullOrEmpty(telTextBox.Text)
                    || string.IsNullOrEmpty(subeTextBox.Text) || string.IsNullOrEmpty(maasTextBox.Text) || string.IsNullOrEmpty(pozisyonCmb.Text))
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz");
                return;
            }
            else
            {

                try
                {
                    addClsn(adSoyadTextBox.Text, adresTextBox.Text, Convert.ToInt64(telTextBox.Text), subeTextBox.Text, Convert.ToDouble(maasTextBox.Text), 4, 14, 14, pozisyonCmb.Text);
                    
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            adSoyadTextBox.Clear();
            adresTextBox.Clear();
            telTextBox.Clear();
            subeTextBox.Clear();
            maasTextBox.Clear();
            kalanIzinTextBox.Clear();
            pozisyonCmb.Text = " ";
            adSoyadTextBox.Focus();



        }


        private void clsnSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Emin Misiniz ?", Convert.ToString(MessageBoxIcon.Warning), MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {

                if (listView1.SelectedItems.Count > 0)
                { listView1.Items.Remove(listView1.SelectedItems[0]); }
                else MessageBox.Show("Bir Çalışan Seçiniz ..");
                adSoyadTextBox.Clear();
                adresTextBox.Clear();
                telTextBox.Clear();
                subeTextBox.Clear();
                maasTextBox.Clear();
                kalanIzinTextBox.Clear();
                pozisyonCmb.Text = " ";
                adSoyadTextBox.Focus();
            }
            
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                adSoyadTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
                adresTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                telTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                subeTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
                maasTextBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
                kalanIzinTextBox.Text = listView1.SelectedItems[0].SubItems[7].Text;
                pozisyonCmb.Text = listView1.SelectedItems[0].SubItems[8].Text;

            }

        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(maasTextBox.Text);



                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.SelectedItems[0].SubItems[0].Text = adSoyadTextBox.Text;
                    listView1.SelectedItems[0].SubItems[1].Text = adresTextBox.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = telTextBox.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = subeTextBox.Text;
                   
                if(maas < Convert.ToDouble(listView1.SelectedItems[0].SubItems[4].Text))
                {
                    MessageBox.Show("Girmiş olduğunuz maaş, Önceki maaştan daha düşük. Maaşları düşüremezsiniz !!!");
                }
                else
                {
                    listView1.SelectedItems[0].SubItems[4].Text = maasTextBox.Text;
                }
                    listView1.SelectedItems[0].SubItems[7].Text = kalanIzinTextBox.Text;
                    listView1.SelectedItems[0].SubItems[8].Text = pozisyonCmb.Text;
                    adSoyadTextBox.Clear();
                    adresTextBox.Clear();
                    telTextBox.Clear();
                    subeTextBox.Clear();
                    maasTextBox.Clear();
                    kalanIzinTextBox.Clear();
                    pozisyonCmb.Text = " ";
                    adSoyadTextBox.Focus();

                }
                                       
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog () ;
            op.ShowDialog();

            string dosya = op.FileName;
            initialiserData(dosya);
            initialiserList();

        }


        private List<Calisanlar> calisanlari = new List<Calisanlar>();
        private void initialiserData(string dosyaIsmi)
        {

            try
            {

                StreamReader sr = new StreamReader(dosyaIsmi);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string ADSOYAD = line.Split(',')[0];
                    string ADRESS = line.Split(',')[1];
                    long CEPTEL = Convert.ToInt64(line.Split(',')[2]);
                    string SUBEADI = line.Split(',')[3];
                    double MAAS = Convert.ToDouble(line.Split(',')[4]);
                    int HIzinSayisi = Convert.ToInt32(line.Split(',')[5]);
                    int YIzinSayisi = Convert.ToInt32(line.Split(',')[6]);
                    int KALANizniSayisi = Convert.ToInt32(line.Split(',')[7]);
                    string POZISYON = line.Split(',')[8];
                    
                    calisanlari.Add(new Calisanlar (ADSOYAD, ADRESS,  CEPTEL, SUBEADI, MAAS, HIzinSayisi, YIzinSayisi, KALANizniSayisi, POZISYON)); 
                }
                sr.Close();



            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void initialiserList()
        {
            foreach (Calisanlar c in calisanlari)
            {
                ListViewItem itm = new ListViewItem(c.AdSoyad.ToString());
                itm.SubItems.Add(c.Adress.ToString());
                itm.SubItems.Add(c.CepTel.ToString());
                itm.SubItems.Add(c.SubeAdi.ToString());
                itm.SubItems.Add(c.Maas.ToString());
                itm.SubItems.Add(c.HizinSayisi.ToString());
                itm.SubItems.Add(c.YizinSayisi.ToString());
                itm.SubItems.Add(c.KalanIzinSayisi.ToString());
                itm.SubItems.Add(c.Poz.ToString());
                listView1.Items.Add(itm);
            }


        }



        private void listSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();

                string dosya = save.FileName;

                StreamWriter sw = new StreamWriter(dosya); 

                foreach (ListViewItem itm in listView1.Items)
                {
                    for (int i=0; i< itm.SubItems.Count; i++)
                    {
                        sw.Write(itm.SubItems[i].Text);
                        if (i != itm.SubItems.Count - 1)
                        { 
                            sw.Write(","); 
                        }


                    }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Dosyanız buraya kaydedildi: " + dosya);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 c3 = new Form2();
            c3.ShowDialog();
        }

        
    }
}