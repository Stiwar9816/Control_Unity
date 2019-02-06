namespace Contro_unity.Vistas
{
    partial class EditarSalon
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
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNom_Salon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.txtDescripcion);
            this.gbEditInventario.Controls.Add(this.txtNom_Salon);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.LblDescripcion);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(12, 30);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(361, 186);
            this.gbEditInventario.TabIndex = 8;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL SALON";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.HintText = "";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtDescripcion.LineThickness = 2;
            this.txtDescripcion.Location = new System.Drawing.Point(171, 79);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(182, 100);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNom_Salon
            // 
            this.txtNom_Salon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNom_Salon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom_Salon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNom_Salon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom_Salon.HintForeColor = System.Drawing.Color.Empty;
            this.txtNom_Salon.HintText = "";
            this.txtNom_Salon.isPassword = false;
            this.txtNom_Salon.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtNom_Salon.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNom_Salon.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtNom_Salon.LineThickness = 2;
            this.txtNom_Salon.Location = new System.Drawing.Point(171, 17);
            this.txtNom_Salon.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom_Salon.Name = "txtNom_Salon";
            this.txtNom_Salon.Size = new System.Drawing.Size(182, 30);
            this.txtNom_Salon.TabIndex = 8;
            this.txtNom_Salon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbCod_serie
            // 
            this.lbCod_serie.AutoSize = true;
            this.lbCod_serie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod_serie.Location = new System.Drawing.Point(21, 29);
            this.lbCod_serie.Name = "lbCod_serie";
            this.lbCod_serie.Size = new System.Drawing.Size(149, 18);
            this.lbCod_serie.TabIndex = 1;
            this.lbCod_serie.Text = "Nombre Del Salon: ";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(21, 107);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripciòn:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(366, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.BorderRadius = 3;
            this.btnConfirmar.ButtonText = "Confirmar";
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Iconimage = global::Contro_unity.Properties.Resources.icons8_checked_50;
            this.btnConfirmar.Iconimage_right = null;
            this.btnConfirmar.Iconimage_right_Selected = null;
            this.btnConfirmar.Iconimage_Selected = null;
            this.btnConfirmar.IconMarginLeft = 0;
            this.btnConfirmar.IconMarginRight = 0;
            this.btnConfirmar.IconRightVisible = true;
            this.btnConfirmar.IconRightZoom = 0D;
            this.btnConfirmar.IconVisible = true;
            this.btnConfirmar.IconZoom = 55D;
            this.btnConfirmar.IsTab = false;
            this.btnConfirmar.Location = new System.Drawing.Point(115, 236);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmar.selected = false;
            this.btnConfirmar.Size = new System.Drawing.Size(147, 48);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EditarSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbEditInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarSalon";
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditInventario;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNom_Salon;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmar;
    }
}