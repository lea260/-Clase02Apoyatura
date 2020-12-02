using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Net.Sockets;
using System.Text;
using System.Transactions;

namespace Negocio.Objetos
{
    public class DataSintoma
    {
        private long id;
        private string sintoma;
        private double coef;
        private double peligro;

        public DataSintoma(long id, string sintoma)
        {
            this.id = id;
            this.sintoma = sintoma;            
        }

        public DataSintoma(long id, string sintoma, double coef)
        {
            this.id = id;
            this.sintoma = sintoma;
            this.coef = coef;
        }
        public void hola()
        {
            DataSintoma sg = new DataSintoma(111,"hola");            
        }
        

        
        public long Id { get => id; set => id = value; }
        public string Sintoma { get => sintoma; set => sintoma = value; }        
        public double Coef { get => coef; set => coef = value; }
        public double Peligro { get => peligro; private set => peligro = value; }
    }
}
