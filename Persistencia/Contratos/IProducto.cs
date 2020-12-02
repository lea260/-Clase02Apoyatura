using Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.Contratos
{
    interface IProducto
    {
        List<ProductoEntidad> ListarProductos(string consulta = null);

        void AgregarProducto(ProductoEntidad entidad);

        void EditarProducto(ProductoEntidad entidad);

        void EliminarProducto(long idproductos);
    }
}
