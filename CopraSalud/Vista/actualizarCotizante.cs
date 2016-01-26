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
    public partial class actualizarCotizante : Form
    {
        public actualizarCotizante()
        {
            InitializeComponent();
        }

        ClCotizante objCotizante = new ClCotizante();
        public int idCotizante;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text == "" || txtEmpresa.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || txtTEmpresa.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos", "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                string apellido = txtApellido.Text;
                string empresa = txtEmpresa.Text;
                string nombre = txtNombre.Text;
                int telefono = Int32.Parse(txtTelefono.Text);
                string telefonoEmpresa = txtTEmpresa.Text;
                string fechaNacimiento = dtpFecha.Value.ToString("dd/MM/yyyy");

                if (objCotizante.updateUsuario(idCotizante, nombre, apellido, telefono, fechaNacimiento, empresa, telefonoEmpresa))
                {
                    MessageBox.Show("Se actualizo el cotizante correctamente", "Enhorabuena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
        }
    }
}
