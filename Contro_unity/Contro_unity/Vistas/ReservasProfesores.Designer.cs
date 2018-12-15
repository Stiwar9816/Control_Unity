namespace Contro_unity
{
    partial class ReservasProfesores
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtNombre = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control_unityDataSet = new Contro_unity.control_unityDataSet();
            this.teacherTableAdapter = new Contro_unity.control_unityDataSetTableAdapters.teacherTableAdapter();
            this.txtPrograma = new System.Windows.Forms.ComboBox();
            this.txtSalon = new System.Windows.Forms.ComboBox();
            this.salonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonsTableAdapter = new Contro_unity.control_unityDataSetTableAdapters.salonsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVAS PROFESORES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrograma);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PERSONALES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Programa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSalon);
            this.groupBox2.Controls.Add(this.bunifuDatepicker1);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA RESERVA";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.SystemColors.Menu;
            this.bunifuDatepicker1.BorderRadius = 3;
            this.bunifuDatepicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(212, 152);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(344, 26);
            this.bunifuDatepicker1.TabIndex = 19;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 12, 14, 11, 6, 2, 829);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(476, 59);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 20);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "PORTATIL\t";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(367, 59);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(91, 20);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "EXTENSION\t";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(222, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 20);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "MARCADOR\t";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(476, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 20);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "VGA\t";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(367, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 20);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "HDMI";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(222, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "VIDEO BEAM\t";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Salon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha y Hora De Reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Implementos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Contro_unity.Properties.Resources.icons8_delete_50;
            this.pictureBox1.Location = new System.Drawing.Point(1000, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cerrar");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Activecolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.BorderRadius = 3;
            this.btnConfirmar.ButtonText = "RESERVAR";
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
            this.btnConfirmar.Location = new System.Drawing.Point(436, 518);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Normalcolor = System.Drawing.SystemColors.Menu;
            this.btnConfirmar.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConfirmar.selected = false;
            this.btnConfirmar.Size = new System.Drawing.Size(147, 48);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "RESERVAR";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.Textcolor = System.Drawing.Color.Black;
            this.btnConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnConfirmar, "Confirmar");
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "nom_teacher", true));
            this.txtNombre.DataSource = this.teacherBindingSource;
            this.txtNombre.DisplayMember = "nom_teacher";
            this.txtNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNombre.FormattingEnabled = true;
            this.txtNombre.Location = new System.Drawing.Point(94, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 26);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.ValueMember = "nom_teacher";
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
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrograma.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teacherBindingSource, "program_teacher", true));
            this.txtPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPrograma.FormattingEnabled = true;
            this.txtPrograma.Items.AddRange(new object[] {
            "Ingenieria de sistemas",
            "Ingeniria Industrial",
            "Psicologia",
            "Trabajo Social",
            "Antropologia",
            "Ingles",
            "Especializaciones",
            "Otro"});
            this.txtPrograma.Location = new System.Drawing.Point(94, 75);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(254, 26);
            this.txtPrograma.TabIndex = 19;
            // 
            // txtSalon
            // 
            this.txtSalon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSalon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salonsBindingSource, "nom_salon", true));
            this.txtSalon.DataSource = this.salonsBindingSource;
            this.txtSalon.DisplayMember = "nom_salon";
            this.txtSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSalon.FormattingEnabled = true;
            this.txtSalon.Location = new System.Drawing.Point(212, 102);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(344, 26);
            this.txtSalon.TabIndex = 19;
            this.txtSalon.ValueMember = "nom_salon";
            // 
            // salonsBindingSource
            // 
            this.salonsBindingSource.DataMember = "salons";
            this.salonsBindingSource.DataSource = this.control_unityDataSet;
            // 
            // salonsTableAdapter
            // 
            this.salonsTableAdapter.ClearBeforeFill = true;
            // 
            // ReservasProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservasProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservasProfesores";
            this.Load += new System.EventHandler(this.ReservasProfesores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_unityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmar;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox txtNombre;
        private control_unityDataSet control_unityDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private control_unityDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.ComboBox txtPrograma;
        private System.Windows.Forms.ComboBox txtSalon;
        private System.Windows.Forms.BindingSource salonsBindingSource;
        private control_unityDataSetTableAdapters.salonsTableAdapter salonsTableAdapter;
    }
}