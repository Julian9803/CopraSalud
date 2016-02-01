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
using CopraSalud.Reportes;

namespace CopraSalud.Vista
{
    public partial class historialCitas : Form
    {
        public historialCitas()
        {
            InitializeComponent();
        }

        List<ClCita> listaCitas = new List<ClCita>();
        frmCitaHistorial historial;
        ClCita objCita = new ClCita();
        public int idUsuario;
        private void dgvCitas_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Cita WHERE usuario = " + idUsuario;
            listaCitas = objCita.historialUsuario(sql);
            dgtHistorial.DataSource = listaCitas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historial = new frmCitaHistorial();
            historial.idUsuario = idUsuario;
            historial.ShowDialog();
        }
    }
}
