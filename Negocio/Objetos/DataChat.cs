using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Objetos
{
    public class DataChat
    {   
        private string nombre;
        private string mensaje;

        public DataChat(string nombre, string mensaje)
        {
            this.Nombre = nombre;
            this.Mensaje = mensaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
