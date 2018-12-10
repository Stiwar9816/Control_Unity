namespace Contro_unity
{
    partial class MenuUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtRol = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbCC_User = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCod_serie = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnAgregar.Location = new System.Drawing.Point(770, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 48);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "      CONFIRMAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.SystemColors.Menu;
            this.gbUser.Controls.Add(this.txtRol);
            this.gbUser.Controls.Add(this.txtEmail);
            this.gbUser.Controls.Add(this.lbCC_User);
            this.gbUser.Controls.Add(this.lblNombre);
            this.gbUser.Controls.Add(this.txtNombre);
            this.gbUser.Controls.Add(this.lblStock);
            this.gbUser.Controls.Add(this.txtCod_serie);
            this.gbUser.Controls.Add(this.lblMarca);
            this.gbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.Location = new System.Drawing.Point(642, 69);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(361, 162);
            this.gbUser.TabIndex = 25;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "DATOS DEL USUARIO";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.SystemColors.Window;
            this.txtRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRol.FormattingEnabled = true;
            this.txtRol.Items.AddRange(new object[] {
            "Recepcion",
            "Biblioteca"});
            this.txtRol.Location = new System.Drawing.Point(150, 126);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(200, 24);
            this.txtRol.TabIndex = 26;
            this.txtRol.Text = "Elige Un Rol";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(150, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 16);
            this.txtEmail.TabIndex = 11;
            // 
            // lbCC_User
            // 
            this.lbCC_User.AutoSize = true;
            this.lbCC_User.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCC_User.Location = new System.Drawing.Point(21, 29);
            this.lbCC_User.Name = "lbCC_User";
            this.lbCC_User.Size = new System.Drawing.Size(48, 18);
            this.lbCC_User.TabIndex = 0;
            this.lbCC_User.Text = "C.C : ";
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
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(150, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 16);
            this.txtNombre.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(21, 97);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 18);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Email: ";
            // 
            // txtCod_serie
            // 
            this.txtCod_serie.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod_serie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod_serie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_serie.Location = new System.Drawing.Point(150, 26);
            this.txtCod_serie.Name = "txtCod_serie";
            this.txtCod_serie.Size = new System.Drawing.Size(200, 16);
            this.txtCod_serie.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 129);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(39, 18);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Rol: ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1001, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(290, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 47);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "       ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(151, 476);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 47);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "       EDITAR";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar1.FlatAppearance.BorderSize = 0;
            this.btnAgregar1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar1.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar1.Image")));
            this.btnAgregar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar1.Location = new System.Drawing.Point(12, 476);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(133, 47);
            this.btnAgregar1.TabIndex = 22;
            this.btnAgregar1.Text = "       AGREGAR";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "USUARIOS REGISTRADOS";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 37;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cc_user,
            this.nom_user,
            this.email_user,
            this.datetime_user,
            this.rol_user});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 387);
            this.dataGridView1.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 43;
            // 
            // cc_user
            // 
            this.cc_user.HeaderText = "C.C.";
            this.cc_user.Name = "cc_user";
            this.cc_user.Width = 57;
            // 
            // nom_user
            // 
            this.nom_user.HeaderText = "Nombre ";
            this.nom_user.Name = "nom_user";
            this.nom_user.Width = 84;
            // 
            // email_user
            // 
            this.email_user.HeaderText = "Email";
            this.email_user.Name = "email_user";
            this.email_user.Width = 63;
            // 
            // datetime_user
            // 
            this.datetime_user.HeaderText = "Fecha Y Hora De Registro";
            this.datetime_user.Name = "datetime_user";
            this.datetime_user.Width = 121;
            // 
            // rol_user
            // 
            this.rol_user.HeaderText = "Rol";
            this.rol_user.Name = "rol_user";
            this.rol_user.Width = 48;
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUsuarios";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label lbCC_User;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCod_serie;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_user;
        private System.Windows.Forms.ComboBox txtRol;
        private System.Windows.Forms.TextBox txtEmail;
    }
}