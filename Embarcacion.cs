using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    public class Embarcacion
    {

        #region propiedades y atributos
        private int codigo; //autogenerado
        private string nombre;
        private DateTime fechaConstruccion;
        private string tipoDeMotor;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
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

        public DateTime FechaConstruccion
        {
            get
            {
                return fechaConstruccion;
            }

            set
            {
                fechaConstruccion = value;
            }
        }

        public string TipoDeMotor
        {
            get
            {
                return tipoDeMotor;
            }

            set
            {
                tipoDeMotor = value;
            }
        }
        #endregion
    
    }
}
