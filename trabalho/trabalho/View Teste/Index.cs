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

namespace trab_diego
{
    public partial class Index : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       


        public Index()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

       

        private void MenuVert_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible=true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirNOPrincipal(object form)
        {
            if(this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(principal);
            this.Principal.Tag = principal;
            principal.Show();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new cadastro());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new inicio());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new comprar());
        }
    }
}
