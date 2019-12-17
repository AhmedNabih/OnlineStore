using OnlineStore.Users;
using System;
using System.Windows.Forms;

namespace OnlineStore
{

    public partial class loginpage : Form
    {
        private UserController controller;

        public loginpage()
        {
            this.controller = UserController.GetInstance();
            InitializeComponent();
        }

        public void Blogin_Click(object sender, EventArgs e)
        {
            String UserName = TuserName.Text;
            String Password = Tpassword.Text;
            if (!this.controller.Login(UserName, Password))
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

  

       
 
