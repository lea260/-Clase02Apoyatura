﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Persistencia.Repositorios
{
    public class ConexionDB
    {    
        //se puede llamar sin instanciar la clase.
        public static MySqlConnection GetConexion()
        {
            
            string cadenaConexion = "Database=proyecto01; Data Source=localhost; Port=3306; User Id=usuario1; Password=usuario1";
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                Console.WriteLine("something is ");
            }catch (MySqlException ex){
                string mensaje = ex.ToString();
                Console.WriteLine("something is "+ex.ToString());
            }
            
            return conexion;        
        } 
    }
}
