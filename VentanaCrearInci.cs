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
    public partial class VentanaCrearInci : Form
    {
        public VentanaCrearInci()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        DataTable incidencias = new DataTable();
        string user = VentanaLogIn.usuario;

        private void crearIncidencia()
        {
            panelCrearInci.Show();
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
        private void sumarIncidencia()
        {
            incidencias = conexion.getDatosPorAplicacion(eligeAplicacion.SelectedItem.ToString()); //Se saca el numero de incidencias de la aplicación
            string numInciStr = incidencias.Rows[0]["incidencias"].ToString();
            int numInci = Int32.Parse(numInciStr);
            numInci++; //Se suma 1 incidencia creada

            if (conexion.getActualizarNumInci(numInci, eligeAplicacion.SelectedItem.ToString()))
            {
                Console.WriteLine("Numero de incidencias actualizado");
            }
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            crearIncidencia();
            sumarIncidencia();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            VentanaCrearInci v1 = new VentanaCrearInci();
            v1.Hide();
        }
    }
}
