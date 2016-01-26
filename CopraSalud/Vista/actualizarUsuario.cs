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
    public partial class actualizarUsuario : Form
    {
        public actualizarUsuario()
        {
            InitializeComponent();
        }
        public int Cotizante;
        public int idUsuario;

        ClUsuario objUsuario = new ClUsuario();

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Esta seguro de actualizar esta informacion", "Question?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                if (txtApellido.Text != "" || txtNombre.Text != "")
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
                    MessageBox.Show("La fecha es: " + fecha);
                    if (objUsuario.updateUsuario(nombre, apellido, fecha, idUsuario))
                    {
                        MessageBox.Show("Se actualizo la informacion correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
