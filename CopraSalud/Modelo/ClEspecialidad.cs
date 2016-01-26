using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CopraSalud.Modelo;
using System.Windows.Forms;

namespace CopraSalud.Modelo
{
    class ClEspecialidad
    {
        ClConexion objcon = new ClConexion();
        ClCotizante objCotizante = new ClCotizante();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;

        private int idEspecialidad;
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int IdEspecialidad
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }
        }

        public void llenarCombo(ComboBox model,string sql)
        {
            c = objcon.mtdconectar();
            da = new SqlDataAdapter(sql, c);

            dt = new DataTable();
            da.Fill(dt);
            model.DataSource = dt;
            model.DisplayMember = "Tipo";
            model.ValueMember = "idEspecialidad";//
            

        }

        public bool registrarItem(string tipo)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "INSERT INTO Especialidad(Tipo) VALUES('" + tipo + "')";
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el item: " + ex.Message);
                return false;

            }
        }

        public String retornarNombre(int idEspecialidad)
        {
            try
            {
                c = objcon.mtdconectar();
                string sql = "SELECT * FROM Especialidad WHERE idEspecialidad = " + idEspecialidad;
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                string nombre = "";
                while (sd.Read())
                {
                    nombre = Convert.ToString(sd["Tipo"]);
                }
               
                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hallar la especialidad: " + ex.Message);
                return null;
            }
            
            
            
        }

    }
}
