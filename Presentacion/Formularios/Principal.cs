using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Properties.Settings.Default.UserName;
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                lblusuario.Text = Properties.Settings.Default.UserName;
            }
            //ace
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
