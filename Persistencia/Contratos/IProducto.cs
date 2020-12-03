using Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Contratos
{
    interface IProducto
    {
        //pre: las condiciones de los parametro, consultas debe ser distinto
        //todo lo que debe 
        //post: retorna, detalle el largo debe ser menor de 45.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>lista de productos</returns>
        List<ProductoEntidad> ListarProductos(string consulta = null);

        void AgregarProducto(ProductoEntidad entidad);

        void EditarProducto(ProductoEntidad entidad);

        void EliminarProducto(long idproductos);
        int Nada(int param);
    
    }
}
