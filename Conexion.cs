using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace InciGest
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = InciGest; Uid = root; Pwd =; Port = 3306");
        }

        //Para iniciar sesión
        public Boolean iniciarSesion(String DNI, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM usuario WHERE DNI = @DNI ", conexion); //Se verifica que el dni de la bbdd coincide con el introducido
                consulta.Parameters.AddWithValue("@DNI", DNI);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string passwordConHash = resultado.GetString("password"); //Se pasa la contraseña de la bbdd a string

                    if (BCrypt.Net.BCrypt.Verify(password, passwordConHash)) //Se verifica que la contraseña introducida y la encriptada son la misma
                    {
                        return true;
                    }

                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false; //No accede
            }
        }

        public DataTable getDatosPorUser(String usuario) //Datos de las incidencias por usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM incidencias WHERE dni_usuarioAsignado = @usuario", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getDatosInci(String usuario, String codInci) //Datos de las incidencias por usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM incidencias WHERE dni_usuarioAsignado = @usuario AND id_incidencia = @codInci", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@codInci", codInci);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getDatosPorGrupo(String grupo) //Datos de las incidencias por grupo
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM incidencias WHERE aplicacion = @grupo", conexion);
                consulta.Parameters.AddWithValue("@grupo", grupo);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getDatosPerfil(String user) //Datos del perfil logeado
        {
            try
            {
                conexion.Close() ; //Cierra la conexión anterior
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE DNI = @user", conexion);
                consulta.Parameters.AddWithValue("@user", user);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable comprobarRegistro() //Para comprobar que no se repiten datos en la bbdd que son únicos de un usuario.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean editaUser(String DNI, String Nombre, String Apellido, String email) //Para editar el perfil de un usuario
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE usuario SET Nombre = @Nombre, Apellido = @Apellido, email = @email WHERE DNI = @DNI", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellido", Apellido);
                consulta.Parameters.AddWithValue("@email", email);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Boolean cambiaPassword(String DNI, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE usuario SET password = @password WHERE DNI = @DNI", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@password", password);
                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Boolean insertaIncidencia(String titulo, String prioridad, String ip, String grupo, String aplicacion, String descripcion, String dniUsuario)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO incidencias (titulo, prioridad, ip_terminal, grupo_soporte, aplicacion, descripcion, dni_usuario, fecha) VALUES (@titulo, @prioridad, @ip_terminal, @grupo_soporte, @aplicacion, @descripcion, @dni_usuario, @fecha)", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@titulo", titulo);
                consulta.Parameters.AddWithValue("@prioridad", prioridad);
                consulta.Parameters.AddWithValue("@ip_terminal", ip);
                consulta.Parameters.AddWithValue("@grupo_soporte", grupo);
                consulta.Parameters.AddWithValue("@aplicacion", aplicacion);
                consulta.Parameters.AddWithValue("@descripcion", descripcion);
                consulta.Parameters.AddWithValue("@dni_usuario", dniUsuario);
                consulta.Parameters.AddWithValue("@fecha", DateTime.Now);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }

        public Boolean insertaUsuario(String nombre, String perfil, String apellido, String dni, String email, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuario (nombre, apellido, DNI, perfil, email, password) VALUES (@nombre, @apellido, @dni, @perfil, @email, @password)", conexion); //datos a introducir, se introducen los string en los campos de la bbdd.
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@DNI", dni);
                consulta.Parameters.AddWithValue("@perfil", perfil);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@password", password);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;

            }
        }
    }
    }
