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
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.control_unityDataSet.usuarios);
            txtCC.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtRol.Enabled = false;
            txtPass.Enabled = false;
        }
        private void Ingresar_Usuario()
        {
            var fecha = System.DateTime.Now.ToShortDateString();
            var hora = System.DateTime.Now.ToShortTimeString();
            var Usuario = new Clases.user();
            if (btnAgregar.Enabled == true)
            {
                Usuario = new Clases.user(Convert.ToInt32(txtCC.Text),txtNombre.Text,txtPass.Text,txtEmail.Text,fecha+" "+hora,txtRol.Text);
                int ultimo_id = Usuario.Registrar();
                this.usuariosTableAdapter.Fill(this.control_unityDataSet.usuarios);
                txtCC.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtRol.Text = "";
                txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor seleccione una opcion e intente de nuevo");
            }
        }

        private void Editar_Usuario()
        {
            var fecha = System.DateTime.Now.ToShortDateString();
            var hora = System.DateTime.Now.ToShortTimeString();
            var User = new Clases.user();
            User.Editar(Convert.ToInt32( txtCC.Text), txtNombre.Text,txtPass.Text,txtEmail.Text,fecha+" "+hora,txtRol.Text);
            this.usuariosTableAdapter.Fill(this.control_unityDataSet.usuarios);
            MessageBox.Show("Actualizado Correctamente");
            txtCC.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtRol.Text = "";
            txtPass.Text = "";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtPass.Enabled = true;
            txtEmail.Enabled = true;
            txtRol.Enabled = true;
            btnConfirmarAgregar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtPass.Enabled = true;
            txtRol.Enabled = true;
            btnConfirmarEditar.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtRol.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
                this.usuariosTableAdapter.Fill(this.control_unityDataSet.usuarios);
                MessageBox.Show("Elimando Correctamente");
                txtCC.Text = "";
                txtNombre.Text = "";
                txtPass.Text = "";
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
            Editar_Usuario();
            btnConfirmarEditar.Visible = false;
            txtCC.Enabled = false;
            txtNombre.Enabled = false;
            txtPass.Enabled = false;
            txtEmail.Enabled = false;
            txtRol.Enabled = false;
        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_Usuario();
            btnConfirmarAgregar.Visible = false;
            txtCC.Enabled = false;
            txtNombre.Enabled = false;
            txtPass.Enabled = false;
            txtEmail.Enabled = false;
            txtRol.Enabled = false;
        }
    }
}
