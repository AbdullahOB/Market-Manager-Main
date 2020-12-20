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
    public partial class IndirimliFiyat : Form
    {
        public IndirimliFiyat()
        {
            InitializeComponent();
            oncekiFiyat.Text = Convert.ToString(T.listView.SelectedItems[1].SubItems[3].Text);
        }
        TemizlikUrunleriForm T = new TemizlikUrunleriForm();
        
        private void dis()
        {
            oncekiFiyat.Text = "gg";
                //Convert.ToString(T.listView.SelectedItems[Convert.ToInt32(T.urunSatisFiyat)]);
        }
        private void oncekiFiyat_Click(object sender, EventArgs e)
        {

        }
    }
}
