using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore.App
{
    public class AppController
    {
        private static AppController instance = null; // Singelton pattern

        private AppController()
        {

        }
        
        public static AppController GetInstace()
        {
            if (instance == null)
                instance = new AppController();
            return instance;
        }

        public static void Exit()
        {
            Application.Exit();
        }
    }
}
