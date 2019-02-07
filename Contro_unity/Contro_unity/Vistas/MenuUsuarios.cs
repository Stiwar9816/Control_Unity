using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contro_unity.Vistas;

namespace Contro_unity
{
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.control_unityDataSet.users);
            txtCC.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtRol.Enabled = false;
        }
        private void Ingresar_Usuario()
        {
            var Usuario = new Clases.user();
            if (btnAgregar.Enabled == true)
            {
                //Usuario = new Clases.user(Convert.ToInt32(txtCC.Text), txtNombre.Text, txtEmail.Text, txtRol.Text);
                int ultimo_id = Usuario.Registrar();
                this.usersTableAdapter.Fill(this.control_unityDataSet.users);
                txtCC.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtRol.Text = "";
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor seleccione una opcion e intente de nuevo");
            }
        }

        private void Editar_Usuario()
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtRol.Enabled = true;
            btnConfirmarAgregar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtRol.Enabled = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtRol.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var DeleteUser = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var user = new Clases.user();
                user.Eliminar(Convert.ToInt32(DeleteUser));
                MessageBox.Show("Elimando Correctamente");
                usersTableAdapter.Fill(this.control_unityDataSet.users);
                txtCC.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtRol.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_Usuario();
        }
    }
}
