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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProfesores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEditInventario = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbCod_serie = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod_serie = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnEliminarInventario = new System.Windows.Forms.Button();
            this.btnEditInventario = new System.Windows.Forms.Button();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.program_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbEditInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(739, 201);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 48);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "      CONFIRMAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbEditInventario
            // 
            this.gbEditInventario.BackColor = System.Drawing.SystemColors.Menu;
            this.gbEditInventario.Controls.Add(this.comboBox1);
            this.gbEditInventario.Controls.Add(this.lbCod_serie);
            this.gbEditInventario.Controls.Add(this.lblNombre);
            this.gbEditInventario.Controls.Add(this.txtNombre);
            this.gbEditInventario.Controls.Add(this.txtCod_serie);
            this.gbEditInventario.Controls.Add(this.lblMarca);
            this.gbEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEditInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditInventario.Location = new System.Drawing.Point(584, 48);
            this.gbEditInventario.Name = "gbEditInventario";
            this.gbEditInventario.Size = new System.Drawing.Size(428, 147);
            this.gbEditInventario.TabIndex = 5;
            this.gbEditInventario.TabStop = false;
            this.gbEditInventario.Text = "DATOS DEL PROFESOR";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DisplayMember = "Eliga Un Programa";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ingeniria sistemas",
            "Ingeniria Industrial",
            "Psicologia",
            "Trabajo Social",
            "Ingles",
            "Otro"});
            this.comboBox1.Location = new System.Drawing.Point(182, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Tag = "8";
            this.comboBox1.Text = "Eliga Un Programa";
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
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(182, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 16);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCod_serie
            // 
            this.txtCod_serie.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod_serie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod_serie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_serie.Location = new System.Drawing.Point(182, 22);
            this.txtCod_serie.Name = "txtCod_serie";
            this.txtCod_serie.Size = new System.Drawing.Size(240, 16);
            this.txtCod_serie.TabIndex = 6;
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
            // btnEliminarInventario
            // 
            this.btnEliminarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarInventario.FlatAppearance.BorderSize = 0;
            this.btnEliminarInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarInventario.Image")));
            this.btnEliminarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarInventario.Location = new System.Drawing.Point(290, 455);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(133, 47);
            this.btnEliminarInventario.TabIndex = 4;
            this.btnEliminarInventario.Text = "       ELIMINAR";
            this.btnEliminarInventario.UseVisualStyleBackColor = true;
            // 
            // btnEditInventario
            // 
            this.btnEditInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInventario.FlatAppearance.BorderSize = 0;
            this.btnEditInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnEditInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEditInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInventario.Image")));
            this.btnEditInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInventario.Location = new System.Drawing.Point(151, 455);
            this.btnEditInventario.Name = "btnEditInventario";
            this.btnEditInventario.Size = new System.Drawing.Size(133, 47);
            this.btnEditInventario.TabIndex = 3;
            this.btnEditInventario.Text = "       EDITAR";
            this.btnEditInventario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarInventario.FlatAppearance.BorderSize = 0;
            this.btnAgregarInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInventario.Image")));
            this.btnAgregarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarInventario.Location = new System.Drawing.Point(12, 455);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(133, 47);
            this.btnAgregarInventario.TabIndex = 2;
            this.btnAgregarInventario.Text = "       AGREGAR";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Id_teacher,
            this.cc_teacher,
            this.nom_teacher,
            this.program_teacher});
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
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
            this.dataGridView1.Size = new System.Drawing.Size(554, 401);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id_teacher
            // 
            this.Id_teacher.HeaderText = "ID";
            this.Id_teacher.Name = "Id_teacher";
            this.Id_teacher.Width = 43;
            // 
            // cc_teacher
            // 
            this.cc_teacher.HeaderText = "C.C.";
            this.cc_teacher.Name = "cc_teacher";
            this.cc_teacher.Width = 57;
            // 
            // nom_teacher
            // 
            this.nom_teacher.HeaderText = "Nombre Completo";
            this.nom_teacher.Name = "nom_teacher";
            this.nom_teacher.Width = 133;
            // 
            // program_teacher
            // 
            this.program_teacher.HeaderText = "Programa";
            this.program_teacher.Name = "program_teacher";
            this.program_teacher.Width = 91;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1000, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbEditInventario);
            this.Controls.Add(this.btnEliminarInventario);
            this.Controls.Add(this.btnEditInventario);
            this.Controls.Add(this.btnAgregarInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProfesores";
            this.Text = "MenuProfesores";
            this.gbEditInventario.ResumeLayout(false);
            this.gbEditInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbEditInventario;
        private System.Windows.Forms.Label lbCod_serie;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod_serie;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnEliminarInventario;
        private System.Windows.Forms.Button btnEditInventario;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn program_teacher;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}