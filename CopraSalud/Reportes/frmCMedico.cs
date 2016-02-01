using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopraSalud.Reportes
{
    public partial class frmCMedico : Form
    {
        public frmCMedico()
        {
            InitializeComponent();
        }
        public int medico;
        private void frmCMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsCertMedico.certMedico' Puede moverla o quitarla según sea necesario.
            this.certMedicoTableAdapter.Fill(this.dtsCertMedico.certMedico, medico);

            this.reportViewer1.RefreshReport();
        }
    }
}
