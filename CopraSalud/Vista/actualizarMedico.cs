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
    public partial class actualizarMedico : Form
    {
        public actualizarMedico()
        {
            InitializeComponent();
        }
        ClMedico objMedico = new ClMedico();
        ClEspecialidad objEspecialidad = new ClEspecialidad();
        public int Medico;
        private void actualizarMedico_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCombo();
        }

        public void cargarDatos()
        {
            ClMedico medico = new ClMedico();
            string sql = "SELECT * FROM Medico WHERE idMedico = "+Medico;
            medico = objMedico.datosMedico(sql);
            txtApellido.Text = medico.Apellido;
            txtNombre.Text = medico.Nombre;
            txtTelefono.Text = medico.Telefono.ToString();
        }
        public void cargarCombo()
        {
            string sql = "SELECT * FROM Especialidad";
            objEspecialidad.llenarCombo(cmbEspecialidad, sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("por favor complete todos los campos", "Error¡¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                long telefono = Int64.Parse(txtTelefono.Text);
                int especialidad = Int16.Parse(cmbEspecialidad.SelectedValue.ToString());
                if (objMedico.updateMedico(Medico, especialidad, nombre, apellido, telefono))
                {
                    MessageBox.Show("Se actualizo los datos del medico correctamente", "Informacion¡¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
