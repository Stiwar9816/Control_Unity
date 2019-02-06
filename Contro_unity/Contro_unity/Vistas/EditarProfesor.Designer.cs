namespace Contro_unity.Vistas
{
    partial class EditarProfesor
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
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.txtPrograma = new System.Windows.Forms.ComboBox();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbEditInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(433, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.txtPrograma);
            this.gbEditInventario.Controls.Add(this.txtFullName);
            this.gbEditInventario.Controls.Add(this.txtCC);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.lblNombre);
            this.gbEditInventario.Controls.Add(this.lblMarca);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(12, 31);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(428, 147);
            this.gbEditInventario.TabIndex = 6;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL PROFESOR";
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPrograma.FormattingEnabled = true;
            this.txtPrograma.Items.AddRange(new object[] {
            "Ingenieria Industrial",
            "Ingenieria Sistemas",
            "Psicologia",
            "Antropologia",
            "Ingles",
            "Trabajo Social",
            "Otro"});
            this.txtPrograma.Location = new System.Drawing.Point(182, 96);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(239, 24);
            this.txtPrograma.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFullName.HintText = "";
            this.txtFullName.isPassword = false;
            this.txtFullName.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtFullName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFullName.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtFullName.LineThickness = 2;
            this.txtFullName.Location = new System.Drawing.Point(182, 58);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(239, 24);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCC
            // 
            this.txtCC.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtCC.HintText = "";
            this.txtCC.isPassword = false;
            this.txtCC.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtCC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCC.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtCC.LineThickness = 2;
            this.txtCC.Location = new System.Drawing.Point(182, 23);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(239, 24);
            this.txtCC.TabIndex = 6;
            this.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbCod_serie
            // 
            this.lbCod_serie.AutoSize = true;
            this.lbCod_serie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod_serie.Location = new System.Drawing.Point(21, 29);
            this.lbCod_serie.Name = "lbCod_serie";
            this.lbCod_serie.Size = new System.Drawing.Size(44, 18);
            this.lbCod_serie.TabIndex = 0;
            this.lbCod_serie.Text = "C.C: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(155, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 102);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(89, 18);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Programa: ";
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
            this.btnConfirmar.Location = new System.Drawing.Point(148, 190);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmar.selected = false;
            this.btnConfirmar.Size = new System.Drawing.Size(147, 48);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EditarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(455, 254);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbEditInventario);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbEditInventario;
        public System.Windows.Forms.ComboBox txtPrograma;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFullName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCC;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmar;
    }
}