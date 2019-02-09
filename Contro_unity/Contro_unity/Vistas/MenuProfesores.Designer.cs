namespace Contro_unity
{
    partial class MenuProfesores
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
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.btnConfirmarEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPrograma = new System.Windows.Forms.ComboBox();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnConfirmarAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control_unityDataSet = new Contro_unity.control_unityDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teacherTableAdapter = new Contro_unity.control_unityDataSetTableAdapters.teacherTableAdapter();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.btnConfirmarEditar);
            this.gbEditInventario.Controls.Add(this.txtPrograma);
            this.gbEditInventario.Controls.Add(this.txtFullName);
            this.gbEditInventario.Controls.Add(this.btnConfirmarAgregar);
            this.gbEditInventario.Controls.Add(this.txtCC);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.lblNombre);
            this.gbEditInventario.Controls.Add(this.lblMarca);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(584, 42);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(428, 221);
            this.gbEditInventario.TabIndex = 5;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL PROFESOR";
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
            this.btnConfirmarEditar.Location = new System.Drawing.Point(135, 145);
            this.btnConfirmarEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarEditar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmarEditar.selected = false;
            this.btnConfirmarEditar.Size = new System.Drawing.Size(175, 51);
            this.btnConfirmarEditar.TabIndex = 32;
            this.btnConfirmarEditar.Text = "Confirmar";
            this.btnConfirmarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarEditar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmarEditar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmarEditar, "Confirmar");
            this.btnConfirmarEditar.Visible = false;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPrograma.FormattingEnabled = true;
            this.txtPrograma.Items.AddRange(new object[] {
            "",
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
            this.btnConfirmarAgregar.Location = new System.Drawing.Point(135, 145);
            this.btnConfirmarAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmarAgregar.Name = "btnConfirmarAgregar";
            this.btnConfirmarAgregar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmarAgregar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmarAgregar.selected = false;
            this.btnConfirmarAgregar.Size = new System.Drawing.Size(175, 51);
            this.btnConfirmarAgregar.TabIndex = 29;
            this.btnConfirmarAgregar.Text = "Confirmar";
            this.btnConfirmarAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmarAgregar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmarAgregar, "Confirmar");
            this.btnConfirmarAgregar.Visible = false;
            this.btnConfirmarAgregar.Click += new System.EventHandler(this.btnConfirmarAgregar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROFESORES REGISTRADOS";
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.teacherBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
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
            this.dataGridView1.Size = new System.Drawing.Size(566, 401);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cc_teacher";
            this.dataGridViewTextBoxColumn2.HeaderText = "C.C";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom_teacher";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE COMPLETO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 136;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "program_teacher";
            this.dataGridViewTextBoxColumn4.HeaderText = "PROGRAMA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 101;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.control_unityDataSet;
            // 
            // control_unityDataSet
            // 
            this.control_unityDataSet.DataSetName = "control_unityDataSet";
            this.control_unityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 469);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(128, 47);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(322, 469);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.LightCoral;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(128, 47);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.btnCerrar.Location = new System.Drawing.Point(1000, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditar.Location = new System.Drawing.Point(164, 469);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnEditar.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(128, 47);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnEditar, "Agregar");
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // MenuProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbEditInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProfesores";
            this.Text = "MenuProfesores";
            this.Load += new System.EventHandler(this.MenuProfesores_Load);
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEditInventario;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmarAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomteacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programteacherDataGridViewTextBoxColumn;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFullName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCC;
        public System.Windows.Forms.ComboBox txtPrograma;
        public System.Windows.Forms.DataGridView dataGridView1;
        private control_unityDataSet control_unityDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private control_unityDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmarEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}