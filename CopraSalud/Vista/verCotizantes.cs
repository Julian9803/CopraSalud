using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopraSalud.Modelo;

namespace CopraSalud.Vista
{
    public partial class verCotizantes : Form
    {
        public verCotizantes()
        {
            InitializeComponent();
        }
        ClCotizante objCotizante = new ClCotizante();
        List<ClCotizante> listaCotizante = new List<ClCotizante>();
        historialUsuario historialUsuario;
        int Cotizante;
        private void verCotizantes_Load(object sender, EventArgs e)
        {
            cargarTabla();
            btnFamilia.Enabled = false;
        }

        public void cargarTabla(){
            string sql = "SELECT * FROM Cotizante";
            listaCotizante = objCotizante.retornarCotizantes(sql);
            dgvCotizantes.DataSource = listaCotizante;
        }

        private void dgvCotizantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCotizantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cotizante = (int)dgvCotizantes.CurrentRow.Cells["idCotizante"].Value;
            btnFamilia.Enabled = true;
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            historialUsuario = new historialUsuario();
            historialUsuario.cotizante = Cotizante;
            historialUsuario.Show();
            this.Hide();
        }

    }
}
