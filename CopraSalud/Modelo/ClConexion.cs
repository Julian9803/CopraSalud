using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CopraSalud.Modelo
{
    class ClConexion
    {
        SqlConnection C;
        SqlCommand cmd;
        SqlDataReader dr;
        int aux = 1;

        public SqlConnection mtdconectar()
        {
            if (aux == 1)
            {
                C = new SqlConnection("Data Source=JULIAN\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
                C.Open();
               
            }
            else
            {
                MessageBox.Show("No Conecto");
            }
            return C;


        }

        public void mtdDesconectar()
        {
            C.Close();
        }
    }
}
