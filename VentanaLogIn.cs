using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InciGest
{
    public partial class VentanaLogIn : Form
    {
        Conexion conexion = new Conexion();
        DataTable perfil = new DataTable();
        public VentanaLogIn()
        {
            InitializeComponent();
            MaximizeBox = false;
            passwordBox.PasswordChar = '•'; //No aparece la contraseña
        }

        internal static string usuario;
        internal static int tipoPerfil;


        private void botonLogIn_Click(object sender, EventArgs e)
        {
            if (conexion.iniciarSesion(userBox.Text, passwordBox.Text)) //Si el usuario y contraseña coinciden
            {
                this.Hide();
                usuario = userBox.Text;
                perfil = conexion.getDatosPerfil(userBox.Text);

                if (perfil.Rows[0]["perfil"].ToString() == "1") //Perfil de desarrollador
                {
                    tipoPerfil = 1;
                    VentanaPrincipal ventanaprincipal = new VentanaPrincipal();
                    ventanaprincipal.Show();
                }

                if (perfil.Rows[0]["perfil"].ToString() == "2") //Perfil de administrador
                {
                    tipoPerfil = 2;
                    VentanaPrincipal ventanaAdmin = new VentanaPrincipal();
                    ventanaAdmin.Show();
                }
            }
            else
            {
                MessageBox.Show("El usuario o contraseña introducido no es correcto"); //En el caso de no acceder
            }
        }

    }
}
