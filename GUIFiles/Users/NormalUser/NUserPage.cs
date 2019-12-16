using OnlineStore.Database_Files;
using OnlineStore.GUIFiles;
using OnlineStore.srcFiles;
using OnlineStore.Users.NormalUsers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class NUserPage : Form
    {
        private IUser user;
        private DataBase dataBase;

        public NUserPage(NormalUser user)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);

            this.user = user;
            InitializeComponent();
            TuserName.Text = user.Data.userName;
            Temail.Text = user.Data.email;
            Tname.Text = user.Data.name;
            Trole.Text = user.Data.role;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Store_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NUserPage_Load(object sender, EventArgs e)
        {
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Store.Items.Clear();
            DataTable tpData= dataBase.GetAllStores();
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Store.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void OpenStore_Click(object sender, EventArgs e)
        {
            Products.Items.Clear();
            String[] s=null;
            List<int> select = new List<int>();

            for (int i = 0; i < Store.Items.Count; i++)
            {
                if (Store.GetItemChecked(i))
                {
                    select.Add(i);
                    break;
                }
            }
            foreach (int inx in select)
            {
                s = Store.Items[inx].ToString().Split(',');
            }
           DataTable tpData = dataBase.GetProductsInStore(s[1]);
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Products.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        
        }
    }
}
