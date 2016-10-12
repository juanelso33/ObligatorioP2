using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    public class MaterialesImportados: Materiales
    {
        public override string Nombre
        {
            get
            {
                return base.Nombre;
            }

            set
            {
                base.Nombre = value;
            }
        }
        public override int Costo
        {
            get
            {
                return base.Costo;
            }

            set
            {
                base.Costo = value;
            }
        }
        public override double Peso
        {
            get
            {
                return base.Peso;
            }

            set
            {
                base.Peso = value;
            }
        }




    }
}
