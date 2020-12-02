using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Objetos
{
    public class DataProducto
    {
        private long id_productos;
        private string codigo;
        private string descripcion;
        private float precio;
        private DateTime fecha;


        public DataProducto()
        {
        }
       
        public long Id_productos { get => id_productos; set => id_productos = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
    
        
    
}
