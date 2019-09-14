using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repo
{
    public partial class ReadIni : FormBase
    {
        public ReadIni()
        {
            InitializeComponent();
        }

        private void ReadIni_Load(object sender, EventArgs e)
        {
            // Las variables se cargan publicas en el Formuario Base
            txtAppName.Text = Global_AppName.ToString();
            txtAppPath.Text = Global_AppPath.ToString();
            
            txtDBEngine.Text = Global_DBEngine.ToString();
            txtDBServer.Text = Global_DBServer.ToString();
            txtDBName.Text = Global_DBName.ToString();
            TxtDBUser.Text = Global_DBUser.ToString();
            txtDBUserPwd.Text = Global_DBUserPwd.ToString();
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
