namespace Repo
{
    partial class MDIPrinc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usarDLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentacionOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ejemplosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connDBToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.leerINIToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usarDLLToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // connDBToolStripMenuItem
            // 
            this.connDBToolStripMenuItem.Name = "connDBToolStripMenuItem";
            this.connDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connDBToolStripMenuItem.Text = "&Conn DB";
            this.connDBToolStripMenuItem.Click += new System.EventHandler(this.connDBToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventosToolStripMenuItem.Text = "&Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // leerINIToolStripMenuItem
            // 
            this.leerINIToolStripMenuItem.Name = "leerINIToolStripMenuItem";
            this.leerINIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leerINIToolStripMenuItem.Text = "Leer INI";
            this.leerINIToolStripMenuItem.Click += new System.EventHandler(this.leerINIToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // usarDLLToolStripMenuItem
            // 
            this.usarDLLToolStripMenuItem.Name = "usarDLLToolStripMenuItem";
            this.usarDLLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usarDLLToolStripMenuItem.Text = "Usar DLL";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentacionOnlineToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentacionOnlineToolStripMenuItem
            // 
            this.documentacionOnlineToolStripMenuItem.Name = "documentacionOnlineToolStripMenuItem";
            this.documentacionOnlineToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.documentacionOnlineToolStripMenuItem.Text = "Documentacion Online";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // MDIPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "MDIPrinc";
            this.Text = "MDIPrinc";
            this.Load += new System.EventHandler(this.MDIPrinc_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0108 // 'MDIPrinc.Menu' oculta el miembro heredado 'Form.Menu'. Use la palabra clave new si su intención era ocultarlo.
        private System.Windows.Forms.MenuStrip Menu;
#pragma warning restore CS0108 // 'MDIPrinc.Menu' oculta el miembro heredado 'Form.Menu'. Use la palabra clave new si su intención era ocultarlo.
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerINIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usarDLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentacionOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}