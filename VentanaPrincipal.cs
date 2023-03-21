using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            elegirGrupo.Hide();
            tablaIncidencias.Hide();
            panelIncidencia.Show();
            string seleccion = tablaIncidencias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            tituloInci.Text = seleccion;
            descripcionInci.Text = incidencias.Rows[e.RowIndex]["descripcion"].ToString();
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
    }
}
