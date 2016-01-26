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
    public partial class historialMedico : Form
    {
        public historialMedico()
        {
            InitializeComponent();
        }
        public int medico;
        List<ClCita> lista = new List<ClCita>();
        ClCita objCita = new ClCita();
        private void historialMedico_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Cita WHERE Medico = " + medico;
            lista = objCita.historialUsuario(sql);
            dgvHistorial.DataSource = lista;
        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = mcFecha.SelectionEnd.ToShortDateString();
            string sql = "SELECT * FROM Cita WHERE Medico = " + medico + " AND Fecha = '"+fecha+"' ";
            lista = objCita.historialUsuario(sql);
            dgvHistorial.DataSource = lista;
        }
    }
}
