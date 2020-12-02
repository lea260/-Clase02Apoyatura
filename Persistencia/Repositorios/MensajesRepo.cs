using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Persistencia.Entidades;
using Persistencia.Contratos;


namespace Persistencia.Repositorios
{
    public class MensajesRepo : IObtenerMensajes
    {
        /*select nombre, mensaje from chat
        inner join usuarios on usuarios.id = chat.id_usuario
        where chat.id_diag=1;*/
        public int hola()
        {
            return 5;
        }
        public List<MensajeEntidad> GetMensajes(long diag)
        {
            
            List<MensajeEntidad> list = new List<MensajeEntidad>();
            MySqlDataReader reader = null;
            MySqlConnection conexion = null;
            try
            {
                
                conexion = ConexionDB.GetConexion();
                conexion.Open();                    
                string sql;
                sql = @"select nombre, mensaje from chat
                        inner join usuarios on usuarios.id = chat.id_usuario
                        where chat.id_diag=?diag";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                //comando.Parameters.AddWithValue("@diag", diag);
                comando.Parameters.Add("?diag", MySqlDbType.Int64).Value= diag;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string nombre = (reader[0] != DBNull.Value) ? reader.GetString(0) : "";
                        string mensaje = (reader[1] != DBNull.Value) ? reader.GetString(1) : "";
                        MensajeEntidad dataMensaje = new MensajeEntidad(nombre, mensaje);
                        list.Add(dataMensaje);
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
                    conexion.Dispose();
                }
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }
            return list;            
        }

        public void Agregar(long idDiagnostico, long idUsuario, string mensaje)
        {
            //hago el insert
            //throw new NotImplementedException();
            MySqlConnection conexion = null;
            try
            {
                conexion = ConexionDB.GetConexion();
                conexion.Open();
                string sql = @"insert into chat (id_usuario, id_diag ,mensaje) 
                                values (?idusuario,?idiag,?mensaje)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("?idusuario", MySqlDbType.Int64).Value = idUsuario;
                comando.Parameters.Add("?idiag", MySqlDbType.Int64).Value = idDiagnostico;                
                comando.Parameters.Add("?mensaje", MySqlDbType.String).Value = mensaje;                
                comando.ExecuteNonQuery();
                //obtiene el ultimo id ingresado
                long id = comando.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                string mensajeError = ex.ToString();
                Console.WriteLine("hola" + mensajeError);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
        }
    }
}
