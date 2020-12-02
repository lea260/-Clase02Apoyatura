using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Objetos;
using Persistencia.Entidades;
using Persistencia.Repositorios;

namespace Negocio.Modelo
{
    public class Mensaje
    {
        public List<DataChat> ObtenerMensajes(long id)
        {
            List<DataChat> lista = new List<DataChat>();
            MensajesRepo chatRep = new MensajesRepo();                   
            List<MensajeEntidad> list2 = chatRep.GetMensajes(id);
            //List<> list2 = chatRep.
            ///recorrer la lista 
            foreach (MensajeEntidad mensaje in list2)
            {
                DataChat data = new DataChat(mensaje.Nombre, mensaje.Mensaje);                
                lista.Add(data);
            }
            return lista;
        }

        public static void Agregar(long idDiagnostico, long idUsuario, string mensaje)
        {
            MensajesRepo chatRep = new MensajesRepo();
            chatRep.Agregar(idDiagnostico, idUsuario, mensaje);
            //throw new NotImplementedException();
        }
    }
}

