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
        private UserController hand;
        public RegisterPage()
        {
            this.hand = UserController.GetInstance();
            InitializeComponent();
        }

        private void Bregister_Click(object sender, EventArgs e)
        {
            String[] data = {TuserName.Text, Tpassword.Text, Tname.Text, Temail.Text, Trole.SelectedItem.ToString() };

            hand.Register(data);
            MessageBox.Show("Account Created");
            this.Hide();
            loginpage lg = new loginpage();
            lg.Show();
        }

        private void Bback_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }
    }
}
