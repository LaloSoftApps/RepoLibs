using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Repo
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        // Variables Globales
        public string Global_DBEngine = "SqlServer";
        public string Global_DBServer = ".";
        public string Global_DBName = "master";
        public string Global_DBUser = "sa";
        public string Global_DBUserPwd = "";
        public string Global_AppName = "LaloSoft";
        public string Global_AppPath = "C:/LaloSoft";
        
        private void FormBase_Load(object sender, EventArgs e)
        {
            // Cargamos las Variables del INI
            String Line, VarDesc, VarValue;
            TextReader ConfigFile;
            ConfigFile = new StreamReader("repo.ini");
            
            while ((Line = ConfigFile.ReadLine()) != null)
            {
                // Validaos que no sea una linea en blanco y que tenga 2 parametros (par1=par2)
                if ( (Line.Trim() != "") && (Line.Contains("=")) )
                {
                    VarDesc = Line.Split('=')[0];
                    VarValue = Line.Split('=')[1];

                    switch (VarDesc.Trim())
                    {
                        // DB Variables
                        case "DBEngine":
                            Global_DBEngine = VarValue.ToString();
                            break;
                        case "DBServer":
                            Global_DBServer = VarValue.ToString();
                            break;
                        case "DBName":
                            Global_DBName = VarValue.ToString();
                            break;
                        case "DBUser":
                            Global_DBUser = VarValue.ToString();
                            break;
                        case "DBUserPwd":
                            Global_DBUserPwd = VarValue.ToString();
                            break;

                        // App Variables
                        case "AppPath":
                            Global_AppPath = VarValue.ToString();
                            break;
                        case "AppName":
                            Global_AppName = VarValue.ToString();
                            break;
                    }
                }
            }

            ConfigFile.Close();
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
