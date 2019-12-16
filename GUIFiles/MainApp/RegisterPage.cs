using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles
{
    public partial class RegisterPage : Form
    {
        private UserController controller;
        public RegisterPage()
        {
            this.controller = UserController.GetInstance();
            InitializeComponent();
        }

        private void Bregister_Click(object sender, EventArgs e)
        {
            bool DONE = controller.Register(TuserName.Text, Tpassword.Text, Tname.Text, Temail.Text, Trole.SelectedItem.ToString());
            if(DONE)
            {
                MessageBox.Show("Account Created");
                this.Hide();
                loginpage lg = new loginpage();
                lg.Show();
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
            
        }

        private void Bback_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }
    }
}
