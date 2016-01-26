using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopraSalud.Vista;

namespace CopraSalud.Vista
{
    public partial class vistaAdministrador : Form
    {
        public vistaAdministrador()
        {
            InitializeComponent();
        }
        registrarEspecialidad registrarEspecialidad = new registrarEspecialidad();
        registrarMedico registrarMedico = new registrarMedico();
        verMedicos verMedicos = new verMedicos();
        private void registrarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarEspecialidad.MdiParent = this;
            registrarEspecialidad.Show();
        }

        private void registrarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarMedico.MdiParent = this;
            registrarMedico.Show();
        }

        private void verMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verMedicos.MdiParent = this;
            verMedicos.Show();
        }
    }
}
