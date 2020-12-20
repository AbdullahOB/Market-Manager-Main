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
{//Merhaba Arkadaslar
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public string adminUserName = "Admin";
        string adminPassword = "1234";
        bool admin = false;
        string superAdminUserName = "SUAdmin";
        string superAdminPassword = "12345";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void loginClk(object sender, EventArgs e)
        {
            if ((username.Text == adminUserName&&password.Text==adminPassword ))
            {
               
                MessageBox.Show("Login Successed!");
                f2.gdBtn.Visible= false;
                f2.temBtn.Visible = false;
                this.Hide();
                
                f2.ShowDialog();
               
            }

            else if((username.Text == superAdminUserName && password.Text == superAdminPassword))
            {
                MessageBox.Show("Login Successed!");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed... Username Or Password is wrong");
                Application.Exit();
            }
            
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

            


        }

    }
}
