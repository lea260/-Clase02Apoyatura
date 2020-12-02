using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Entidades
{
    public class ProductoEntidad
    {
        private long id_productos;        
        private string codigo;
        private string descripcion;
        private float precio;
        private DateTime fecha;
        //private readonly static ProductoEntidad _instance = new ProductoEntidad();
        //ProductoEntidad p = new ProductoEntidad();

        public ProductoEntidad()
        {

        }
        
        
        //public long Id_productos { get => id_productos; set => id_productos = value; }
        public long Id_productos { get => id_productos; set => id_productos = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        
    }
}
