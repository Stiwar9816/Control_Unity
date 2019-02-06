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
            this.components = new System.ComponentModel.Container();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RPInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(1000, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 25);
            this.panel1.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage4.Controls.Add(this.reportViewer5);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1030, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporte Reservas Usuarios";
            // 
            // reportViewer5
            // 
            this.reportViewer5.BackColor = System.Drawing.SystemColors.Menu;
            this.reportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1024, 416);
            this.reportViewer5.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage3.Controls.Add(this.reportViewer4);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1030, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte Reservas Profesores";
            // 
            // reportViewer4
            // 
            this.reportViewer4.BackColor = System.Drawing.SystemColors.Menu;
            this.reportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1024, 416);
            this.reportViewer4.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.reportViewer3);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte Salones";
            // 
            // reportViewer3
            // 
            this.reportViewer3.BackColor = System.Drawing.SystemColors.Menu;
            this.reportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1024, 416);
            this.reportViewer3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 28);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 451);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.RPInventario);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte Inventario";
            // 
            // RPInventario
            // 
            this.RPInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.RPInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RPInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPInventario.Location = new System.Drawing.Point(3, 3);
            this.RPInventario.Name = "RPInventario";
            this.RPInventario.ServerReport.BearerToken = null;
            this.RPInventario.Size = new System.Drawing.Size(1024, 416);
            this.RPInventario.TabIndex = 0;
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuReportes";
            this.Text = "MenuReportes";
            this.Load += new System.EventHandler(this.MenuReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer RPInventario;
    }
}