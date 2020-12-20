using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using market_manager.TemizlikUrunler;

namespace market_manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void clsDurumBtn_Click(object sender, EventArgs e)
        {


            this.Hide();
            CalisanDurumuTakibi c2 = new CalisanDurumuTakibi();
            c2.ShowDialog();

        }

        private void temBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemizlikUrunleriForm tmzUrunler = new TemizlikUrunleriForm();
            tmzUrunler.ShowDialog();


        }
    }
}
