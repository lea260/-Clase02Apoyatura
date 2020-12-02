using System;
using System.Collections.Generic;
using System.Text;
using Persistencia.Entidades;
using Negocio.Objetos;
using System.IO;
using Persistencia.Repositorios;

namespace Negocio.Modelo
{

    public class Producto
    {
        public string elimina()
        {
            return "dfdfdf";
        }
        public void AgregarProducto(DataProducto producto)
        {            
            //transformo el DataProducto en DataEntidad
            ProductoEntidad entidad = new ProductoEntidad();
            entidad.Codigo = producto.Codigo;
            entidad.Descripcion = producto.Descripcion;
            entidad.Precio = producto.Precio;
            entidad.Fecha = producto.Fecha;
            //llamo a la persistencia
            ProductosRepo repProdu = new ProductosRepo();
            repProdu.AgregarProducto(entidad);

        }
        public void EditarProducto(DataProducto producto)
        {
            //transformo el DataProducto en DataEntidad
            ProductoEntidad entidad = new ProductoEntidad();
            entidad.Id_productos = producto.Id_productos;
            entidad.Codigo = producto.Codigo;
            entidad.Descripcion = producto.Descripcion;
            entidad.Precio = producto.Precio;
            entidad.Fecha = producto.Fecha;
            //llamo a la persistencia
            ProductosRepo repProdu = new ProductosRepo();
            repProdu.EditarProducto(entidad);
        }

        public void EliminarProducto(long idproducto)
        {
            ProductosRepo repProdu = new ProductosRepo();
            repProdu.EliminarProducto(idproducto);
        }
    }
}
