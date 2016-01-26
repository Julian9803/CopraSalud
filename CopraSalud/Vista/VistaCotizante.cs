using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopraSalud.Vista;

namespace CopraSalud
{
    public partial class VistaCotizante : Form
    {
        public VistaCotizante()
        {
            InitializeComponent();
        }
        RegistrarUsuario objRegistrar = new RegistrarUsuario();
        VerUsuarios objListar = new VerUsuarios();
        actualizarCotizante objActualizar = new actualizarCotizante();
        public int Cotizante = 1;

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objRegistrar.MdiParent = this;
            objRegistrar.Cotizante = Cotizante;
            objRegistrar.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objListar.MdiParent = this;
            objListar.Cotizante = Cotizante;
            objListar.Show();
            objRegistrar.Close();
        }

        private void actualizarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objActualizar.MdiParent = this;
            objActualizar.idCotizante = Cotizante;
            objActualizar.Show();
        }
    }
}
