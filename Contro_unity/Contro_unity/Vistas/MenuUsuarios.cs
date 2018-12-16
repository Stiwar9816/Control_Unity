using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtRol.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            var Usuario = new Clases.user();
            if (btnAgregar.Enabled == true)
            {
                Usuario = new Clases.user(Convert.ToInt32( txtCC.Text),txtNombre.Text,txtPass.Text,txtEmail.Text,Convert.ToString(txtFecha.Text),txtRol.Text,Convert.ToInt32( txtPrivilegio.Text));
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
    }
}
