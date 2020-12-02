using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Objetos;


namespace Negocio.Servicios
{
    /// <summary>
    /// se encarga de llamanar a la capa de persistencia
    /// </summary>
    public class UsuarioServicio
    {
        public UsuarioServicio()
        {

        }
        public List<DataUsuario> obtenerUsuarios()
        {
            List<DataUsuario> lista= new List<DataUsuario> ();
            DataUsuario usuario1 = new DataUsuario();
            usuario1.Nombre = "juan";
            usuario1.Apellido = "perez";
            lista.Add(usuario1);
            DataUsuario usuario2 = new DataUsuario();
            usuario2.Nombre = "maria";
            usuario2.Apellido = "martinez";
            lista.Add(usuario2);
            return lista;
        }
    }
}
