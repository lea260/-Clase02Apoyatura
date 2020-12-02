using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Objetos;
using Negocio.Servicios;
using Negocio.Modelo;

///llamada a presentacion 


using Presentacion.ViewModels;


namespace Presentacion.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            UsuarioView usuarioView= new UsuarioView();
            List<DataUsuario> lista = usuarioView.listaUsuarios();
            dgv.DataSource = lista;
            /*foreach(DataUsuario usr in lista)
            {
                int n = dgv.Rows.Add(); //retorna el indice 
                dgv.Rows[n].Cells[0].Value = (string) usr.Nombre;
                dgv.Rows[n].Cells[1].Value = (string) usr.Apellido;                

            }*/

        }

        private void dataUsuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
