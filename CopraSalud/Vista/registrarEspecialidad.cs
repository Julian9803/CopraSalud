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
    public partial class registrarEspecialidad : Form
    {
        public registrarEspecialidad()
        {
            InitializeComponent();
        }
        ClEspecialidad objEspecialidad = new ClEspecialidad();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos", "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                string tipo = txtTipo.Text;
                if (objEspecialidad.registrarItem(tipo))
                {
                    MessageBox.Show("Se registro la especialidad correctamente", "Enhorabuena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
    }
}
