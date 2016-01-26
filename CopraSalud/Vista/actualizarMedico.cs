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
        private void actualizarMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
