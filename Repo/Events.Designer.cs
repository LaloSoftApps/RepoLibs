namespace Repo
{
    partial class Events
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnWriteInfo = new System.Windows.Forms.Button();
            this.btnWriteAlert = new System.Windows.Forms.Button();
            this.btnWriteWarning = new System.Windows.Forms.Button();
            this.DgvEventos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Leer Eventos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnWriteInfo
            // 
            this.btnWriteInfo.Location = new System.Drawing.Point(12, 109);
            this.btnWriteInfo.Name = "btnWriteInfo";
            this.btnWriteInfo.Size = new System.Drawing.Size(123, 23);
            this.btnWriteInfo.TabIndex = 1;
            this.btnWriteInfo.Text = "Escribir Info";
            this.btnWriteInfo.UseVisualStyleBackColor = true;
            this.btnWriteInfo.Click += new System.EventHandler(this.btnWriteInfo_Click);
            // 
            // btnWriteAlert
            // 
            this.btnWriteAlert.Location = new System.Drawing.Point(12, 201);
            this.btnWriteAlert.Name = "btnWriteAlert";
            this.btnWriteAlert.Size = new System.Drawing.Size(123, 23);
            this.btnWriteAlert.TabIndex = 3;
            this.btnWriteAlert.Text = "Escribir Alerta";
            this.btnWriteAlert.UseVisualStyleBackColor = true;
            this.btnWriteAlert.Click += new System.EventHandler(this.btnWriteAlert_Click);
            // 
            // btnWriteWarning
            // 
            this.btnWriteWarning.Location = new System.Drawing.Point(12, 157);
            this.btnWriteWarning.Name = "btnWriteWarning";
            this.btnWriteWarning.Size = new System.Drawing.Size(123, 23);
            this.btnWriteWarning.TabIndex = 2;
            this.btnWriteWarning.Text = "Escribir Warning";
            this.btnWriteWarning.UseVisualStyleBackColor = true;
            this.btnWriteWarning.Click += new System.EventHandler(this.btnWriteWarning_Click);
            // 
            // DgvEventos
            // 
            this.DgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEventos.Location = new System.Drawing.Point(147, 65);
            this.DgvEventos.Name = "DgvEventos";
            this.DgvEventos.Size = new System.Drawing.Size(526, 341);
            this.DgvEventos.TabIndex = 4;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.DgvEventos);
            this.Controls.Add(this.btnWriteAlert);
            this.Controls.Add(this.btnWriteWarning);
            this.Controls.Add(this.btnWriteInfo);
            this.Controls.Add(this.button1);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnWriteInfo, 0);
            this.Controls.SetChildIndex(this.btnWriteWarning, 0);
            this.Controls.SetChildIndex(this.btnWriteAlert, 0);
            this.Controls.SetChildIndex(this.DgvEventos, 0);
            this.Controls.SetChildIndex(this.LblCaption, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWriteInfo;
        private System.Windows.Forms.Button btnWriteAlert;
        private System.Windows.Forms.Button btnWriteWarning;
        private System.Windows.Forms.DataGridView DgvEventos;
    }
}