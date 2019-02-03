namespace Contro_unity.Vistas
{
    partial class RecuperarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRecuperarPass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 276);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Contro_unity.Properties.Resources.icons8_expand_arrow_50;
            this.btnminimizar.Location = new System.Drawing.Point(590, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(20, 17);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btncerrar.Location = new System.Drawing.Point(613, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(17, 17);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 9;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(236, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "INGRESE SU USUARIO:";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Menu;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuser.HintForeColor = System.Drawing.Color.Empty;
            this.txtuser.HintText = "";
            this.txtuser.isPassword = false;
            this.txtuser.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtuser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtuser.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtuser.LineThickness = 2;
            this.txtuser.Location = new System.Drawing.Point(397, 35);
            this.txtuser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(215, 34);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "Usuario";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // btnRecuperarPass
            // 
            this.btnRecuperarPass.Activecolor = System.Drawing.Color.DarkGray;
            this.btnRecuperarPass.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRecuperarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperarPass.BorderRadius = 5;
            this.btnRecuperarPass.ButtonText = "RECUPERAR CONTRASEÑA";
            this.btnRecuperarPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperarPass.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecuperarPass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecuperarPass.Iconimage = null;
            this.btnRecuperarPass.Iconimage_right = global::Contro_unity.Properties.Resources.icons8_key_50;
            this.btnRecuperarPass.Iconimage_right_Selected = null;
            this.btnRecuperarPass.Iconimage_Selected = null;
            this.btnRecuperarPass.IconMarginLeft = 0;
            this.btnRecuperarPass.IconMarginRight = 0;
            this.btnRecuperarPass.IconRightVisible = true;
            this.btnRecuperarPass.IconRightZoom = 0D;
            this.btnRecuperarPass.IconVisible = true;
            this.btnRecuperarPass.IconZoom = 60D;
            this.btnRecuperarPass.IsTab = false;
            this.btnRecuperarPass.Location = new System.Drawing.Point(294, 225);
            this.btnRecuperarPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecuperarPass.Name = "btnRecuperarPass";
            this.btnRecuperarPass.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnRecuperarPass.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnRecuperarPass.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecuperarPass.selected = false;
            this.btnRecuperarPass.Size = new System.Drawing.Size(265, 38);
            this.btnRecuperarPass.TabIndex = 2;
            this.btnRecuperarPass.Text = "RECUPERAR CONTRASEÑA";
            this.btnRecuperarPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecuperarPass.Textcolor = System.Drawing.Color.Black;
            this.btnRecuperarPass.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic);
            this.btnRecuperarPass.Click += new System.EventHandler(this.btnRecuperarPass_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.txtMensaje.Location = new System.Drawing.Point(269, 92);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(343, 105);
            this.txtMensaje.TabIndex = 13;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // RecuperarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(634, 276);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnRecuperarPass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnminimizar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecuperarPass";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarPass";
            this.Load += new System.EventHandler(this.RecuperarPass_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperarPass_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtuser;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecuperarPass;
        private System.Windows.Forms.TextBox txtMensaje;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}