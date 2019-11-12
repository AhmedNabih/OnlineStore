using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
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
        

    }
}
