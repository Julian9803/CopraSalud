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
    public partial class frmCertificado : Form
    {
        public frmCertificado()
        {
            InitializeComponent();
        }
        public int usuario;
        private void frmCertificado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dstCertificado.certificado1' Puede moverla o quitarla según sea necesario.
            this.certificado1TableAdapter.Fill(this.dstCertificado.certificado1,usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
