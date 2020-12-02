using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Negocio.Objetos;

namespace Presentacion.Formularios
{
    public partial class Form2 : Form
    {
        
        private int v = 0;
        private int y = 20;      
        const int altura = 25;
        //lista sintomas de la enfermedad
        List<DataSintoma> list;
        //lista de todos los sintomas.
        List<DataSintoma> listasintomas;
        private int indice = -1;        
        public Form2()
        {
            InitializeComponent();
            Initcombox();
        }
        

        private void Initcombox()
        {
            
            DataSintoma ds1 = new DataSintoma(1, "tos", 40.0);            
            DataSintoma ds2 = new DataSintoma(2, "gripe", 30.0);                       
            DataSintoma ds3 = new DataSintoma(3, "malestar", 20.0);
            this.listasintomas = new List<DataSintoma>();            
            this.listasintomas.Add(ds1);
            this.listasintomas.Add(ds2);
            this.listasintomas.Add(ds3);
            this.list = new List<DataSintoma>();
            this.list.Add(ds1);            
            this.list.Add(ds2);            
            cmbsintomas.DataSource = this.listasintomas;
            cmbsintomas.ValueMember = "id";
            cmbsintomas.DisplayMember = "sintoma";
            //listo los sintomas;
            //listo los sintomas;
            ListarSintomas();

        }

        //eliminar por nombre
        private void EliminarSintomas()
        {
            this.grsintomas.Controls.Clear();
        }
    /*private void EliminarSintomas()
        {
            foreach (Control item in Controls)
            {
                List<string> laux = this.listasintomas.Select(o=> o.Id.ToString()).ToList();
                if (laux.Contains(item.Name))
                {
                    Controls.Remove(item);
                    item.Dispose();
                }
                List<string> laux2 = this.listasintomas.Select(o => o.Sintoma.ToString()).ToList();
                if (laux2.Contains(item.Name))
                {
                    Controls.Remove(item);
                    item.Dispose();
                }
                List<string> laux3 = this.listasintomas.Select(o => o.Coef.ToString()).ToList();
                if (laux3.Contains(item.Name))
                {
                    Controls.Remove(item);
                    item.Dispose();
                }

            }
        }*/

        private void ListarSintomas()
        {
            this.y = 20;
            foreach (var item in this.list)
            {

                Label lbl1 = new Label();
                lbl1.Width = 46;
                lbl1.Height = 17;
                lbl1.Location = new Point(40, y);
                lbl1.Text = item.Id.ToString();
                lbl1.Name = item.Id.ToString();
                
                Label lbl2 = new Label();
                lbl2.Width = 46;
                lbl2.Height = 17;
                lbl2.Location = new Point(143, y);
                lbl2.Text = item.Sintoma.ToString();
                lbl2.Name = item.Sintoma.ToString();
                lbl2.Tag = this.v;
                TextBox txt1 = new TextBox();
                txt1.Width = 100;
                txt1.Height = 22;
                txt1.Location = new Point(300, y);
                txt1.Text = item.Coef.ToString();
                txt1.Name = item.Coef.ToString();
                txt1.Tag = this.v;
                txt1.TextChanged += new EventHandler((sender1, e1) => Txt_TextChanged(sender1, e1, txt1.Text, item.Id));

                Button btn = new Button();
                btn.Location = new Point(460, y);
                btn.Text = "Eliminar"+item.Id.ToString();
                btn.Name = "Eliminar" + item.Id.ToString();
                btn.Tag = this.v;
                btn.Click += new EventHandler((sender1, e1) => btn_Click(sender1, e1, txt1.Text, item.Id));
                //btn.Click += new EventHandler((sender1, e1) => Txt_TextChanged(sender1, e1, txt1.Text, item.Id));

                //txt.TextChanged += Txt_TextChanged;
                this.grsintomas.Controls.Add(lbl1);
                this.grsintomas.Controls.Add(lbl2);
                this.grsintomas.Controls.Add(txt1);
                this.grsintomas.Controls.Add(btn);
                //cuadro de ponderacion
                //aumentar la y
                this.y += altura;
                this.v++;
            }
        }

        private void btn_Click(object sender1, EventArgs e1, string text, long id)
        {
            bool encontrado = false;
            int cantidad = this.list.Count;
            int iter = 0;
            int posicion = iter;
            while (!encontrado)
            {
                if (this.list[iter].Id == id)
                {
                    encontrado = true;                    
                    posicion = iter;
                }
                iter++;
            }
            this.list.RemoveAt(posicion);
            //borrar items
            EliminarSintomas();
            ListarSintomas();
        }

        private void Txt_TextChanged(object sender, EventArgs e, string coef, long id )
        {
            

            //throw new ArgumentOutOfRangeException("age", "All guests must be 21-years-old or older.");       
            //this.list.Find(x => x.Id == id);
            //sender.Text = "d";
            //TextBox txtb = (TextBox)sender;
            //txtb.Text = "1000";
            bool encontrado = false;
            int cantidad = this.list.Count;
            int iter = 0;
            List<DataSintoma> listaAux = this.list.Where(a => a.Id == id).ToList();
            while (!encontrado)
            {
                if (this.list[iter].Id==id)
                {

                    encontrado = true;
                    double heightVal = 0;
                    double.TryParse(coef, out heightVal);
                    if (heightVal != 0)
                    {
                        this.list[iter].Coef = heightVal;                       

                    }
                    else
                    {
                        //this.list[iter].Coef = double.Parse(coef);
                        TextBox txtb = (TextBox)sender;
                        txtb.Text = "0";

                    }
                    
                    
                }
                iter++;
            }            
            //this.list[indice].Coef = coef;

        }
        //agregar
        private void button1_Click(object sender, EventArgs e)
        {
            int indice = cmbsintomas.SelectedIndex;
            if (this.indice != -1)
            {
                /*while (!encontrado || this.listasintomas.Count<iter)
                {
                    if (this.listasintomas[iter].Id == this.indice)
                    {
                        encontrado = true;
                        posicion = iter;
                    }
                    iter++;
                }*/
                long id = this.listasintomas[indice].Id;
                DataSintoma sintomaData = this.listasintomas[indice];
                string sintoma = this.listasintomas[indice].Sintoma;
                MessageBox.Show("id:" + id + " el sintoma es: " + sintoma);
                List<DataSintoma> listaAux = this.list.Where(a => a.Id == id).ToList();
                if (listaAux.Count==0)
                {
                    this.list.Add(sintomaData);
                    EliminarSintomas();
                    ListarSintomas();
                }
                
                
            }


            //List<>
        }

        private void cmbsintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indice = cmbsintomas.SelectedIndex;          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            this.list.Clear();
            EliminarSintomas();
        }
    }
}
