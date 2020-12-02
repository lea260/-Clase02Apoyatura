using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Objetos;
using Negocio.Servicios; 

/// <summary>
/// se encarga de llamar a servicios, (de la capa modelo)
/// </summary>

namespace Presentacion.ViewModels
{
    public class UsuarioView
    {
        /// <summary>
        /// Negocio.Servicios.UsuarioServicio();
        /// </summary>
        /// 
        public UsuarioView()
        {

        }


        public UsuarioView(int integer)
        {

        }

        public List<DataUsuario> listaUsuarios()
        {
            UsuarioServicio servicio = new UsuarioServicio();
            List<DataUsuario> listaUsuarios = servicio.obtenerUsuarios();
            return listaUsuarios;
        }
    }
}
