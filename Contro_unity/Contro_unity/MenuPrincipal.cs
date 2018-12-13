using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Contro_unity
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            
            if (menuVertical.Width == 200)
            {
                menuVertical.Width = 56;
            }
            else
                menuVertical.Width = 200;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object frmHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuInventario());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSalones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuSalones());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuProfesores());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuUsuarios());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuConfig());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuReportes());
        }
    }
}
