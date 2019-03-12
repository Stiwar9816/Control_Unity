namespace Contro_unity
{
    partial class MenuSalones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnConfirmarEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNom_Salon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.btnConfirmarAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsalonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomsalonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsalonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control_unityDataSet = new Contro_unity.control_unityDataSet();
            this.idsalonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomsalonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsalonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonsTableAdapter = new Contro_unity.control_unityDataSetTableAdapters.salonsTableAdapter();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.txtDescripcion);
            this.gbEditInventario.Controls.Add(this.txtID);
            this.gbEditInventario.Controls.Add(this.btnConfirmarEditar);
            this.gbEditInventario.Controls.Add(this.txtNom_Salon);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.btnConfirmarAgregar);
            this.gbEditInventario.Controls.Add(this.LblDescripcion);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(651, 86);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(361, 263);
            this.gbEditInventario.TabIndex = 7;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL SALON";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtID.LineThickness = 2;
            this.txtID.Location = new System.Drawing.Point(171, 17);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 30);
            this.txtID.TabIndex = 26;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.Visible = false;
            // 
            // btnConfirmarEditar
            // 
            this.btnConfirmarEditar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarEditar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarEditar.BorderRadius = 3;
            this.btnConfirmarEditar.ButtonText = "Confirmar";
            this.btnConfirmarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEditar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirmarEditar.Iconimage = global::Contro_unity.Properties.Resources.icons8_checked_50;
            this.btnConfirmarEditar.Iconimage_right = null;
            this.btnConfirmarEditar.Iconimage_right_Selected = null;
            this.btnConfirmarEditar.Iconimage_Selected = null;
            this.btnConfirmarEditar.IconMarginLeft = 0;
            this.btnConfirmarEditar.IconMarginRight = 0;
            this.btnConfirmarEditar.IconRightVisible = true;
            this.btnConfirmarEditar.IconRightZoom = 0D;
            this.btnConfirmarEditar.IconVisible = true;
            this.btnConfirmarEditar.IconZoom = 55D;
            this.btnConfirmarEditar.IsTab = false;
            this.btnConfirmarEditar.Location = new System.Drawing.Point(113, 202);
            this.btnConfirmarEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarEditar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmarEditar.selected = false;
            this.btnConfirmarEditar.Size = new System.Drawing.Size(153, 53);
            this.btnConfirmarEditar.TabIndex = 25;
            this.btnConfirmarEditar.Text = "Confirmar";
            this.btnConfirmarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarEditar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmarEditar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmarEditar, "Confirmar");
            this.btnConfirmarEditar.Visible = false;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
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
            // btnConfirmarAgregar
            // 
            this.btnConfirmarAgregar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarAgregar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarAgregar.BorderRadius = 3;
            this.btnConfirmarAgregar.ButtonText = "Confirmar";
            this.btnConfirmarAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarAgregar.DisabledColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirmarAgregar.Iconimage = global::Contro_unity.Properties.Resources.icons8_checked_50;
            this.btnConfirmarAgregar.Iconimage_right = null;
            this.btnConfirmarAgregar.Iconimage_right_Selected = null;
            this.btnConfirmarAgregar.Iconimage_Selected = null;
            this.btnConfirmarAgregar.IconMarginLeft = 0;
            this.btnConfirmarAgregar.IconMarginRight = 0;
            this.btnConfirmarAgregar.IconRightVisible = true;
            this.btnConfirmarAgregar.IconRightZoom = 0D;
            this.btnConfirmarAgregar.IconVisible = true;
            this.btnConfirmarAgregar.IconZoom = 55D;
            this.btnConfirmarAgregar.IsTab = false;
            this.btnConfirmarAgregar.Location = new System.Drawing.Point(113, 202);
            this.btnConfirmarAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmarAgregar.Name = "btnConfirmarAgregar";
            this.btnConfirmarAgregar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarAgregar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmarAgregar.selected = false;
            this.btnConfirmarAgregar.Size = new System.Drawing.Size(153, 53);
            this.btnConfirmarAgregar.TabIndex = 19;
            this.btnConfirmarAgregar.Text = "Confirmar";
            this.btnConfirmarAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmarAgregar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmarAgregar, "Confirmar");
            this.btnConfirmarAgregar.Visible = false;
            this.btnConfirmarAgregar.Click += new System.EventHandler(this.btnConfirmarAgregar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(1000, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar Ventana");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALONES REGISTRADOS";
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
            this.btnEliminar.Location = new System.Drawing.Point(317, 494);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(128, 47);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(165, 494);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEditar.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(128, 47);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(13, 494);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(128, 47);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contro_unity.Properties.Resources.icons8_find_user_male_50;
            this.pictureBox1.Location = new System.Drawing.Point(298, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Buscar");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeight = 37;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsalonDataGridViewTextBoxColumn1,
            this.nomsalonDataGridViewTextBoxColumn1,
            this.descriptionsalonDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.salonsBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(9, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 401);
            this.dataGridView1.TabIndex = 24;
            // 
            // idsalonDataGridViewTextBoxColumn1
            // 
            this.idsalonDataGridViewTextBoxColumn1.DataPropertyName = "id_salon";
            this.idsalonDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idsalonDataGridViewTextBoxColumn1.Name = "idsalonDataGridViewTextBoxColumn1";
            this.idsalonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idsalonDataGridViewTextBoxColumn1.Visible = false;
            this.idsalonDataGridViewTextBoxColumn1.Width = 45;
            // 
            // nomsalonDataGridViewTextBoxColumn1
            // 
            this.nomsalonDataGridViewTextBoxColumn1.DataPropertyName = "nom_salon";
            this.nomsalonDataGridViewTextBoxColumn1.HeaderText = "SALÓN";
            this.nomsalonDataGridViewTextBoxColumn1.Name = "nomsalonDataGridViewTextBoxColumn1";
            this.nomsalonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomsalonDataGridViewTextBoxColumn1.Width = 71;
            // 
            // descriptionsalonDataGridViewTextBoxColumn1
            // 
            this.descriptionsalonDataGridViewTextBoxColumn1.DataPropertyName = "description_salon";
            this.descriptionsalonDataGridViewTextBoxColumn1.HeaderText = "DESCRIPCIÓN";
            this.descriptionsalonDataGridViewTextBoxColumn1.Name = "descriptionsalonDataGridViewTextBoxColumn1";
            this.descriptionsalonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionsalonDataGridViewTextBoxColumn1.Width = 111;
            // 
            // salonsBindingSource
            // 
            this.salonsBindingSource.DataMember = "salons";
            this.salonsBindingSource.DataSource = this.control_unityDataSet;
            // 
            // control_unityDataSet
            // 
            this.control_unityDataSet.DataSetName = "control_unityDataSet";
            this.control_unityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idsalonDataGridViewTextBoxColumn
            // 
            this.idsalonDataGridViewTextBoxColumn.DataPropertyName = "id_salon";
            this.idsalonDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idsalonDataGridViewTextBoxColumn.Name = "idsalonDataGridViewTextBoxColumn";
            this.idsalonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsalonDataGridViewTextBoxColumn.Width = 43;
            // 
            // nomsalonDataGridViewTextBoxColumn
            // 
            this.nomsalonDataGridViewTextBoxColumn.DataPropertyName = "nom_salon";
            this.nomsalonDataGridViewTextBoxColumn.HeaderText = "SALÒN";
            this.nomsalonDataGridViewTextBoxColumn.Name = "nomsalonDataGridViewTextBoxColumn";
            this.nomsalonDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomsalonDataGridViewTextBoxColumn.Width = 71;
            // 
            // descriptionsalonDataGridViewTextBoxColumn
            // 
            this.descriptionsalonDataGridViewTextBoxColumn.DataPropertyName = "description_salon";
            this.descriptionsalonDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÒN";
            this.descriptionsalonDataGridViewTextBoxColumn.Name = "descriptionsalonDataGridViewTextBoxColumn";
            this.descriptionsalonDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionsalonDataGridViewTextBoxColumn.Width = 111;
            // 
            // salonsTableAdapter
            // 
            this.salonsTableAdapter.ClearBeforeFill = true;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.Location = new System.Drawing.Point(733, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "FECHA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel2.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Buscar Salon:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.HintText = "";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtBuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtBuscar.LineThickness = 2;
            this.txtBuscar.Location = new System.Drawing.Point(130, 43);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 30);
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.OnValueChanged += new System.EventHandler(this.txtBuscar_OnValueChanged_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(171, 76);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(182, 100);
            this.txtDescripcion.TabIndex = 43;
            // 
            // MenuSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbEditInventario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSalones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSalones";
            this.Load += new System.EventHandler(this.MenuSalones_Load);
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEditInventario;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmarAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNom_Salon;
        public System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idsalonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomsalonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsalonDataGridViewTextBoxColumn;
        private control_unityDataSet control_unityDataSet;
        private System.Windows.Forms.BindingSource salonsBindingSource;
        private control_unityDataSetTableAdapters.salonsTableAdapter salonsTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmarEditar;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsalonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomsalonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsalonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}