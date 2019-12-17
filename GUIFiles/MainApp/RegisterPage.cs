using OnlineStore.Users;
using System;
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
            String US = TuserName.Text;
            String PW = Tpassword.Text;
            String N = Tname.Text;
            String EM = Temail.Text;
            String Role = Trole.SelectedItem.ToString();
            bool DONE = controller.Register(US, PW, N, EM, Role);
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
