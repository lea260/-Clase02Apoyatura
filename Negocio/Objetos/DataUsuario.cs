using System;
using System.Collections.Generic;
using System.Text;


namespace Negocio.Objetos
{
    /// <summary>
    /// constiyen los objetos de datos, 
    /// </summary>
    public class DataUsuario
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public DataUsuario()
        {
            
           
        }

        public string NombreCompleto()   // property
        {
            string fname = this.Nombre + this.Apellido;
            return fname; 
        }

        /// <summary>
        /// permite datau = new DataUsuario()
        /// datu.Nombre = "juan";
        /// 
        /// </summary>
        /// 
        
        
    }
}
