namespace Contro_unity.Vistas
{
    partial class EditarInventario
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
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCod_Serie = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.txtStock);
            this.gbEditInventario.Controls.Add(this.txtDescripcion);
            this.gbEditInventario.Controls.Add(this.txtMarca);
            this.gbEditInventario.Controls.Add(this.txtNombre);
            this.gbEditInventario.Controls.Add(this.txtCod_Serie);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.LblDescripcion);
            this.gbEditInventario.Controls.Add(this.lblNombre);
            this.gbEditInventario.Controls.Add(this.lblStock);
            this.gbEditInventario.Controls.Add(this.lblMarca);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(12, 26);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(363, 292);
            this.gbEditInventario.TabIndex = 17;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL IMPLEMENTO";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStock.Location = new System.Drawing.Point(150, 105);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(44, 19);
            this.txtStock.TabIndex = 19;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtDescripcion.Location = new System.Drawing.Point(150, 177);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 100);
            this.txtDescripcion.TabIndex = 22;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.HintForeColor = System.Drawing.Color.Empty;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtMarca.LineThickness = 2;
            this.txtMarca.Location = new System.Drawing.Point(150, 128);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 30);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtNombre.LineThickness = 2;
            this.txtNombre.Location = new System.Drawing.Point(150, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 30);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCod_Serie
            // 
            this.txtCod_Serie.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCod_Serie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCod_Serie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCod_Serie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCod_Serie.HintForeColor = System.Drawing.Color.Empty;
            this.txtCod_Serie.HintText = "";
            this.txtCod_Serie.isPassword = false;
            this.txtCod_Serie.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtCod_Serie.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCod_Serie.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtCod_Serie.LineThickness = 2;
            this.txtCod_Serie.Location = new System.Drawing.Point(150, 17);
            this.txtCod_Serie.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod_Serie.Name = "txtCod_Serie";
            this.txtCod_Serie.Size = new System.Drawing.Size(200, 30);
            this.txtCod_Serie.TabIndex = 17;
            this.txtCod_Serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbCod_serie
            // 
            this.lbCod_serie.AutoSize = true;
            this.lbCod_serie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod_serie.Location = new System.Drawing.Point(21, 29);
            this.lbCod_serie.Name = "lbCod_serie";
            this.lbCod_serie.Size = new System.Drawing.Size(112, 18);
            this.lbCod_serie.TabIndex = 0;
            this.lbCod_serie.Text = "Codigo Serie: ";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(21, 221);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.LblDescripcion.TabIndex = 5;
            this.LblDescripcion.Text = "Descripciòn:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(21, 106);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 18);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 140);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 18);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca: ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(364, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
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
            this.btnConfirmar.Location = new System.Drawing.Point(114, 332);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmar.selected = false;
            this.btnConfirmar.Size = new System.Drawing.Size(147, 48);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(387, 394);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbEditInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarInventario";
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditInventario;
        public System.Windows.Forms.NumericUpDown txtStock;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCod_Serie;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmar;
    }
}