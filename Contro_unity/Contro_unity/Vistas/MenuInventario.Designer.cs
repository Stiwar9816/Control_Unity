﻿namespace Contro_unity
{
    partial class MenuInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCod_Serie = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.control_unityDataSet = new Contro_unity.control_unityDataSet();
            this.implementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.implementsTableAdapter = new Contro_unity.control_unityDataSetTableAdapters.implementsTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.implementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "IMPLEMENTOS REGISTRADOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(1000, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.txtStock);
            this.gbEditInventario.Controls.Add(this.txtFecha);
            this.gbEditInventario.Controls.Add(this.label2);
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
            this.gbEditInventario.Location = new System.Drawing.Point(651, 66);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(361, 334);
            this.gbEditInventario.TabIndex = 16;
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
            // txtFecha
            // 
            this.txtFecha.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFecha.CustomFormat = "dd/MM/yyyy";
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(150, 194);
            this.txtFecha.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.txtFecha.MinDate = new System.DateTime(2019, 1, 22, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 23);
            this.txtFecha.TabIndex = 21;
            this.txtFecha.Value = new System.DateTime(2019, 1, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha:";
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
            this.txtDescripcion.Location = new System.Drawing.Point(150, 222);
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
            this.LblDescripcion.Location = new System.Drawing.Point(21, 266);
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
            this.btnConfirmar.Location = new System.Drawing.Point(771, 407);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmar.selected = false;
            this.btnConfirmar.Size = new System.Drawing.Size(147, 48);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmar, "Confirmar");
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.BorderRadius = 3;
            this.btnAgregar.ButtonText = "AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::Contro_unity.Properties.Resources.icons8_plus_50;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 55D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(16, 467);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(128, 47);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnEditar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.BorderRadius = 3;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = global::Contro_unity.Properties.Resources.icons8_edit_50;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 55D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(166, 467);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEditar.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(128, 47);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.BorderRadius = 3;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::Contro_unity.Properties.Resources.icons8_trash_can_50;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 55D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(321, 467);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(128, 47);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 37;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.implementsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 401);
            this.dataGridView1.TabIndex = 21;
            // 
            // control_unityDataSet
            // 
            this.control_unityDataSet.DataSetName = "control_unityDataSet";
            this.control_unityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // implementsBindingSource
            // 
            this.implementsBindingSource.DataMember = "implements";
            this.implementsBindingSource.DataSource = this.control_unityDataSet;
            // 
            // implementsTableAdapter
            // 
            this.implementsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_serie";
            this.dataGridViewTextBoxColumn2.HeaderText = "CÒDIGO SERIE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 104;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom_implements";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datetime_register_implements";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA DE REGISTRO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 132;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stock_implements";
            this.dataGridViewTextBoxColumn5.HeaderText = "STOCK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "brand";
            this.dataGridViewTextBoxColumn6.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 77;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description_implements";
            this.dataGridViewTextBoxColumn7.HeaderText = "DESCRIPCIÒN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 111;
            // 
            // MenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbEditInventario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInventario";
            this.Load += new System.EventHandler(this.MenuInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.implementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbEditInventario;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;

        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCod_Serie;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idimplementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomimplementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeregisterimplementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockimplementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionimplementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker txtFecha;
        public System.Windows.Forms.NumericUpDown txtStock;
        private control_unityDataSet control_unityDataSet;
        private System.Windows.Forms.BindingSource implementsBindingSource;
        private control_unityDataSetTableAdapters.implementsTableAdapter implementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}