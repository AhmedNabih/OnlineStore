using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.GUIFiles;
using OnlineStore.srcFiles;

namespace OnlineStore
{
    public partial class StoreOwnerPage : Form
    {
        public StoreOwner SO;
        private handler hand;

        public StoreOwnerPage(StoreOwner SO, handler hand)
        {
            this.SO = SO;
            this.hand = hand;
            InitializeComponent();
            TuserName.Text = SO.Data.userName;
            Tname.Text = SO.Data.name;
            Temail.Text = SO.Data.email;
            Trole.Text = SO.Data.role;
        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            addStorePage asp = new addStorePage(SO);
            asp.Show();
        }

        private void ShowStore_Click(object sender, EventArgs e)
        {
            List<int> select = new List<int>();
            for (int i = 0; i < MyStores.Items.Count; i++)
            {
                if (MyStores.GetItemChecked(i))
                {
                    select.Add(i);
                }
            }
            foreach (int inx in select)
            {                
                StoreLayoutPage slp = new StoreLayoutPage(SO,SO.storeslist[inx],hand);
                slp.Show();
            }
        }

        private void RefreshStoreList_Click(object sender, EventArgs e)
        {
            SO.RefreshData();
            MyStores.Items.Clear();
            for(int i=0; i<SO.storeslist.Length; i++)
            {
                String tp = SO.storeslist[i].SD.ID+","+ SO.storeslist[i].SD.Name +","+ SO.storeslist[i].SD.Type+","+ SO.storeslist[i].SD.Location+","+ SO.storeslist[i].SD.Info;
                MyStores.Items.Add(tp);
            }
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            hand.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            mainPage mp = new mainPage(hand);
            mp.Show();
        }

        private void DeleteStores_Click(object sender, EventArgs e)
        {
            List<int> select = new List<int>();
            for (int i = 0; i < MyStores.Items.Count; i++)
            {
                if (MyStores.GetItemChecked(i))
                {
                    select.Add(i);
                }
            }
            foreach (int inx in select)
            {
                SO.DeleteStore(MyStores.Items[inx].ToString().Split(',')[0]);
                MessageBox.Show("Store Deleted");
            }
        }
    }
}
