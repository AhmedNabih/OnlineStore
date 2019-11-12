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
        handler hand;
        public RegisterPage(handler hd)
        {
            hand = hd;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String[] data = {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.SelectedItem.ToString() };

            hand.Register(data);
            MessageBox.Show("Account Created");
            this.Hide();
            loginpage lg = new loginpage(hand);
            lg.Show();
        }
    }
}
