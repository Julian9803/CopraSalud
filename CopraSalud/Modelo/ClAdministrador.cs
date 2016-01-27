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
    class ClAdministrador
    {
        private int idAdministrador;
        private string usuario;
        private string password;

        ClConexion objcon = new ClConexion();
        ClCotizante objCotizante = new ClCotizante();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;

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

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }

        public int iniciarSesion(string sql)
        {
            try
            {
                int entrar = 0;
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                string usuario = "";
                while (sd.Read())
                {
                    entrar++;
                    
                }

                return entrar;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesion: " + ex.Message);
                return 4;
            }
        }

    }
}
