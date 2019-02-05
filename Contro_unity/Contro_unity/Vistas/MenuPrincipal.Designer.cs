﻿namespace Contro_unity
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
            this.btnReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRoluser = new System.Windows.Forms.Label();
            this.txtNombreuser = new System.Windows.Forms.Label();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnRestaurar.Visible = false;
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
            this.btnConfiguraciones.Location = new System.Drawing.Point(8, 372);
            this.btnConfiguraciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Normalcolor = System.Drawing.Color.LightGray;
            this.btnConfiguraciones.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnConfiguraciones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfiguraciones.selected = false;
            this.btnConfiguraciones.Size = new System.Drawing.Size(192, 43);
            this.btnConfiguraciones.TabIndex = 7;
            this.btnConfiguraciones.Text = "Configuraciones";
            this.btnConfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguraciones.Textcolor = System.Drawing.Color.Black;
            this.btnConfiguraciones.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfiguraciones, "Configuraciones");
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
            this.btnUsuarios.Location = new System.Drawing.Point(8, 417);
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
            this.toolTip1.SetToolTip(this.btnUsuarios, "Usuarios");
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
            this.btnReservas.Location = new System.Drawing.Point(8, 225);
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
            this.toolTip1.SetToolTip(this.btnReservas, "Reservas");
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Activecolor = System.Drawing.Color.Khaki;
            this.btnReporte.BackColor = System.Drawing.Color.LightGray;
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReporte.BorderRadius = 5;
            this.btnReporte.ButtonText = "Reportes";
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.DisabledColor = System.Drawing.Color.LightGray;
            this.btnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReporte.Iconimage = global::Contro_unity.Properties.Resources.icons8_increase_50;
            this.btnReporte.Iconimage_right = null;
            this.btnReporte.Iconimage_right_Selected = null;
            this.btnReporte.Iconimage_Selected = null;
            this.btnReporte.IconMarginLeft = 0;
            this.btnReporte.IconMarginRight = 0;
            this.btnReporte.IconRightVisible = true;
            this.btnReporte.IconRightZoom = 0D;
            this.btnReporte.IconVisible = true;
            this.btnReporte.IconZoom = 50D;
            this.btnReporte.IsTab = false;
            this.btnReporte.Location = new System.Drawing.Point(8, 274);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Normalcolor = System.Drawing.Color.LightGray;
            this.btnReporte.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnReporte.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnReporte.selected = false;
            this.btnReporte.Size = new System.Drawing.Size(192, 45);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReporte.Textcolor = System.Drawing.Color.Black;
            this.btnReporte.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnReporte, "Reportes");
            this.btnReporte.Click += new System.EventHandler(this.btnReportes_Click_1);
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
            this.btnProfesores.Location = new System.Drawing.Point(8, 127);
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
            this.toolTip1.SetToolTip(this.btnProfesores, "Profesores");
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click_1);
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
            this.btnInventario.Location = new System.Drawing.Point(8, 323);
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
            this.toolTip1.SetToolTip(this.btnInventario, "Inventario");
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
            this.btnSalones.Location = new System.Drawing.Point(8, 176);
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
            this.toolTip1.SetToolTip(this.btnSalones, "Salones");
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
            this.toolTip1.SetToolTip(this.btnInicio, "Inicio");
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Activecolor = System.Drawing.Color.Khaki;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.BorderRadius = 5;
            this.btnCerrarSesion.ButtonText = "Cerrar Sesiòn";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Iconimage = global::Contro_unity.Properties.Resources.icons8_sign_out_50;
            this.btnCerrarSesion.Iconimage_right = null;
            this.btnCerrarSesion.Iconimage_right_Selected = null;
            this.btnCerrarSesion.Iconimage_Selected = null;
            this.btnCerrarSesion.IconMarginLeft = 0;
            this.btnCerrarSesion.IconMarginRight = 0;
            this.btnCerrarSesion.IconRightVisible = true;
            this.btnCerrarSesion.IconRightZoom = 0D;
            this.btnCerrarSesion.IconVisible = true;
            this.btnCerrarSesion.IconZoom = 60D;
            this.btnCerrarSesion.IsTab = false;
            this.btnCerrarSesion.Location = new System.Drawing.Point(8, 76);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Normalcolor = System.Drawing.Color.LightGray;
            this.btnCerrarSesion.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnCerrarSesion.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.selected = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(192, 40);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesiòn";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarSesion.Textcolor = System.Drawing.Color.Black;
            this.btnCerrarSesion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnCerrarSesion, "Cerrar Sesiòn");
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtRoluser);
            this.panel1.Controls.Add(this.txtNombreuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 119);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Contro_unity.Properties.Resources.icons8_user_avatar_50;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtRoluser
            // 
            this.txtRoluser.AutoSize = true;
            this.txtRoluser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoluser.Location = new System.Drawing.Point(68, 12);
            this.txtRoluser.Name = "txtRoluser";
            this.txtRoluser.Size = new System.Drawing.Size(86, 18);
            this.txtRoluser.TabIndex = 9;
            this.txtRoluser.Text = "Developer";
            // 
            // txtNombreuser
            // 
            this.txtNombreuser.AutoSize = true;
            this.txtNombreuser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreuser.Location = new System.Drawing.Point(65, 39);
            this.txtNombreuser.Name = "txtNombreuser";
            this.txtNombreuser.Size = new System.Drawing.Size(110, 18);
            this.txtNombreuser.TabIndex = 10;
            this.txtNombreuser.Text = "Stiwar Asprilla";
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.LightGray;
            this.menuVertical.Controls.Add(this.btnConfiguraciones);
            this.menuVertical.Controls.Add(this.btnUsuarios);
            this.menuVertical.Controls.Add(this.btnReservas);
            this.menuVertical.Controls.Add(this.btnReporte);
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
            this.btnReportes.Location = new System.Drawing.Point(8, 274);
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
            this.PanelContenedor.Controls.Add(this.panel2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 41);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1024, 630);
            this.PanelContenedor.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 52);
            this.panel2.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.Location = new System.Drawing.Point(767, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "FECHA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHora.Location = new System.Drawing.Point(880, 3);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 24);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "HORA";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label txtRoluser;
        private System.Windows.Forms.Label txtNombreuser;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnReporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}