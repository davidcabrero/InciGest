using Guna.UI2.WinForms.Suite;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InciGest
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        DataTable incidencias = new DataTable();
        DataTable perfil = new DataTable();

        string user = VentanaLogIn.usuario;
        bool cambioPassword = false; //Para saber si edita información de perfil o cambio de contraseña
        public VentanaPrincipal()
        {
            InitializeComponent();
            establecerPerfil();
            elegirGrupo.SelectedIndex = 0;
            panelIncidencia.Hide();
            panelEditarPerfil.Hide();
            perfilUuario.LabelText = user;
            panelCrearInci.Hide();
            panelRegistroUsuario.Hide();
            textoArchivo.Hide();
        }

        public void establecerPerfil()
        {
            if (VentanaLogIn.tipoPerfil != 2) //La sección admin solo aparece si el usuario es administrador.
            {
                this.menuPrincipal.TabPages.Remove(this.adminTab);
                botonAsignar.Visible = false;
                elegirUsuario.Visible = false;
            }
            else
            {
                int numFilas = 0; //Sacar número de usuarios.
                incidencias = conexion.getDatosPorUsuarios();
                numFilas = incidencias.Rows.Count;

                for (int i = 0; i < numFilas; i++)
                {
                    string nombre = incidencias.Rows[i]["nombre"].ToString();
                    string apellido = incidencias.Rows[i]["apellido"].ToString();
                    string dni = incidencias.Rows[i]["DNI"].ToString();
                    elegirUsuario.Items.Add(dni);
                }
            }
        }

        private void mostrarIncidencias()
        {
            int numFilas = 0; //Sacar número de incidencias del ususario
            incidencias = conexion.getDatosPorUser(user);
            numFilas = incidencias.Rows.Count;

            for (int i = 0; i < numFilas; i++)
            {
                string codInci = incidencias.Rows[i]["id_incidencia"].ToString();
                string tituloInci = incidencias.Rows[i]["titulo"].ToString();
                string fechaInci = incidencias.Rows[i]["fecha"].ToString();
                tablaIncidencias.Rows.Add(new Object[] { codInci, tituloInci, fechaInci });
            }
        }

        private void tablaIncidencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int fila = e.RowIndex;
                String codInci1 = tablaIncidencias.Rows[e.RowIndex].Cells[0].Value.ToString();
                int codInci = Int32.Parse(codInci1);
                Console.WriteLine(codInci);

                incidencias = conexion.getDatosInci(codInci);

                //Mostrar componentes de la incidencia
                elegirGrupo.Hide();
                tablaIncidencias.Hide();
                grupoLabel.Hide();
                panelIncidencia.Show();
                //Establecer datos de la incidencia pulsada

                tituloInci.Text = incidencias.Rows[0]["titulo"].ToString();
                descripcionInci.Text = incidencias.Rows[0]["descripcion"].ToString();
                aplicacion.Text = incidencias.Rows[0]["aplicacion"].ToString();
                prioridad.Text = incidencias.Rows[0]["prioridad"].ToString();
                fechaInci.Text = incidencias.Rows[0]["fecha"].ToString();
                idInci.Text = incidencias.Rows[0]["id_incidencia"].ToString();
                userAsignado.Text = incidencias.Rows[0]["dni_usuarioAsignado"].ToString();
            }
        }

        private void elegirGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaIncidencias.Rows.Clear();

            if (elegirGrupo.SelectedIndex != 0)
            {
                string grupo = elegirGrupo.SelectedItem.ToString();
                int numFilas = 0; //Sacar número de incidencias del ususario
                incidencias = conexion.getDatosPorGrupo(grupo);
                numFilas = incidencias.Rows.Count;

                for (int i = 0; i < numFilas; i++)
                {
                    string codInci = incidencias.Rows[i]["id_incidencia"].ToString();
                    string tituloInci = incidencias.Rows[i]["titulo"].ToString();
                    string fechaInci = incidencias.Rows[i]["fecha"].ToString();
                    string prioridad = incidencias.Rows[i]["fecha"].ToString();
                    tablaIncidencias.Rows.Add(new Object[] { codInci, tituloInci, fechaInci, prioridad });
                }
            }
            else
            {
                mostrarIncidencias();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            grupoLabel.Show();
            panelIncidencia.Hide();

            elegirGrupo.Show();
            tablaIncidencias.Show();
            //elegirGrupo.SelectedIndex = 0;
        }

        private void menuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuPrincipal.SelectedTab.Text.Equals("Cerrar Sesión")) //Cierra sesión
            {
                VentanaLogIn.usuario = "";
                this.Hide();
                VentanaLogIn vlog = new VentanaLogIn();
                vlog.Show();
            }
            if (menuPrincipal.SelectedIndex == 2) //Muestra perfil del usuario
            {
                incidencias = conexion.getDatosPerfil(user);
                String nombre = incidencias.Rows[0]["nombre"].ToString();
                String apellido = incidencias.Rows[0]["apellido"].ToString();
                labelPerfil.Text = "Bienvenido/a, " + nombre + " " + apellido;
            }
        }

        private void botonEditarPerfil_Click(object sender, EventArgs e)
        {
            //Establecer ventana
            nuevaPasswordLabel.Visible = false;
            editPassword.Visible = false;
            labelNombre.Visible = true;
            labelEmail.Visible = true;
            labelApellido.Visible = true;
            nombreText.Visible = true;
            emailText.Visible = true;
            apellidoText.Visible = true;

            cambioPassword = false;
            panelEditarPerfil.Show();
            perfilEditado.LabelText = user;

            //Muestra datos actuales
            incidencias = conexion.getDatosPerfil(user);
            nombreText.Text = incidencias.Rows[0]["nombre"].ToString();
            apellidoText.Text = incidencias.Rows[0]["apellido"].ToString();
            emailText.Text = incidencias.Rows[0]["email"].ToString();
        }

        private void botonGuardarPerfil_Click(object sender, EventArgs e)
        {
            if (!cambioPassword) //Editar perfil
            {
                incidencias = conexion.comprobarRegistro();
                perfil = conexion.getDatosPerfil(user);
                if ((!emailText.Text.Equals(incidencias.Rows[0]["email"].ToString())) || emailText.Text.Equals(perfil.Rows[0]["email"].ToString())) //Siempre que el email no esté cogida ya (Excepto el suyo propio).
                {
                    if (conexion.editaUser(user, nombreText.Text, apellidoText.Text, emailText.Text))
                    {
                        MessageBox.Show("Se han guardado sus datos");
                        panelEditarPerfil.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("El email introducido ya se encuentra registrado. Intruce otro");
                }
            }
            else //Cambio de contraseña
            {
                //Se encripta la contraseña en la bbdd.
                String textoPassword = editPassword.Text;
                string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
                if (conexion.cambiaPassword(user, myHash))
                {
                    MessageBox.Show("Se ha cambiado la contraseña");
                    panelEditarPerfil.Hide();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void botonCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEditarPerfil.Hide();
        }

        private void botonCambiarPassword_Click(object sender, EventArgs e)
        {
            nuevaPasswordLabel.Visible = true;
            editPassword.Visible = true;
            editPassword.PasswordChar = '·';

            labelNombre.Visible = false;
            labelEmail.Visible = false;
            labelApellido.Visible = false;
            nombreText.Visible = false;
            emailText.Visible = false;
            apellidoText.Visible = false;

            cambioPassword = true;
            panelEditarPerfil.Show();
            perfilEditado.LabelText = user;
        }

        private void crearIncidencia()
        {
            panelCrearInci.Show();
            panelRegistroUsuario.BringToFront();
            if (conexion.insertaIncidencia(tituloText.Text, eligePrioridad.SelectedItem.ToString(), ipText.Text, eligeGrupo.SelectedItem.ToString(), eligeAplicacion.SelectedItem.ToString(), descripcionText.Text, user))
            {
                MessageBox.Show("Incidencia Añadida"); //Se añade la inci
                panelCrearInci.Hide();
            }
            else
            {
                MessageBox.Show("Error"); //Fallo
            }
        }

        private void botonCrearInci_Click(object sender, EventArgs e)
        {
            panelCrearInci.Show();
            panelCrearInci.BringToFront();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            panelCrearInci.Hide();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            crearIncidencia();
        }

        private void botonEditarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void botonAdministrarInci_Click(object sender, EventArgs e)
        {

        }

        private void botonVerEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void botonRegistroUsuario_Click(object sender, EventArgs e)
        {
            panelRegistroUsuario.Show();
            panelRegistroUsuario.BringToFront();
        }

        private void CancelarNewUser_Click(object sender, EventArgs e)
        {
            panelRegistroUsuario.Hide();
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

            String textoPassword = editPassword.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());

            if ((!emailNuevo.Text.Equals(incidencias.Rows[0]["email"].ToString())) || (!dniNuevo.Text.Equals(incidencias.Rows[0]["DNI"].ToString()))) //Siempre que el email y el dni no estén cogidos ya.
            {
                if (conexion.insertaUsuario(nombreNuevo.Text, perfil, apellidoNuevo.Text, dniNuevo.Text, emailNuevo.Text, myHash))
                {
                    MessageBox.Show("Usuario Registrado"); //Se añade el usuario
                    panelRegistroUsuario.Hide();
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

        private void botonAsignar_Click(object sender, EventArgs e)
        {
            int codInci = Int32.Parse(idInci.Text);
            if (conexion.asignarInci(elegirUsuario.SelectedItem.ToString(), codInci))
            {
                MessageBox.Show("Se ha asignado la incidencia");
                panelEditarPerfil.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void abrirAnalizador_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Incigest\Utilidades\AnalizaLog.exe");
        }
    }
}
