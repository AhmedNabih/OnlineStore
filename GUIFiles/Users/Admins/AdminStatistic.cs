using OnlineStore.Database_Files;
using OnlineStore.Users.Admins;
using OnlineStore.Users.Admins.AdminsStatisticsSystem;
using OnlineStore.Users.Admins.AdminsStatisticsSystem.Commands;
using OnlineStore.Users.Admins.AdminsStatisticsSystem.Receivers.ReceiverFactory;
using OnlineStore.Users.Admins.AdminsStatisticsSystemCommands.Receivers.ReceiverStrategyPattern;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles.Users.Admins
{
    public partial class AdminStatistic : Form
    {
        private AdminsController controller;
        private bool Users, Store;

        public AdminStatistic(AdminsController controller)
        {
            this.controller = controller;
            this.Users = false;
            this.Store = false;
            InitializeComponent();

            TuserName.Text = controller.admin.Data.userName;
            Temail.Text = controller.admin.Data.email;
            Tname.Text = controller.admin.Data.name;
            Trole.Text = controller.admin.Data.role;
        }
        /*
        private void BShowUsers_Click(object sender, EventArgs e)
        {
            this.Users = true;
            this.Store = false;
            StatBox.Items.Clear();
            StatBox.Items.Add("All");

            // UserID, UserName, Name, Email, Role
            DataTable tpData = dataBase.GetUsersData();

            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ", ";
                }
                StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
            }
        }

        private void BShowStores_Click(object sender, EventArgs e)
        {
            String SelectedString;
            DataTable tpData = new DataTable();

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Users && SelectedString != "All")
                {
                    // StoreID, StoreName, StoreType, StoreLocation, StoreInfo
                 //   tpData = dataBase.GetStore(SelectedString.Split(',')[0]);
                }
                else
                {
                    // UserID, UserName, StoreID, StoreName, StoreType, StoreLocation, StoreInfo
               //     tpData = dataBase.GetAllStores();
                }

                this.Users = false;
                this.Store = true;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (DataRow row in tpData.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tpData.Columns)
                    {
                        tpStr += row[col].ToString() + ", ";
                    }
                    StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
                }
            }

        }

        private void BShowProducts_Click(object sender, EventArgs e)
        {
            String SelectedString;
            DataTable tpData = new DataTable();

            if (StatBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Something.");
            }
            else
            {
                SelectedString = StatBox.SelectedItem.ToString();
                if (this.Store && SelectedString != "All")
                {
                    // StoreID, ProductName, price, amount
              //      tpData = dataBase.GetProductsInStore(SelectedString.Split(new String[] { ", "},StringSplitOptions.RemoveEmptyEntries)[2]);
                }
                else
                {
                    // // StoreID, ProductName, price, amount
                   // tpData = dataBase.GetAllProductsInStore();
                }

                this.Users = false;
                this.Store = false;
                StatBox.Items.Clear();
                StatBox.Items.Add("All");
                foreach (DataRow row in tpData.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tpData.Columns)
                    {
                        tpStr += row[col].ToString() + ", ";
                    }
                    StatBox.Items.Add(tpStr.Substring(0, tpStr.Length - 2));
                }
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            this.Users = false;
            this.Store = false;
            StatBox.Items.Clear();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            
        }

        private void BProcess_Click(object sender, EventArgs e)
        {
            // kind operation onwhat
            if (OperationBox.SelectedItem == null || KindBox.SelectedItem == null || OnWhatBox.SelectedItem == null)
                MessageBox.Show("select select everything");
            else
            {
                ICommand cmd;
                String arg1 = KindBox.SelectedItem.ToString() + " " + OperationBox.SelectedItem.ToString() + " " + OnWhatBox.SelectedItem.ToString();
                String arg2 = UserStoreID.Text == "" ? null : UserStoreID.Text; 
                if(OperationBox.SelectedItem.ToString() == "Sum")
                {
                    ISum sum = SumFactory.GetCommand(arg1, arg2);
                    cmd = new SumCommand(sum);
                }
                else if(OperationBox.SelectedItem.ToString() == "Average")
                {
                    IAverage average = AverageFactory.GetCommand(arg1, arg2);
                    cmd = new AverageCommand(average);
                }
                else if(OperationBox.SelectedItem.ToString() == "Max")
                {
                    IMax max = MaxFactory.GetCommand(arg1, arg2);
                    cmd = new MaxCommand(max);
                }
                else
                {
                    IMin min = MinFactory.GetCommand(arg1, arg2);
                    cmd = new MinCommand(min);
                }
                String res = CommandInvoker.DoCommand(cmd);
                String screen = Output.Text + "\n" + res;
                Output.Text = screen;
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 */   }
}
