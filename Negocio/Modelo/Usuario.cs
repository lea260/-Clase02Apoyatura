using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelo
{
    /// <summary>
    /// la capa de modelo se encarga de llamar realizar los calculos de la logica.
    /// por ejemplo
    /// </summary>
    public class Usuario
    {
        public void AgregarUsuario(string nombreUsuario, string password, string programa)
        {

            throw new NotImplementedException();

        }

        public bool Ingresar(string nombreUsuario, string password, string programa)
        {
            bool ingreso = false;
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            ingreso = usuarioRepo.Ingresar(nombreUsuario, password, programa);
            return ingreso;
            //throw new NotImplementedException();
        }
    }
}
