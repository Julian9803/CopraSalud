﻿using System;
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
    public partial class frmCitaHistorial : Form
    {
        public frmCitaHistorial()
        {
            InitializeComponent();
        }
        public int idUsuario;

        private void frmCitaHistorial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dstCita.historialCita' Puede moverla o quitarla según sea necesario.
            this.historialCitaTableAdapter.Fill(this.dstCita.historialCita,idUsuario);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
