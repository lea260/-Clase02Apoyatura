using System;
using System.Collections.Generic;
using System.Text;
using Persistencia.Contratos;
using MySql.Data.MySqlClient;
using Persistencia.Entidades;
using Persistencia.Encriptar;

namespace Persistencia.Repositorios
{
    public class UsuarioRepo : IUsuarioRepo
    {
        public bool Ingresar(string nombreUsuario, string password, string programa)
        {
            string passEncriptado = Encriptar.Encriptar.sha256(password);//1234
            //03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4
            int largo = passEncriptado.Length;
            bool ingreso=false;
            List<ProductoEntidad> list = new List<ProductoEntidad>();
            MySqlConnection conexion = null;
            try
            {
                MySqlDataReader reader = null;
                conexion = ConexionDB.GetConexion();
                conexion.Open();                
                string sql = "SELECT nombre, pwd,rol FROM usuarios where nombre=@nombre";                
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {                   
                        string id = (reader[0] != DBNull.Value) ? reader.GetString(1) : "";
                        string pwdbase = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        string rolbase = (reader[2] != DBNull.Value) ? reader.GetString(2) : "";
                        if (pwdbase == passEncriptado && 
                            rolbase == programa)
                        {
                            ingreso = true;
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                string mensaje = ex.ToString();
                Console.WriteLine("hola" + mensaje);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            return ingreso;
        }//end Ingresar      

        public void Prueba(string password, string programa)
        {
            throw new NotImplementedException();
        }
    }
}
