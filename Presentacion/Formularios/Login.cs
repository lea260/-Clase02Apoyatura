using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelo;
using Presentacion.Helpers;

namespace Presentacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtuser.Text;
            string password = txtpassword.Text;
            //Usuario usr = new Negocio.Modelo.Usuario();
            Usuario usr = new Usuario();
            usr.Ingresar(nombreUsuario, password, Variables.programa);
            bool ingreso = usr.Ingresar(nombreUsuario, password, Variables.programa);
            if (checkrecordar.Checked == true)
            {
                Properties.Settings.Default.UserName = txtuser.Text;
                Properties.Settings.Default.password = txtpassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                /*Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();*/
            }
            Principal p = new Principal();
            p.Show();
            
            //guardo los datos
            

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Chat chat1 = new Chat(1, 1);
            Chat chat2 = new Chat(3, 1);
            chat1.Show();
            chat2.Show();
        }
    }
}
