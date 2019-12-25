using OnlineStore.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineStore.GUIFiles.Users.StoreOwner
{
    public partial class CollaboratorsPage : Form
    {
        private CollaboratorController controller;
        public CollaboratorsPage(CollaboratorController collaboratorController)
        {
            this.controller = collaboratorController;
            InitializeComponent();
        }

        private void BShowCollaborator_Click(object sender, EventArgs e)
        {
            CollaboratorsList.Items.Clear();

            List<Collaborator> collaboratorList = controller.GetCollaborators(controller.StoreID);
            if (collaboratorList == null)
                return;

            foreach(Collaborator collaborator in collaboratorList)
            {
                CollaboratorsList.Items.Add(collaborator.ToString());
            }
        }

        private void BAddCollaborator_Click(object sender, EventArgs e)
        {
            if (TUserID.Text == null || TUserID.Text == "")
                return;

            String Username = TUserID.Text;
            UserData userdata = controller.CheckRole(Username);
            if (userdata == null)
            {
                MessageBox.Show("Username Is not a store Owner or does not exists");
                return;
            }

            bool DONE = this.controller.AddCollaborator(userdata.ID, controller.StoreID);
            if (DONE)
                MessageBox.Show("Collaborator Added");
            else
                MessageBox.Show("Collaborator Add failed");

            this.BShowCollaborator_Click(sender, e);
        }

        private void BEditCollaborator_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void BDeleteCollaborator_Click(object sender, EventArgs e)
        {
            if (CollaboratorsList.SelectedItem == null)
                return;

            String SelectedItem = CollaboratorsList.SelectedItem.ToString();
            Collaborator tempData = new Collaborator();
            tempData.RefactorString(SelectedItem);

            bool DONE = this.controller.RemoveCollaborator(tempData.UserID, controller.StoreID);
            if (DONE)
                MessageBox.Show("Collaborator Deleted");
            else
                MessageBox.Show("Collaborator Deletion failed");

            this.BShowCollaborator_Click(sender, e);
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
