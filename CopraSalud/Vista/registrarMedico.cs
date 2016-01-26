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
    public partial class registrarMedico : Form
    {
        public registrarMedico()
        {
            InitializeComponent();
        }
        ClEspecialidad objEspecialidad = new ClEspecialidad();
        ClMedico objMedico = new ClMedico();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarMedico_Load(object sender, EventArgs e)
        {
            cargarCombo();
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
                MessageBox.Show("Por favor complete todos los campos", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string apellido = txtApellido.Text;
                string nombre = txtNombre.Text;
                long telefono = long.Parse(txtTelefono.Text);
                int especialidad = Int16.Parse(cmbEspecialidad.SelectedValue.ToString());

                if(objMedico.registrarMedico(especialidad,nombre,apellido,telefono)){
                    MessageBox.Show("Se registro el medico correctamente","Enhorabuena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
