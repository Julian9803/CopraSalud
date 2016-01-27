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
    public partial class historialUsuario : Form
    {
        public historialUsuario()
        {
            InitializeComponent();
        }
        ClUsuario objUsuario = new ClUsuario();
        List<ClUsuario> lista = new List<ClUsuario>();
        citasUsuario citasUsuario;
        public int cotizante;
        private void historialUsuario_Load(object sender, EventArgs e)
        {
            llenarTabla();
            btnUsuario.Enabled = false;
        }

        public void llenarTabla()
        {
            string sql = "SELECT * FROM Usuario WHERE Cotizante = " + cotizante;
            lista = objUsuario.obtenerTodo(sql);
            dgvUsuarios.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citasUsuario = new citasUsuario();
            citasUsuario.usuario = cotizante;
            citasUsuario.Show();
            Hide();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cotizante = (int)dgvUsuarios.CurrentRow.Cells["idUsuario"].Value;
            btnUsuario.Enabled = true;
        }

    }
}
