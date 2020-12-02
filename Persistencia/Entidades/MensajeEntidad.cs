using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Entidades
{
    public class MensajeEntidad
    {
        private string nombre;
        private string mensaje;
        private string mensaje2;

        public MensajeEntidad(string nombre, string mensaje)
        {
            if (this.nombre.Length > 20)
            {
                this.Nombre = nombre.Substring(0,20);//base maximo varchar 20
            }
            else
            {
                this.Nombre = nombre;
            }
            
            this.Mensaje = mensaje;
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Mensaje2 { get => mensaje2; set => mensaje2 = value; }
    }
}
