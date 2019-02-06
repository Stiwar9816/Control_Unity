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
    public partial class ReservasProfesores : Form
    {
        public ReservasProfesores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservasProfesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.salons' Puede moverla o quitarla según sea necesario.
            this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.teacher' Puede moverla o quitarla según sea necesario.
            this.teacherTableAdapter.Fill(this.control_unityDataSet.teacher);


        }


    }
}
