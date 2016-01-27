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
    public partial class registrarCotizante : Form
    {
        public registrarCotizante()
        {
            InitializeComponent();
        }
        ClCotizante objCotizante = new ClCotizante();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtEmpresa.Text == "" || txtNombre.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "" || txtTEmpresa.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos", "Adevertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string apellido = txtApellido.Text;
                string empresa = txtEmpresa.Text;
                string nombre = txtNombre.Text;
                string password = txtPassword.Text;
                int telefono = Int32.Parse(txtTelefono.Text);
                string TelefonoEmpresa = txtTEmpresa.Text;
                string usuario = txtUser.Text;
                string FechaNacimiento = dtpFecha.Value.ToString("dd/MM/yyyy");

                if (objCotizante.registrarCotizante(nombre, apellido, telefono, FechaNacimiento, empresa, TelefonoEmpresa, usuario, password))
                {
                    MessageBox.Show("Se registro el nuevo cotizante correctamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
