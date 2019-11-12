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
using WindowsFormsApp1.GUIFiles;

namespace WindowsFormsApp1
{
    
    public partial class mainPage : Form
    {
        public handler hand;
        public mainPage(handler hd)
        {
            hand = hd;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage f2 = new loginpage(hand);
            f2.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage rg = new RegisterPage(hand);
            rg.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            hand.Exit();
        }
    }
  
}
