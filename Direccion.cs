using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    public class Direccion
    {
        #region propiedades y atributos
        private string calle;
        private byte numeroDePuerta;
        private string ciudadDeResidencia;

        public string Calle
        {
            get
            {
                return calle;
            }

            set
            {
                calle = value;
            }
        }

        public byte NumeroDePuerta
        {
            get
            {
                return numeroDePuerta;
            }

            set
            {
                numeroDePuerta = value;
            }
        }

        public string CiudadDeResidencia
        {
            get
            {
                return ciudadDeResidencia;
            }

            set
            {
                ciudadDeResidencia = value;
            }
        }
        #endregion
    }
}
