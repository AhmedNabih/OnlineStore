using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{

    public partial class loginpage : Form
    {
        public handler hand;
        public loginpage(handler hd)
        {
            hand = hd;
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            String UserName = textBox1.Text;
            String Password = textBox2.Text;
            if(!hand.Login(UserName, Password))
            {
                MessageBox.Show("User Not Found");
            }
            this.Hide();
            
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            mainPage mp = new mainPage(hand);
            mp.Show();
        }
    }
}

  

       
 
