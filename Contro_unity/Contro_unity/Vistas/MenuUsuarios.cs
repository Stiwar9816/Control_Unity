using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrypto;

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
            txtPass.Enabled = false;
            txtPrivilegio.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtRol.Enabled = true;
            txtPass.Enabled = true;
            txtPrivilegio.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ICryptoService cryptoService = new PBKDF2();

            //Generar algoritmo de encriptacion

            string salt = cryptoService.GenerateSalt();
            string passEncriptada = cryptoService.Compute(txtPass.Text);
            

            var Usuario = new Clases.user();
            if (btnAgregar.Enabled == true)
            {
                Usuario = new Clases.user(Convert.ToInt32( txtCC.Text),txtNombre.Text,txtPass.Text,txtEmail.Text,Convert.ToDateTime(txtFecha.Text),txtRol.Text,Convert.ToInt32( txtPrivilegio.Text));
                int ultimo_id = Usuario.Registrar();
                this.usersTableAdapter.Fill(this.control_unityDataSet.users);
                txtCC.Text = "";
                txtNombre.Text = "";
                txtPass.Text = "";
                txtEmail.Text = "";
                txtRol.Text = "";
                txtPrivilegio.Text = "";
                txtFecha.Text = "";
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor seleccione una opcion e intente de nuevo");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = false;
            txtFecha.Enabled = false;
            txtNombre.Enabled = true;
            txtPass.Enabled = false;
            txtEmail.Enabled = true;
            txtPrivilegio.Enabled = false;
            txtRol.Enabled = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtFecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //txtRol.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //txtPrivilegio.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
