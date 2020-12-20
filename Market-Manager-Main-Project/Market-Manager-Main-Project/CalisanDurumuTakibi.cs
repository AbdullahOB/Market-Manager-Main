using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private TextBox pozisyonTextBox;
        private ColumnHeader pozisyonColumn;

        public CalisanDurumuTakibi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.clsnEklBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adSoyadColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evAdresiColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cepTelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeAdresColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalanIzinColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maasColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pozisyonTextBox = new System.Windows.Forms.TextBox();
            this.pozisyonColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label1 = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışanların Durumu";
            // 
            // clsnEklBtn
            // 
            this.clsnEklBtn.Location = new System.Drawing.Point(99, 602);
            this.clsnEklBtn.Name = "clsnEklBtn";
            this.clsnEklBtn.Size = new System.Drawing.Size(119, 31);
            this.clsnEklBtn.TabIndex = 1;
            this.clsnEklBtn.Text = "Çalışan Ekle";
            this.clsnEklBtn.UseVisualStyleBackColor = true;
            this.clsnEklBtn.Click += new System.EventHandler(this.clsnEklBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.adSoyadColumn,
            this.evAdresiColumn,
            this.cepTelColumn,
            this.subeAdresColumn,
            this.kalanIzinColumn,
            this.maasColumn,
            this.pozisyonColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(474, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 563);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // adSoyadColumn
            // 
            this.adSoyadColumn.Text = "Adı Soyadı";
            this.adSoyadColumn.Width = 110;
            // 
            // evAdresiColumn
            // 
            this.evAdresiColumn.Text = "Ev Adresi";
            this.evAdresiColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evAdresiColumn.Width = 110;
            // 
            // cepTelColumn
            // 
            this.cepTelColumn.Text = "Cep Telefonu";
            this.cepTelColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cepTelColumn.Width = 110;
            // 
            // subeAdresColumn
            // 
            this.subeAdresColumn.Text = "Şubenin Adresi";
            this.subeAdresColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subeAdresColumn.Width = 110;
            // 
            // kalanIzinColumn
            // 
            this.kalanIzinColumn.Text = "Kalan İzin Hakkı";
            this.kalanIzinColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kalanIzinColumn.Width = 110;
            // 
            // maasColumn
            // 
            this.maasColumn.Text = "Maaş";
            this.maasColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maasColumn.Width = 110;
            // 
            // pozisyonColumn
            // 
            this.pozisyonColumn.Text = "Pozisyon";
            this.pozisyonColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pozisyonColumn.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ev Adrsi    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cep Tel     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şube Adı   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maaş        :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pozisyonu :";
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(147, 283);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(279, 22);
            this.adSoyadTextBox.TabIndex = 9;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(147, 332);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(279, 22);
            this.adresTextBox.TabIndex = 10;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(147, 388);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(279, 22);
            this.telTextBox.TabIndex = 11;
            // 
            // subeTextBox
            // 
            this.subeTextBox.Location = new System.Drawing.Point(147, 437);
            this.subeTextBox.Name = "subeTextBox";
            this.subeTextBox.Size = new System.Drawing.Size(279, 22);
            this.subeTextBox.TabIndex = 12;
            // 
            // maasTextBox
            // 
            this.maasTextBox.Location = new System.Drawing.Point(147, 492);
            this.maasTextBox.Name = "maasTextBox";
            this.maasTextBox.Size = new System.Drawing.Size(279, 22);
            this.maasTextBox.TabIndex = 13;
            // 
            // clsnSilBtn
            // 
            this.clsnSilBtn.Location = new System.Drawing.Point(268, 602);
            this.clsnSilBtn.Name = "clsnSilBtn";
            this.clsnSilBtn.Size = new System.Drawing.Size(119, 31);
            this.clsnSilBtn.TabIndex = 15;
            this.clsnSilBtn.Text = "Çalışan Çıkar";
            this.clsnSilBtn.UseVisualStyleBackColor = true;
            this.clsnSilBtn.Click += new System.EventHandler(this.clsnSilBtn_Click);
            // 
            // pozisyonTextBox
            // 
            this.pozisyonTextBox.Location = new System.Drawing.Point(147, 537);
            this.pozisyonTextBox.Name = "pozisyonTextBox";
            this.pozisyonTextBox.Size = new System.Drawing.Size(279, 22);
            this.pozisyonTextBox.TabIndex = 16;
            // 

            // CalisanDurumuTakibi
            // 
            this.ClientSize = new System.Drawing.Size(1260, 706);
            this.Controls.Add(this.pozisyonTextBox);
            this.Controls.Add(this.clsnSilBtn);
            this.Controls.Add(this.maasTextBox);
            this.Controls.Add(this.subeTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clsnEklBtn);
            this.Controls.Add(this.label1);
            this.Name = "CalisanDurumuTakibi";
            this.Text = "Durum Takip Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clsnEklBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adSoyadTextBox.Text) || string.IsNullOrEmpty(adresTextBox.Text) || string.IsNullOrEmpty(telTextBox.Text)
             || string.IsNullOrEmpty(subeTextBox.Text) || string.IsNullOrEmpty(maasTextBox.Text) || string.IsNullOrEmpty(pozisyonTextBox.Text))
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldur");
                return;
            }
            else
            {
                string[] arr = new string[7];
                arr[0] = adSoyadTextBox.Text;
                arr[1] = adresTextBox.Text;
                arr[2] = telTextBox.Text;
                arr[3] = subeTextBox.Text;
                arr[4] = "14";
                arr[5] = maasTextBox.Text;
                arr[6] = pozisyonTextBox.Text;

                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                adSoyadTextBox.Clear();
                adresTextBox.Clear();
                telTextBox.Clear();
                subeTextBox.Clear();
                maasTextBox.Clear();
                pozisyonTextBox.Clear();
                adSoyadTextBox.Focus();
            }
        }

        private void clsnSilBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
           


        }
    }
}