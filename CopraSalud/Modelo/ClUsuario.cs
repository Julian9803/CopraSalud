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
    class ClUsuario
    {
        ClConexion objcon = new ClConexion();
        ClCotizante objCotizante = new ClCotizante();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
       

        private String cotizante;

        public String Cotizante
        {
            get { return cotizante; }
            set { cotizante = value; }
        }
        
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public List<ClUsuario> obtenerTodo(String SQL)
        {
            List<ClUsuario> lista = new List<ClUsuario>();
            try
            {
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(SQL, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    lista.Add(ConvertirUsuario(sd));
                }
                return lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int Probar(String SQL)
        {
            List<ClUsuario> lista = new List<ClUsuario>();
            int i = 0;
            try
            {
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(SQL, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    i++;
                }
                return i;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClUsuario ConvertirUsuario(IDataReader reader)
        {
            ClUsuario objUsuario = new ClUsuario();
            objUsuario.idUsuario = Convert.ToInt32(reader["idUSuario"]);
            int cotizante = Convert.ToInt32(reader["Cotizante"]);
            objUsuario.cotizante = objCotizante.retornarNombre(cotizante);
            objUsuario.nombre = Convert.ToString(reader["Nombre"]);
            objUsuario.apellido = Convert.ToString(reader["Apellido"]);
            objUsuario.fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);

            return objUsuario;
        }

        public bool registrar(int Cotizante,String Nombre, String Apellido, string FechaNacimiento)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "INSERT INTO Usuario(Cotizante,Nombre,Apellido,FechaNacimiento) VALUES("+Cotizante+",'" + Nombre + "','" + Apellido + "','"+FechaNacimiento+"')";
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
                return false;
            }
        }

        public void listarProyectos(DataGridView dg, string sql)
        {
            try
            {
                c = objcon.mtdconectar();
                da = new SqlDataAdapter(sql, c);
                dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la tabla: " + ex.Message);
            }
        }
        public String retornarNombre(int idUsuario)
        {
            c = objcon.mtdconectar();
            string sql = "SELECT * FROM Usuario WHERE idUsuario = " + idUsuario;
            cmdIns = new SqlCommand(sql, c);
            sd = cmdIns.ExecuteReader();
            string nombre = "";
            while (sd.Read())
            {
                nombre = Convert.ToString(sd["Nombre"]);
            }
            return nombre;
        }

        public bool updateUsuario(string nombre, string apellido, string fechaNacimiento, int idUsuario)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "UPDATE Usuario SET Nombre = '"+nombre+"',Apellido = '"+apellido+"',FechaNacimiento = '"+fechaNacimiento+"' WHERE idUsuario = "+idUsuario;
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
