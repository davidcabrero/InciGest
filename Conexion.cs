using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
    }
    }
