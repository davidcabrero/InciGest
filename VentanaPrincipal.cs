using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        string user = VentanaLogIn.usuario;
        public VentanaPrincipal()
        {
            InitializeComponent();
            elegirGrupo.SelectedIndex = 0;
            panelIncidencia.Hide();
            panelEditarPerfil.Hide();
            perfilUuario.LabelText = user;
        }

        private void mostrarIncidencias()
        {
            int numFilas = 0; //Sacar número de incidencias del ususario
            incidencias = conexion.getDatosPorUser(user);
            numFilas = incidencias.Rows.Count;

            for (int i = 0; i < numFilas; i++)
            {
                string tituloInci = incidencias.Rows[i]["titulo"].ToString();
                string fechaInci = incidencias.Rows[i]["fecha"].ToString();
                tablaIncidencias.Rows.Add(new Object[] { tituloInci, fechaInci });
            }
        }

        private void tablaIncidencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar componentes de la incidencia
            elegirGrupo.Hide();
            tablaIncidencias.Hide();
            grupoLabel.Hide();
            panelIncidencia.Show();
            //Establecer datos de la incidencia pulsada
            tituloInci.Text = incidencias.Rows[e.RowIndex]["titulo"].ToString();
            descripcionInci.Text = incidencias.Rows[e.RowIndex]["descripcion"].ToString();
            aplicacion.Text = incidencias.Rows[e.RowIndex]["aplicacion"].ToString();
            prioridad.Text = incidencias.Rows[e.RowIndex]["prioridad"].ToString();
            fechaInci.Text = incidencias.Rows[e.RowIndex]["fecha"].ToString();
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
                    string tituloInci = incidencias.Rows[i]["titulo"].ToString();
                    string fechaInci = incidencias.Rows[i]["fecha"].ToString();
                    tablaIncidencias.Rows.Add(new Object[] { tituloInci, fechaInci });
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
            if (menuPrincipal.SelectedIndex == 3) //Cierra sesión
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
            incidencias = conexion.comprobarRegistro();
            if ((emailText.Text) != (incidencias.Rows[0]["email"].ToString())) //Siempre que el email no esté cogida ya.
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

        private void botonCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEditarPerfil.Hide();
        }
    }
}
