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
    public partial class verMedicos : Form
    {
        public verMedicos()
        {
            InitializeComponent();
        }
        ClEspecialidad objEspecialidad = new ClEspecialidad();
        ClMedico objMedico = new ClMedico();
        List<ClMedico> listaMedico = new List<ClMedico>();
        historialMedico historialMedico = new historialMedico();

        int idMedico;
        private void verMedicos_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarTabla();
            btnActualizar.Enabled = false;
            btnHistorial.Enabled = false;
        }

        public void cargarCombo()
        {
            string sql = "SELECT * FROM Especialidad";
            objEspecialidad.llenarCombo(cmbEspecialidad, sql);
        }

        public void cargarTabla()
        {
            string sql = "SELECT * FROM Medico";
            listaMedico = objMedico.listarMedico(sql);
            dgvMedicos.DataSource = listaMedico;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                int especialidad = Int16.Parse(cmbEspecialidad.SelectedValue.ToString());
                string nombre = txtBuscar.Text;
                string sql = "SELECT * FROM Medico WHERE Nombre lIKE '%"+nombre+"%' AND Especialidad = "+especialidad;
                listaMedico = objMedico.listarMedico(sql);
                dgvMedicos.DataSource = listaMedico;
            }
            else
            {
                cargarTabla();
            }
        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idMedico = (int)dgvMedicos.CurrentRow.Cells["idMedico"].Value;
            btnActualizar.Enabled = true;
            btnHistorial.Enabled = true;
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            historialMedico.medico = idMedico;
            historialMedico.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

    }
}
