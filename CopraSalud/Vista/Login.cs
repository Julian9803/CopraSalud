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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ClAdministrador obAdmin = new ClAdministrador();
        vistaAdministrador vistaAdministrador = new vistaAdministrador();
        VistaCotizante vistaCotizante = new VistaCotizante();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" || txtUser.Text != "")
            {
                string usuario = txtUser.Text;
                string password = txtPassword.Text;
                int entrar;
                if (cbAdministrador.Checked)
                {
                    string sql = "SELECT * FROM Administrador WHERE Usuario = '" + usuario + "' AND Password = '" + password + "'";
                    entrar = obAdmin.iniciarSesion(sql);
                    if (entrar != 0)
                    {
                        
                        vistaAdministrador.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else if (cbCotizante.Checked)
                {
                    string sql = "SELECT * FROM Cotizante WHERE Usuario = '" + usuario + "' AND Password = '" + password + "'";
                    entrar = obAdmin.iniciarSesion(sql);
                    if (entrar != 0)
                    {
                        
                        vistaCotizante.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Cotizante no registrado en la base de datos", "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione algun tipo de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos", "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
            txtUser.Enabled = false;
            btnIngresar.Enabled = false;
        }

        private void cbCotizante_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtUser.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void cbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtUser.Enabled = true;
            btnIngresar.Enabled = true;
        }
    }
}
