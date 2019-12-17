using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.Data
{
    public class UserData
    {
        public String ID;
        public String userName;
        public String password;
        public String email;
        public String name;
        public String role;

        public UserData()
        {
            this.ID = null;
            this.userName = null;
            this.password = null;
            this.email = null;
            this.name = null;
            this.role = null;
        }

        public UserData(String ID, String UN, String PW, String E, String N, String R)
        {
            this.ID = ID;
            this.userName = UN;
            this.password = PW;
            this.email = E;
            this.name = N;
            this.role = R;
        }

        public void Handler(String[] data)
        {
            this.ID = data[0];
            this.userName = data[1];
            this.password = data[2];
            this.email = data[3];
            this.name = data[4];
            this.role = data[5];
        }
        public override String ToString()
        {
            String str = "User ID: " + ID + " UserName: " + userName + " User Password: " + password + " User E-mail: " + email + " User Full Name: " + name + " User Role: " + role;
            return str;
        }

        public void RefactorString(String str)
        {
            try
            {
                String[] tempData = str.Split(' ');
                String[] Refactor = { tempData[2], tempData[5], tempData[7], tempData[10], tempData[14], tempData[17] };
                Handler(Refactor);
            }
            catch
            {
                MessageBox.Show("String: " + str + " is not in the right format");
            }
        }
    }
}
