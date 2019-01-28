namespace Contro_unity
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnConfiguraciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtRol);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 83);
            this.panel1.TabIndex = 12;
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(59, 23);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(86, 18);
            this.txtRol.TabIndex = 9;
            this.txtRol.Text = "Developer";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(59, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 18);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "Stiwar Asprilla";
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.LightGray;
            this.menuVertical.Controls.Add(this.btnConfiguraciones);
            this.menuVertical.Controls.Add(this.btnUsuarios);
            this.menuVertical.Controls.Add(this.btnReservas);
            this.menuVertical.Controls.Add(this.btnProfesores);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.btnInventario);
            this.menuVertical.Controls.Add(this.btnSalones);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(200, 671);
            this.menuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.btnInfo);
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1024, 41);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 41);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1024, 630);
            this.PanelContenedor.TabIndex = 2;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = global::Contro_unity.Properties.Resources.icons8_info_500;
            this.btnInfo.Location = new System.Drawing.Point(876, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(21, 23);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 5;
            this.btnInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInfo, "Notificaciones");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Contro_unity.Properties.Resources.icons8_notification_50;
            this.pictureBox3.Location = new System.Drawing.Point(849, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Notificaciones");
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Contro_unity.Properties.Resources.icons8_compress_50;
            this.btnRestaurar.Location = new System.Drawing.Point(971, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 23);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRestaurar, "Restaurar");
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Contro_unity.Properties.Resources.icons8_enlarge_50;
            this.btnMaximizar.Location = new System.Drawing.Point(971, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 23);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMaximizar, "Maximizar");
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Contro_unity.Properties.Resources.icons8_expand_arrow_50;
            this.btnMinimizar.Location = new System.Drawing.Point(944, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(998, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Contro_unity.Properties.Resources.icons8_menu_50;
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(31, 32);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSlide, "Ocultar Menù");
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Activecolor = System.Drawing.Color.Khaki;
            this.btnConfiguraciones.BackColor = System.Drawing.Color.LightGray;
            this.btnConfiguraciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguraciones.BorderRadius = 5;
            this.btnConfiguraciones.ButtonText = "Configuraciones";
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguraciones.DisabledColor = System.Drawing.Color.LightGray;
            this.btnConfiguraciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguraciones.Iconimage = global::Contro_unity.Properties.Resources.icons8_maintenance_50;
            this.btnConfiguraciones.Iconimage_right = null;
            this.btnConfiguraciones.Iconimage_right_Selected = null;
            this.btnConfiguraciones.Iconimage_Selected = null;
            this.btnConfiguraciones.IconMarginLeft = 0;
            this.btnConfiguraciones.IconMarginRight = 0;
            this.btnConfiguraciones.IconRightVisible = true;
            this.btnConfiguraciones.IconRightZoom = 0D;
            this.btnConfiguraciones.IconVisible = true;
            this.btnConfiguraciones.IconZoom = 50D;
            this.btnConfiguraciones.IsTab = false;
            this.btnConfiguraciones.Location = new System.Drawing.Point(8, 401);
            this.btnConfiguraciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Normalcolor = System.Drawing.Color.LightGray;
            this.btnConfiguraciones.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnConfiguraciones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfiguraciones.selected = false;
            this.btnConfiguraciones.Size = new System.Drawing.Size(192, 45);
            this.btnConfiguraciones.TabIndex = 7;
            this.btnConfiguraciones.Text = "Configuraciones";
            this.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguraciones.Textcolor = System.Drawing.Color.Black;
            this.btnConfiguraciones.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.Khaki;
            this.btnUsuarios.BackColor = System.Drawing.Color.LightGray;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.BorderRadius = 5;
            this.btnUsuarios.ButtonText = "Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Iconimage")));
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 50D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(8, 354);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.LightGray;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUsuarios.selected = false;
            this.btnUsuarios.Size = new System.Drawing.Size(192, 45);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuarios.Textcolor = System.Drawing.Color.Black;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Activecolor = System.Drawing.Color.Khaki;
            this.btnReservas.BackColor = System.Drawing.Color.LightGray;
            this.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReservas.BorderRadius = 5;
            this.btnReservas.ButtonText = "Reservas";
            this.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservas.DisabledColor = System.Drawing.Color.LightGray;
            this.btnReservas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservas.Iconimage = global::Contro_unity.Properties.Resources.icons8_schedule_50;
            this.btnReservas.Iconimage_right = null;
            this.btnReservas.Iconimage_right_Selected = null;
            this.btnReservas.Iconimage_Selected = null;
            this.btnReservas.IconMarginLeft = 0;
            this.btnReservas.IconMarginRight = 0;
            this.btnReservas.IconRightVisible = true;
            this.btnReservas.IconRightZoom = 0D;
            this.btnReservas.IconVisible = true;
            this.btnReservas.IconZoom = 50D;
            this.btnReservas.IsTab = false;
            this.btnReservas.Location = new System.Drawing.Point(8, 308);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Normalcolor = System.Drawing.Color.LightGray;
            this.btnReservas.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnReservas.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnReservas.selected = false;
            this.btnReservas.Size = new System.Drawing.Size(192, 45);
            this.btnReservas.TabIndex = 6;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReservas.Textcolor = System.Drawing.Color.Black;
            this.btnReservas.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Activecolor = System.Drawing.Color.Khaki;
            this.btnProfesores.BackColor = System.Drawing.Color.LightGray;
            this.btnProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfesores.BorderRadius = 5;
            this.btnProfesores.ButtonText = "Profesores";
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesores.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnProfesores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfesores.Iconimage = global::Contro_unity.Properties.Resources.icons8_school_director_50;
            this.btnProfesores.Iconimage_right = null;
            this.btnProfesores.Iconimage_right_Selected = null;
            this.btnProfesores.Iconimage_Selected = null;
            this.btnProfesores.IconMarginLeft = 0;
            this.btnProfesores.IconMarginRight = 0;
            this.btnProfesores.IconRightVisible = true;
            this.btnProfesores.IconRightZoom = 0D;
            this.btnProfesores.IconVisible = true;
            this.btnProfesores.IconZoom = 50D;
            this.btnProfesores.IsTab = false;
            this.btnProfesores.Location = new System.Drawing.Point(8, 258);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Normalcolor = System.Drawing.Color.LightGray;
            this.btnProfesores.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnProfesores.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnProfesores.selected = false;
            this.btnProfesores.Size = new System.Drawing.Size(192, 45);
            this.btnProfesores.TabIndex = 4;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfesores.Textcolor = System.Drawing.Color.Black;
            this.btnProfesores.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click_1);
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.Khaki;
            this.btnReportes.BackColor = System.Drawing.Color.LightGray;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportes.BorderRadius = 5;
            this.btnReportes.ButtonText = "Reportes";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.LightGray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = global::Contro_unity.Properties.Resources.icons8_increase_50;
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 50D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(8, 214);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.LightGray;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(192, 45);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportes.Textcolor = System.Drawing.Color.Black;
            this.btnReportes.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.Khaki;
            this.btnInventario.BackColor = System.Drawing.Color.LightGray;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.BorderRadius = 5;
            this.btnInventario.ButtonText = "Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.LightGray;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = global::Contro_unity.Properties.Resources.icons8_box_50;
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 50D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(8, 123);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.LightGray;
            this.btnInventario.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(192, 45);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInventario.Textcolor = System.Drawing.Color.Black;
            this.btnInventario.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click_1);
            // 
            // btnSalones
            // 
            this.btnSalones.Activecolor = System.Drawing.Color.Khaki;
            this.btnSalones.BackColor = System.Drawing.Color.LightGray;
            this.btnSalones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalones.BorderRadius = 5;
            this.btnSalones.ButtonText = "Salones";
            this.btnSalones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalones.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnSalones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalones.Iconimage = global::Contro_unity.Properties.Resources.icons8_classroom_50;
            this.btnSalones.Iconimage_right = null;
            this.btnSalones.Iconimage_right_Selected = null;
            this.btnSalones.Iconimage_Selected = null;
            this.btnSalones.IconMarginLeft = 0;
            this.btnSalones.IconMarginRight = 0;
            this.btnSalones.IconRightVisible = true;
            this.btnSalones.IconRightZoom = 0D;
            this.btnSalones.IconVisible = true;
            this.btnSalones.IconZoom = 50D;
            this.btnSalones.IsTab = false;
            this.btnSalones.Location = new System.Drawing.Point(8, 170);
            this.btnSalones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalones.Name = "btnSalones";
            this.btnSalones.Normalcolor = System.Drawing.Color.LightGray;
            this.btnSalones.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnSalones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSalones.selected = false;
            this.btnSalones.Size = new System.Drawing.Size(192, 45);
            this.btnSalones.TabIndex = 3;
            this.btnSalones.Text = "Salones";
            this.btnSalones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalones.Textcolor = System.Drawing.Color.Black;
            this.btnSalones.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalones.Click += new System.EventHandler(this.btnSalones_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Khaki;
            this.btnInicio.BackColor = System.Drawing.Color.LightGray;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.BorderRadius = 5;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::Contro_unity.Properties.Resources.icons8_home_50;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 50D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(8, 79);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.LightGray;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(192, 45);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.Black;
            this.btnInicio.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Contro_unity.Properties.Resources.icons8_user_avatar_50;
            this.pictureBox2.Location = new System.Drawing.Point(8, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1224, 671);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel menuVertical;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguraciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfesores;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalones;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtRol;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnInfo;
    }
}