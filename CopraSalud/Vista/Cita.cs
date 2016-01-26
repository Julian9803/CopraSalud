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
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
        }
        ClEspecialidad objEspecialidad = new ClEspecialidad();
        ClCita objCita = new ClCita();
        List<ClCita> listaCita = new List<ClCita>();
        public int idUsuario;
        private void Cita_Load(object sender, EventArgs e)
        {
          
            string sql = "SELECT * FROM Especialidad";
            objEspecialidad.llenarCombo(cmbEspecialidad, sql);
        }

        public void llenarCombo()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("Esta seguro de reservar esta cita", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int idMedico = (int)dgvMedico.CurrentRow.Cells["idMedico"].Value;
                    string fecha = (string)dgvMedico.CurrentRow.Cells["fecha"].Value;
                    string hora = (string)dgvMedico.CurrentRow.Cells["Hora"].Value;
                    string estado = "Activa";

                    if(objCita.registrarCita(idMedico,idUsuario,fecha,hora,estado)){
                        MessageBox.Show("Se registro la cita correctamente","Enhorabuena",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la fecha: " + ex.Message);
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idAux = cmbEspecialidad.SelectedValue.ToString();
            //string axs = idAux;
            int id;
            if (Int32.TryParse(idAux, out id))
            {
                MessageBox.Show("El id es: " + idAux);

            }
            else
            {
                MessageBox.Show("no me puede convertir :'(");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int  dia = Int32.Parse(DateTime.Now.ToString("dd"));
            int mes = Int32.Parse(DateTime.Now.ToString("MM"));
            int anio = Int32.Parse(DateTime.Now.ToString("yyyy"));
      
            mcFecha.MinDate = new DateTime(anio, mes, dia);
            mcFecha.MaxDate = new DateTime(anio, mes, dia + 7);*/
            /*ClCita objC = new ClCita();
            IDataReader reader = objC.devolver();*/
           /* if (!reader.Read())
            {
                MessageBox.Show("Entre");
            }
            else
            {
                MessageBox.Show("No entre");
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = mcFecha.SelectionEnd.ToShortDateString();
            int idEspecialidad = Int32.Parse(cmbEspecialidad.SelectedValue.ToString());
            string sql = "SELECT * FROM Medico WHERE Especialidad = " + idEspecialidad;
            listaCita = objCita.retornarCitas(sql, fecha);
            dgvMedico.DataSource = listaCita;


        }
    }
}
