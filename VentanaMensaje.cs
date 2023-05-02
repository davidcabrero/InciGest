using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace InciGest
{
    public partial class VentanaMensaje : Form
    {
        String destinatario = VentanaPrincipal.usuarioEnvio;
        Conexion conexion = new Conexion();
        DataTable user = new DataTable();

        public VentanaMensaje()
        {
            InitializeComponent();
            mensajeLabel.Text = "Enviar mensaje a: " + destinatario;
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            user = conexion.getDatosPerfil(destinatario);
            string email = user.Rows[0]["email"].ToString();

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("incigestapp@gmail.com", "InciGest", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(email); //Correo destino
            correo.Subject = textoAsunto.Text; //Asunto
            correo.Body = textoMensaje.Text; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("incigestapp@gmail.com", "ilcbicjuektfarni");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);

            VentanaMensaje v1 = new VentanaMensaje();
            v1.Hide();
            MessageBox.Show("Correo enviado");
        }
    }
}
