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
    public partial class citasUsuario : Form
    {
        public citasUsuario()
        {
            InitializeComponent();
        }
        ClCita objCita = new ClCita();
        List<ClCita> lista = new List<ClCita>();
        public int usuario;
        private void citasUsuario_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        public void cargarTabla()
        {
            string sql = "SELECT * FROM Cita WHERE Usuario = " + usuario;
            lista = objCita.historialUsuario(sql);
            dgvUsuario.DataSource = lista;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = mcFecha.SelectionEnd.ToShortDateString();
            string sql = "SELECT * FROM Cita WHERE Usuario = " + usuario + " AND Fecha = '" + fecha + "' ";
            lista = objCita.historialUsuario(sql);
            dgvUsuario.DataSource = lista;
        }
    }
}
