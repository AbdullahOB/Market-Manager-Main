using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_manager.TemizlikUrunler
{
    public partial class TemizlikUrunleriForm : Form
    {

        
        public TemizlikUrunleriForm()
        {
            InitializeComponent();
            listView.FullRowSelect = true;
        }

        public void add(string magaza, string urunAd, double aldigiFiyat, double satisFiyat, int aded)
        {
            string[] row = { urunAd, magaza, Convert.ToString(aldigiFiyat), Convert.ToString(satisFiyat), Convert.ToString(aded) };
            
            ListViewItem item = new ListViewItem(row);
            listView.Items.Add(item);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                add(uruAdiTxt.Text, urunMagazaTxt.Text, Convert.ToDouble(urunAldigiTxt.Text), Convert.ToDouble(urunSatisTxt.Text), Convert.ToInt32(urunAdedTxt.Text));
                uruAdiTxt.Text = "";
                urunMagazaTxt.Text = "";
                urunAldigiTxt.Text = "";
                urunSatisTxt.Text  = "";
                urunAdedTxt.Text = "";
            }
            catch
            {
                MessageBox.Show("You've Entered Invalid Values, Please Chech Them and try again");
            }
            
        }

        private void urunSilBtn_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                try
                {
                    listView.Items.Remove(listView.SelectedItems[0]);
                }
                catch
                {
                    MessageBox.Show("Please Select An Item");
                }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }

        private void indirimYapBtn_Click(object sender, EventArgs e)
        {
            
            IndirimliFiyat I = new IndirimliFiyat();
            I.ShowDialog();
        }
    }
}
