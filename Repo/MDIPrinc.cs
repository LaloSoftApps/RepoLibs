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
    public partial class MDIPrinc : Form
    {
        public MDIPrinc()
        {
            InitializeComponent();
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está Seguro que Desea Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void connDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConn DbForm = new DBConn();
            DbForm.MdiParent = this;
            DbForm.Show();
        }

        private void leerINIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadIni ReadIniForm = new ReadIni();
            ReadIniForm.MdiParent = this;
            ReadIniForm.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Events EventForm = new Events();
            EventForm.MdiParent = this;
            EventForm.Show();
        }
    }
}
