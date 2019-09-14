using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Repo
{
    public partial class Events : FormBase
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            EventLog Events = new EventLog();
            // DgvEventos.DataSource = Events;

            
            foreach (System.Diagnostics.EventLogEntry entry in Events.Entries)
            {
                //Console.WriteLine(entry.Message);
                DgvEventos.Rows.Insert(0,entry);
            }
            
        }
        private void btnWriteInfo_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry(
            "LaloSoft",
            "Mi Linea de Log de Info desde la App.",
            EventLogEntryType.Information,
            1);
        }

        private void btnWriteWarning_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry(
            "LaloSoft",
            "Mi Linea de Log de Warnning desde la App.",
            EventLogEntryType.Warning,
            2);
        }



        private void btnWriteAlert_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry(
                "LaloSoft",
                "Mi Linea de Log de Error desde la App.",
                EventLogEntryType.Error,
                3);
        }


    }
}
