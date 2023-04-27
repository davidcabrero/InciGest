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
    public partial class VentanaAgregarUser : Form
    {
        Conexion conexion = new Conexion();
        DataTable incidencias = new DataTable();

        public VentanaAgregarUser()
        {
            InitializeComponent();
            passwordNuevo.PasswordChar = '·';
        }

        private void GuardarNewUser_Click(object sender, EventArgs e)
        {
            incidencias = conexion.comprobarRegistro();

            int perfil = 0;
            if (perfilNuevo.SelectedItem.ToString().Equals("Desarrollador"))
            {
                perfil = 1;
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            if (perfilNuevo.SelectedItem.ToString().Equals("Administrador"))
            {
                perfil = 2;
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }

            String textoPassword = passwordNuevo.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());

            if ((!emailNuevo.Text.Equals(incidencias.Rows[0]["email"].ToString())) || (!dniNuevo.Text.Equals(incidencias.Rows[0]["DNI"].ToString()))) //Siempre que el email y el dni no estén cogidos ya.
            {
                if (conexion.insertaUsuario(nombreNuevo.Text, perfil, apellidoNuevo.Text, dniNuevo.Text, emailNuevo.Text, myHash))
                {
                    MessageBox.Show("Usuario Registrado"); //Se añade el usuario
                    VentanaAgregarUser v1 = new VentanaAgregarUser();
                    v1.Dispose();
                }
                else
                {
                    MessageBox.Show("Error"); //Fallo
                }
            }
            else
            {
                MessageBox.Show("El email o DNI introducido ya se encuentra registrado. Intruce otro");
            }
        }

        private void CancelarNewUser_Click(object sender, EventArgs e)
        {
            VentanaAgregarUser v1 = new VentanaAgregarUser();
            v1.Hide();
        }
    }
}
