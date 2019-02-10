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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.salons' Puede moverla o quitarla según sea necesario.
            this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.implements' Puede moverla o quitarla según sea necesario.
            this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);


            this.RPInventario.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
