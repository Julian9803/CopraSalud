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
    public partial class historialCitas : Form
    {
        public historialCitas()
        {
            InitializeComponent();
        }

        List<ClCita> listaCitas = new List<ClCita>();
        ClCita objCita = new ClCita();
        public int idUsuario;
        private void dgvCitas_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Cita WHERE usuario = " + idUsuario;
            listaCitas = objCita.historialUsuario(sql);
            dgtHistorial.DataSource = listaCitas;
        }
    }
}
