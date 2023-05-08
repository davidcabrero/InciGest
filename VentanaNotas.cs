using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class VentanaNotas : Form
    {
        public VentanaNotas()
        {
            InitializeComponent();
            mostrarMensajes();
        }

        Conexion conexion = new Conexion();
        DataTable mensajes = new DataTable();
        string user = VentanaLogIn.usuario;

        private void mostrarMensajes()
        {
            tablaMensajes.Rows.Clear();
            int numFilas = 0; //Sacar número de mensajes del ususario
            mensajes = conexion.getMensajes(VentanaPrincipal.codInci);
            numFilas = mensajes.Rows.Count;

            for (int i = 0; i < numFilas; i++)
            {
                string texto = mensajes.Rows[i]["mensaje"].ToString();
                string usuario = mensajes.Rows[i]["usuario"].ToString() + ": ";

                string mensajeTexto = usuario + texto;

                tablaMensajes.Rows.Add(new Object[] {mensajeTexto});
            }
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            if (conexion.enviaMensajeChat(user, textoMensaje.Text, VentanaPrincipal.codInci))
            {
                textoMensaje.Text = "";
                mostrarMensajes();
            }
        }
    }
}
