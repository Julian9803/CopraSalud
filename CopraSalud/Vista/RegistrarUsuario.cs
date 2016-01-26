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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
         public int Cotizante;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtApellido.Text == ""))
            {

                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
      
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string fecha = dtpFecha.Value.ToString("dd/mm/yyyy");

                MessageBox.Show("La fecha es: " + fecha+" Y el id es: "+Cotizante);
                string fecha2 = "02/05/2015";

                ClUsuario objUsuario = new ClUsuario();
                if (objUsuario.registrar(Cotizante, nombre, apellido, fecha2))
                {
                    MessageBox.Show("Se registro correctamente el nuevo beneficiario", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
