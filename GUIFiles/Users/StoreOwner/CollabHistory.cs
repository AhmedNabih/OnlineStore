using OnlineStore.App.StoreCommand;
using OnlineStore.App.StoreCommand.Commands;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles.Users.StoreOwner
{
    public partial class CollabHistory : Form
    {
        private String StoreID;
        private StoreCommandController controller;
        private StoreCommandInvoker invoker;

        public CollabHistory(String StoreID)
        {
            InitializeComponent();
            this.StoreID = StoreID;
            this.controller = new StoreCommandController();
            this.invoker = new StoreCommandInvoker();
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUndo_Click(object sender, EventArgs e)
        {
            if (HistoryList.SelectedItem == null)
            {
                MessageBox.Show("Select Item");
                return;
            }
            CommandData data = new CommandData();
            String item = HistoryList.SelectedItem.ToString();
            data.RefactorString(item);

            IStoreCommand command = StoreCommandFactory.CreateCommand(data.CmdType);
            bool DONE = this.invoker.UndoCommand(command, data);
            if (DONE)
                MessageBox.Show("Command UnDone");
            else
                MessageBox.Show("Error");

            BShowStoreHistory_Click(sender, e);
        }

        private void BShowStoreHistory_Click(object sender, EventArgs e)
        {
            HistoryList.Items.Clear();
            List<CommandData> commandDatas = controller.GetCommands(this.StoreID);

            if (commandDatas == null)
                return;

            foreach (CommandData cmd in commandDatas)
                HistoryList.Items.Add(cmd.ToString());
        }
    }
}
