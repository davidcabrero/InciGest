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
        public VentanaLogIn()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '•'; //No aparece la contraseña
        }

        internal static string usuario;


        private void botonLogIn_Click(object sender, EventArgs e)
        {
            if (conexion.iniciarSesion(userBox.Text, passwordBox.Text)) //Si el usuario y contraseña coinciden
            {
                this.Hide();
                usuario = userBox.Text;
                VentanaPrincipal ventanaprincipal = new VentanaPrincipal();

                ventanaprincipal.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña introducido no es correcto"); //En el caso de no acceder
            }
        }

    }
}
