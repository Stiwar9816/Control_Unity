namespace Contro_unity
{
    partial class MenuReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuReportes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.implementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasParticularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.implementosToolStripMenuItem,
            this.reservasProfesoresToolStripMenuItem,
            this.reservasParticularesToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // implementosToolStripMenuItem
            // 
            this.implementosToolStripMenuItem.Name = "implementosToolStripMenuItem";
            this.implementosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.implementosToolStripMenuItem.Text = "Implementos";
            // 
            // reservasProfesoresToolStripMenuItem
            // 
            this.reservasProfesoresToolStripMenuItem.Name = "reservasProfesoresToolStripMenuItem";
            this.reservasProfesoresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.reservasProfesoresToolStripMenuItem.Text = "Reservas Profesores";
            // 
            // reservasParticularesToolStripMenuItem
            // 
            this.reservasParticularesToolStripMenuItem.Name = "reservasParticularesToolStripMenuItem";
            this.reservasParticularesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.reservasParticularesToolStripMenuItem.Text = "Reservas Particulares";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1001, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.Menu;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1024, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 474);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuReportes";
            this.Text = "MenuReportes";
            this.Load += new System.EventHandler(this.MenuReportes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem implementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasParticularesToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}