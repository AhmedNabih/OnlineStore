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
    public partial class AdminStatistic : Form
    {
        private Handler hand;
        private MyDataBase DB;
        public AdminStatistic()
        {
            hand = Handler.GetInstance();
            DB = hand.DB;
            InitializeComponent();
        }

        private void BSelect_Click(object sender, EventArgs e)
        {

        }

        private void BShowStores_Click(object sender, EventArgs e)
        {

        }

        private void BShowUsers_Click(object sender, EventArgs e)
        {

        }

        
    }
}
