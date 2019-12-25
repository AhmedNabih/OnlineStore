using System;
using System.Windows.Forms;

namespace OnlineStore.Data
{
    public class Collaborator
    {
        public String UserID;
        public String Name;

        public Collaborator()
        {
            this.UserID = null;
            this.Name = null;
        }

        public Collaborator(String UserID, String Name)
        {
            this.UserID = UserID;
            this.Name = Name;
        }

        public void Handler(String[] data)
        {
            this.UserID = data[0];
            this.Name = data[1];
        }

        public override String ToString()
        {
            String str = "User ID: " + UserID + " Name: " + Name;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[4] };
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }

}
