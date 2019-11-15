﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStore.GUIFiles;

namespace OnlineStore
{
    
    public partial class mainPage : Form
    {
        private static mainPage instance = null; // Singelton Pattern

        public static mainPage GetInstance()
        {
            if (instance == null)
                instance = new mainPage();
            return instance;
        }

        private mainPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage lp = new loginpage();
            lp.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage rg = new RegisterPage();
            rg.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Handler.GetInstance().Exit();
        }
    }
  
}
