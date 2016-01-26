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
using CopraSalud.Vista;

namespace CopraSalud.Vista
{
    public partial class VerUsuarios : Form
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }
        public int Cotizante;
        ClUsuario objUsuario = new ClUsuario();
        Cita objCita = new Cita();
        historialCitas historial = new historialCitas();
        List<ClUsuario> lista = new List<ClUsuario>();
        actualizarUsuario actU = new actualizarUsuario();
        string hola;
        int usuario;
        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Usuario WHERE Cotizante = "+Cotizante;
            lista = objUsuario.obtenerTodo(sql);
            dtgUsuarios.DataSource = lista;
            btnSolicitar.Enabled = false;
            btnConsultar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCita.idUsuario = usuario;
            objCita.Show();
            this.Close();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = (int)dtgUsuarios.CurrentRow.Cells["idUsuario"].Value;
            btnConsultar.Enabled = true;
            btnSolicitar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            historial.idUsuario = usuario;
            historial.Show();
            this.Close();
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actU.idUsuario = usuario;
            actU.Show();
            
        }
    }
}
