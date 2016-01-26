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
    class ClMedico
    {
        ClConexion objcon = new ClConexion();
        ClEspecialidad objEspecialidad = new ClEspecialidad();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;

        

        private int idMedico;
        private string especialidad;
        private string nombre;
        private string apellido;
        private long telefono;

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        
        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }


        public String retornarNombre(int idMedico)
        {
            c = objcon.mtdconectar();
            string sql = "SELECT * FROM Medico WHERE idMedico = " + idMedico;
            cmdIns = new SqlCommand(sql, c);
            sd = cmdIns.ExecuteReader();
            string nombre = "";
            while (sd.Read())
            {
                nombre = Convert.ToString(sd["Nombre"]);
            }
            return nombre;
        }

        public bool registrarMedico(int especialidad, string Nombre, string Apellido, long telefono)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "INSERT INTO Medico(especialidad,Nombre,Apellido,Telefono) VALUES(" + especialidad + ",'" + Nombre + "','" + Apellido + "'," + telefono + ")";
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el medico: " + ex.Message);
                return false;
            }
        }

        public List<ClMedico> listarMedico(string sql)
        {
            try
            {
                List<ClMedico> lista = new List<ClMedico>();
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    lista.Add(ConvertirMedico(sd));
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los medicos: " + ex.Message);
                return null;
            }
        }
        public ClMedico ConvertirMedico(IDataReader reader)
        {
            try
            {
                ClMedico medico = new ClMedico();
                medico.idMedico = Convert.ToInt32(reader["idMedico"]);
                int idEspecialidad = Convert.ToInt32(reader["Especialidad"]);
                medico.especialidad = objEspecialidad.retornarNombre(idEspecialidad);
                medico.nombre = Convert.ToString(reader["Nombre"]);
                medico.apellido = Convert.ToString(reader["Apellido"]);
                medico.telefono = Convert.ToInt64(reader["Telefono"]);

                return medico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir el medico: " + ex.Message, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public ClMedico datosMedico(string sql)
        {
            try
            {
                ClMedico medico = new ClMedico();
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    medico.idMedico = Convert.ToInt32(sd["idMedico"]);
                    medico.nombre = Convert.ToString(sd["Nombre"]);
                    medico.apellido = Convert.ToString(sd["Apellido"]);
                    medico.telefono = Convert.ToInt64(sd["Telefono"]);
                }
                return medico;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al devolver actualizar medico: " + ex.Message);
                return null;
            }
        }

        public bool updateMedico(int idMedico , int especialidad, string nombre, string apellido, long telefono)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "UPDATE Medico SET Especialidad = " + especialidad + ", Nombre = '" + nombre + "',Apellido = '" + apellido + "',Telefono = " + telefono + " WHERE idMedico = " + idMedico;
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                throw;
            }
        }

    }
}
