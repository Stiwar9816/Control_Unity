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
    public partial class MenuInventario : Form
    {
        Conexion con = new Conexion();

        public MenuInventario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.implements' Puede moverla o quitarla según sea necesario.
            this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);
            txtCod_Serie.Enabled = false;
            txtNombre.Enabled = false;
            txtStock.Enabled = false;
            txtMarca.Enabled = false;
            txtDescripcion.Enabled = false;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCod_Serie.Enabled = true;
            txtNombre.Enabled = true;
            txtStock.Enabled = true;
            txtMarca.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Enabled == true)
            {
                if (btnAgregar.Enabled == true)
                {
                   // MessageBox.Show(con.insertar_inventario(txtCod_Serie.Text,txtNombre.Text,Convert.ToInt32( txtStock.Value),txtMarca.Text,txtDescripcion.Text));
                    this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);
                    txtCod_Serie.Text = "";
                    txtNombre.Text = "";
                    txtStock.Value = 0;
                    txtMarca.Text = "";
                    txtDescripcion.Text = "";
                    //txtFecha.Text = "";
                }
                else
                {
                    MessageBox.Show("Los Campo de textos no estan habilitados, Por favor presione agregar e intente de neuvo");
                }
            }
        }
    }
}
