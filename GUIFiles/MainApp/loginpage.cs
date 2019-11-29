using OnlineStore.srcFiles;
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
        private Handler hand;
        public loginpage()
        {
            this.hand = Handler.GetInstance();
            InitializeComponent();
        }

        public void Blogin_Click(object sender, EventArgs e)
        {
            String UserName = TuserName.Text;
            String Password = Tpassword.Text;
            if (!hand.Login(UserName, Password))
            {
                MessageBox.Show("User Not Found");
            }
            else
                this.Close();
            
        }
        
        private void Bback_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }
    }
}

  

       
 
