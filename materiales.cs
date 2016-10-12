using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    public abstract class Materiales
    {
        private string nombre;
        private int costo;
        private double peso;

        public virtual string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public virtual int Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public virtual double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }
    }
}
