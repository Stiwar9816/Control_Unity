namespace Contro_unity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarInventario = new System.Windows.Forms.Button();
            this.btnEditInventario = new System.Windows.Forms.Button();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_implements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_implements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime_register_implements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_implements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
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
            this.btnEliminarInventario.Location = new System.Drawing.Point(289, 324);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(133, 47);
            this.btnEliminarInventario.TabIndex = 16;
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
            this.btnEditInventario.Location = new System.Drawing.Point(150, 324);
            this.btnEditInventario.Name = "btnEditInventario";
            this.btnEditInventario.Size = new System.Drawing.Size(133, 47);
            this.btnEditInventario.TabIndex = 15;
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
            this.btnAgregarInventario.Location = new System.Drawing.Point(11, 324);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(133, 47);
            this.btnAgregarInventario.TabIndex = 14;
            this.btnAgregarInventario.Text = "       AGREGAR";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista De Implementos Registrados";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeight = 37;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cod_serie,
            this.nom_implements,
            this.stock_implements,
            this.brand,
            this.datetime_register_implements,
            this.description_implements});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(11, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 252);
            this.dataGridView1.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // cod_serie
            // 
            this.cod_serie.HeaderText = "Codigo Serie";
            this.cod_serie.Name = "cod_serie";
            // 
            // nom_implements
            // 
            this.nom_implements.HeaderText = "Nombre";
            this.nom_implements.Name = "nom_implements";
            // 
            // stock_implements
            // 
            this.stock_implements.HeaderText = "Stock";
            this.stock_implements.Name = "stock_implements";
            // 
            // brand
            // 
            this.brand.HeaderText = "Marca";
            this.brand.Name = "brand";
            // 
            // datetime_register_implements
            // 
            this.datetime_register_implements.HeaderText = "Fecha Y Hora de Registro";
            this.datetime_register_implements.Name = "datetime_register_implements";
            // 
            // description_implements
            // 
            this.description_implements.HeaderText = "Descripción";
            this.description_implements.Name = "description_implements";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(739, 37);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 23);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(772, 379);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarInventario);
            this.Controls.Add(this.btnEditInventario);
            this.Controls.Add(this.btnAgregarInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuInventario";
            this.Text = "MenuInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarInventario;
        private System.Windows.Forms.Button btnEditInventario;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_implements;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_implements;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime_register_implements;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_implements;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}