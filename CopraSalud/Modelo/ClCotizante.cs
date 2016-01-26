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
    class ClCotizante
    {
        


        private int idCotizante;
        private string nombre;
        private string apellido;
        private int telefono;
        private string fechaNacimiento;
        private string empresa;
        private string telefonoEmpresa;
        private string usuario;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public string TelefonoEmpresa
        {
            get { return telefonoEmpresa; }
            set { telefonoEmpresa = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }


        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
       


        public int Telefono
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
       
        public int IdCotizante
        {
            get { return idCotizante; }
            set { idCotizante = value; }
        }
       

        ClConexion objcon = new ClConexion();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;

        public String retornarNombre(int idCotizante)
        {
            c = objcon.mtdconectar();
            string sql = "SELECT * FROM Cotizante WHERE idCotizante = "+idCotizante;
            cmdIns = new SqlCommand(sql, c);
            sd = cmdIns.ExecuteReader();
            string nombre = "";
            while (sd.Read())
            {
                nombre = Convert.ToString(sd["Nombre"]);
            }
            return nombre;
        }

        public bool updateUsuario(int idCotizante, string nombre, string apellido, int telefono, string fechaNacimiento, string empresa, string telefonoEmpresa)
        {

            try
            {
                c = objcon.mtdconectar();
                string insertar = "UPDATE Cotizante SET Nombre = '" + nombre + "',Apellido = '" + apellido + "', Telefono = " + telefono + " ,FechaNacimiento = '" + fechaNacimiento + "' ,Empresa = '" + empresa + "' ,TelefonoEmpresa = '" + telefonoEmpresa + "' WHERE idCotizante = " + idCotizante;
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
                throw;
            }
        }

    }
}
