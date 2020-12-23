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
        private TextBox pozisyonTextBox;
        private Button donusBtn;
        private BindingSource bindingSource1;
        private IContainer components;
        private Button kaydetBtn;
        private Label label8;
        private Button listLoadBtn;
        private Button listSaveBtn;
        private ColumnHeader hIzinSay;
        private ColumnHeader yIzninSay;
        private TextBox kalanIzinTextBox;
        private Label kalanIzinLabel;
        private ColumnHeader pozisyonColumn;

        public CalisanDurumuTakibi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.clsnEklBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adSoyadColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evAdresiColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cepTelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subeAdresColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalanIzinColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maasColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hIzinSay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pozisyonColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yIzninSay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.donusBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listLoadBtn = new System.Windows.Forms.Button();
            this.listSaveBtn = new System.Windows.Forms.Button();
            this.kalanIzinTextBox = new System.Windows.Forms.TextBox();
            this.kalanIzinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışanların Durumu";
            // 
            // clsnEklBtn
            // 
            this.clsnEklBtn.Location = new System.Drawing.Point(17, 507);
            this.clsnEklBtn.Name = "clsnEklBtn";
            this.clsnEklBtn.Size = new System.Drawing.Size(94, 48);
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
            this.maasColumn,
            this.hIzinSay,
            this.yIzninSay,
            this.kalanIzinColumn,
            this.pozisyonColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 131);
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
            this.adSoyadColumn.Width = 100;
            // 
            // evAdresiColumn
            // 
            this.evAdresiColumn.Text = "Ev Adresi";
            this.evAdresiColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evAdresiColumn.Width = 100;
            // 
            // cepTelColumn
            // 
            this.cepTelColumn.Text = "Cep Telefonu";
            this.cepTelColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cepTelColumn.Width = 100;
            // 
            // subeAdresColumn
            // 
            this.subeAdresColumn.Text = "Şubenin Adresi";
            this.subeAdresColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subeAdresColumn.Width = 110;
            // 
            // kalanIzinColumn
            // 
            this.kalanIzinColumn.DisplayIndex = 7;
            this.kalanIzinColumn.Text = "Kalan İzin Hakkı";
            this.kalanIzinColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kalanIzinColumn.Width = 110;
            // 
            // maasColumn
            // 
            this.maasColumn.DisplayIndex = 4;
            this.maasColumn.Text = "Maaş";
            this.maasColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maasColumn.Width = 100;
            // 
            // hIzinSay
            // 
            this.hIzinSay.DisplayIndex = 5;
            this.hIzinSay.Text = "Haftalık İzin Hakkı";
            this.hIzinSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hIzinSay.Width = 110;
            // 
            // pozisyonColumn
            // 
            this.pozisyonColumn.Text = "Pozisyon";
            this.pozisyonColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pozisyonColumn.Width = 100;
            // 
            // yIzninSay
            // 
            this.yIzninSay.DisplayIndex = 6;
            this.yIzninSay.Text = "Yıllık İzin Hakkı";
            this.yIzninSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yIzninSay.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ev Adrsi        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cep Tel         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şube Adresi  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Maaş             :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pozisyonu     :";
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(118, 232);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(166, 22);
            this.adSoyadTextBox.TabIndex = 9;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(118, 266);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(166, 22);
            this.adresTextBox.TabIndex = 10;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(118, 306);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(166, 22);
            this.telTextBox.TabIndex = 11;
            // 
            // subeTextBox
            // 
            this.subeTextBox.Location = new System.Drawing.Point(118, 347);
            this.subeTextBox.Name = "subeTextBox";
            this.subeTextBox.Size = new System.Drawing.Size(166, 22);
            this.subeTextBox.TabIndex = 12;
            // 
            // maasTextBox
            // 
            this.maasTextBox.Location = new System.Drawing.Point(118, 385);
            this.maasTextBox.Name = "maasTextBox";
            this.maasTextBox.Size = new System.Drawing.Size(166, 22);
            this.maasTextBox.TabIndex = 13;
            // 
            // clsnSilBtn
            // 
            this.clsnSilBtn.Location = new System.Drawing.Point(117, 507);
            this.clsnSilBtn.Name = "clsnSilBtn";
            this.clsnSilBtn.Size = new System.Drawing.Size(98, 48);
            this.clsnSilBtn.TabIndex = 15;
            this.clsnSilBtn.Text = "Çalışan Çıkar";
            this.clsnSilBtn.UseVisualStyleBackColor = true;
            this.clsnSilBtn.Click += new System.EventHandler(this.clsnSilBtn_Click);
            // 
            // pozisyonTextBox
            // 
            this.pozisyonTextBox.Location = new System.Drawing.Point(118, 421);
            this.pozisyonTextBox.Name = "pozisyonTextBox";
            this.pozisyonTextBox.Size = new System.Drawing.Size(166, 22);
            this.pozisyonTextBox.TabIndex = 16;
            // 
            // donusBtn
            // 
            this.donusBtn.Location = new System.Drawing.Point(12, 12);
            this.donusBtn.Name = "donusBtn";
            this.donusBtn.Size = new System.Drawing.Size(119, 30);
            this.donusBtn.TabIndex = 17;
            this.donusBtn.Text = "Geriye Dön";
            this.donusBtn.UseVisualStyleBackColor = true;
            this.donusBtn.Click += new System.EventHandler(this.donusBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(221, 507);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(63, 48);
            this.kaydetBtn.TabIndex = 18;
            this.kaydetBtn.Text = "Düzelt";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 36);
            this.label8.TabIndex = 19;
            this.label8.Text = "Çalışan Ekle/Düzelt";
            // 
            // listLoadBtn
            // 
            this.listLoadBtn.Location = new System.Drawing.Point(1050, 90);
            this.listLoadBtn.Name = "listLoadBtn";
            this.listLoadBtn.Size = new System.Drawing.Size(195, 35);
            this.listLoadBtn.TabIndex = 20;
            this.listLoadBtn.Text = "&Kaydedilen Listeyi Aç";
            this.listLoadBtn.UseVisualStyleBackColor = true;
            this.listLoadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSaveBtn
            // 
            this.listSaveBtn.Location = new System.Drawing.Point(848, 90);
            this.listSaveBtn.Name = "listSaveBtn";
            this.listSaveBtn.Size = new System.Drawing.Size(196, 35);
            this.listSaveBtn.TabIndex = 21;
            this.listSaveBtn.Text = "&Yeni Liste Kaydet";
            this.listSaveBtn.UseVisualStyleBackColor = true;
            this.listSaveBtn.Click += new System.EventHandler(this.listSaveBtn_Click);
            // 
            // kalanIzinTextBox
            // 
            this.kalanIzinTextBox.Location = new System.Drawing.Point(117, 459);
            this.kalanIzinTextBox.Name = "kalanIzinTextBox";
            this.kalanIzinTextBox.Size = new System.Drawing.Size(166, 22);
            this.kalanIzinTextBox.TabIndex = 23;
            // 
            // kalanIzinLabel
            // 
            this.kalanIzinLabel.AutoSize = true;
            this.kalanIzinLabel.Location = new System.Drawing.Point(18, 463);
            this.kalanIzinLabel.Name = "kalanIzinLabel";
            this.kalanIzinLabel.Size = new System.Drawing.Size(101, 17);
            this.kalanIzinLabel.TabIndex = 22;
            this.kalanIzinLabel.Text = "Kalan izin       :";
            // 
            // CalisanDurumuTakibi
            // 
            this.ClientSize = new System.Drawing.Size(1264, 579);
            this.Controls.Add(this.kalanIzinTextBox);
            this.Controls.Add(this.kalanIzinLabel);
            this.Controls.Add(this.listSaveBtn);
            this.Controls.Add(this.listLoadBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.donusBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
              
                string[] arr = new string[9];
                arr[0] = adSoyadTextBox.Text;
                arr[1] = adresTextBox.Text;
                arr[2] = telTextBox.Text;
                arr[3] = subeTextBox.Text;
                arr[4] = maasTextBox.Text;
                arr[5] = "4";
                arr[6] = "14";
                arr[7] = kalanIzinTextBox.Text;
                arr[8] = pozisyonTextBox.Text;


                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                adSoyadTextBox.Clear();
                adresTextBox.Clear();
                telTextBox.Clear();
                subeTextBox.Clear();
                maasTextBox.Clear();
                kalanIzinTextBox.Clear();
                pozisyonTextBox.Clear();
                adSoyadTextBox.Focus();


            }
        }


        private void clsnSilBtn_Click(object sender, EventArgs e)
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
            pozisyonTextBox.Clear();
            adSoyadTextBox.Focus();
        }

        private void donusBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 c3 = new Form2();
            c3.ShowDialog();
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
                pozisyonTextBox.Text = listView1.SelectedItems[0].SubItems[8].Text;

            }

        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = adSoyadTextBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = adresTextBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = telTextBox.Text;
                listView1.SelectedItems[0].SubItems[3].Text = subeTextBox.Text;
                listView1.SelectedItems[0].SubItems[4].Text = maasTextBox.Text;
                listView1.SelectedItems[0].SubItems[7].Text = kalanIzinTextBox.Text;
                listView1.SelectedItems[0].SubItems[8].Text = pozisyonTextBox.Text;
                adSoyadTextBox.Clear();
                adresTextBox.Clear();
                telTextBox.Clear();
                subeTextBox.Clear();
                maasTextBox.Clear();
                kalanIzinTextBox.Clear();
                pozisyonTextBox.Clear();
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
                    pozisyon t;
                    if (POZISYON == "M")
                    {
                        t = pozisyon.M; 
                    }
                    else if(POZISYON == "MY")
                    {
                        t = pozisyon.MY;
                    }
                    else 
                    {
                        t = pozisyon.K;
                    }

                    calisanlari.Add(new Calisanlar (ADSOYAD, ADRESS,  CEPTEL, SUBEADI, MAAS, HIzinSayisi, YIzinSayisi, KALANizniSayisi, t)); 
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
                itm.SubItems.Add(c.TipC.ToString());
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
    }
}