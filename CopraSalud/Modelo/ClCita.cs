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
    class ClCita
    {
        private int idCita;
        private int idMedico;
        private string medico;
        private string usuario;
        private string fecha;
        private string hora;
        private string estado;

        ClMedico objMedico = new ClMedico();
        ClUsuario objUsuario = new ClUsuario();
        
        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }
       



        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Medico
        {
            get { return medico; }
            set { medico = value; }
        }
        public int IdCita
        {
            get { return idCita; }
            set { idCita = value; }
        }
        

        ClConexion objcon = new ClConexion();
        SqlCommand cmdIns;
        SqlDataAdapter da;
        SqlConnection c;
        SqlDataReader sd;
        DataTable dt;


        public List<ClCita> retornarCitas(string sql, string fecha)
        {   
            List<ClCita> lista = new List<ClCita>();
            try
            {
                ClCita cita = new ClCita();
                List<int> idMedicos = new List<int>();
                string hora = "";
                idMedicos = idMedicosD(sql);
                
                foreach (var item in idMedicos)

                {
                    //lista.Add(ConvertirVerCita(sd,fecha));
                    //MessageBox.Show("estoy dentro del while: ");
                    int idMedico = item;
             
                    int citasR = validacionFecha(fecha, idMedico);
                    
                    if (citasR == 0)
                    {
    
                        hora = "8:00";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                        hora = "9:30";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                        hora = "12:30";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                    }
                    else if (citasR == 1)
                    {
                        hora = "9:30";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                        hora = "12:30";
                        lista.Add(ConvertirVerCita( fecha, hora, idMedico));
                    }
                    else if (citasR == 2)
                    {
                        hora = "9:30";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                        hora = "12:30";
                        lista.Add(ConvertirVerCita(fecha, hora, idMedico));
                    }
                }

                return lista;

           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo obtener citas", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                
            }
            
        }

        public List<int> idMedicosD(string sql)
        {
            try
            {
                List<int> idMedico = new List<int>();

                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    idMedico.Add(Convert.ToInt32(sd["idMedico"]));
                }
                return idMedico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hallar los id de medicos: " + ex.Message);
                throw;
            }
        }

        public ClCita ConvertirVerCita(string fecha,string hora,int idMedico)
        {
            try
            {
                ClCita cita = new ClCita();
                //MessageBox.Show("El id para buscar es: " + idMedico);
                string sql = "SELECT * FROM Medico WHERE idMedico = " + idMedico;
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();
                while (sd.Read())
                {
                    int aux = Convert.ToInt32(sd["idMedico"]);
                    //MessageBox.Show("El id es buscado: " + aux);
                    cita.idMedico = aux;
                    cita.Medico = Convert.ToString(sd["Nombre"]);
                }
                
                //cita.idMedico = Convert.ToInt32(sd["idMedico"]);

                //cita.medico = Convert.ToString(sd["Medico"]);
                cita.fecha = fecha;
                cita.Hora = hora;
                cita.estado = "En Proceso";
               // MessageBox.Show("Voy a retornar");
                return cita; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la fecha: " + ex.Message);
                throw;
            }
                
            
            

            //cita.fecha = devolverFecha(fecha,cita.idMedico);
            

            
        }

        public int validacionFecha(string fecha,int idMedico)
        {
            int aux = 0;

            try
            {
                string sql = "SELECT * FROM Cita WHERE Medico = " + idMedico + " AND Fecha = '" + fecha+"'";
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();

                while (sd.Read())
                {
                    MessageBox.Show("Estoy dentro del while de validar");
                    aux++;
                }

                return aux;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la fecha: " + ex.Message);
                throw;
            }


           
        }

        /*public IDataReader devolver()
        {
             try
            {
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand("SELECT * FROM Cita", c);
                sd = cmdIns.ExecuteReader();
                return sd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo obtener citas", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                
            }
        }*/

        public bool registrarCita(int medico,int usuario,string fecha,string hora,string estado)
        {
            try
            {
                c = objcon.mtdconectar();
                string insertar = "INSERT INTO Cita(Medico,Usuario,Fecha,Hora,Estado) VALUES(" + medico + "," + usuario + ",'" + fecha + "','" + hora + "','"+estado+"')";
                cmdIns = new SqlCommand(insertar, c);
                cmdIns.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message);
                return false;
                
            }
        }

        public List<ClCita> historialUsuario(string sql)
        {
            try
            {
                List<ClCita> lista = new List<ClCita>();
                c = objcon.mtdconectar();
                cmdIns = new SqlCommand(sql, c);
                sd = cmdIns.ExecuteReader();

                while (sd.Read())
                {
                    lista.Add(convertirHCita(sd));
                }


                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hallar el histroial: " + ex.Message);
                throw;
            }
        }

        public ClCita convertirHCita(IDataReader reader)
        {
            ClCita cita = new ClCita();

            int idMedico = Convert.ToInt32(reader["Medico"]);
            cita.medico = objMedico.retornarNombre(idMedico);
            int idUsuario = Convert.ToInt32(reader["Usuario"]);
            cita.usuario = objUsuario.retornarNombre(idUsuario);
            cita.fecha = Convert.ToString(reader["Fecha"]);
            cita.hora = Convert.ToString(reader["Hora"]);
            cita.estado = Convert.ToString(reader["Estado"]);

            return cita;
        }
        

    }
}
