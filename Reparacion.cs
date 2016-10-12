using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    class Reparacion
    {
        private DateTime fechaDeIngreso;
        private DateTime fechaDeEntrega;
        private DateTime fechaDeFinalizacion;
        private Embarcacion embarcacionAReparar;
        List<Mecanico> listaMecanicos;
        List<Materiales> listaMateriales;

        public DateTime FechaDeIngreso
        {
            get
            {
                return fechaDeIngreso;
            }

            set
            {
                fechaDeIngreso = value;
            }
        }

        public DateTime FechaDeEntrega
        {
            get
            {
                return fechaDeEntrega;
            }

            set
            {
                fechaDeEntrega = value;
            }
        }

        public DateTime FechaDeFinalizacion
        {
            get
            {
                return fechaDeFinalizacion;
            }

            set
            {
                fechaDeFinalizacion = value;
            }
        }

        public Embarcacion EmbarcacionAReparar
        {
            get
            {
                return embarcacionAReparar;
            }

            set
            {
                embarcacionAReparar = value;
            }
        }

        public List<Mecanico> ListaMecanicos
        {
            get
            {
                return listaMecanicos;
            }

            set
            {
                listaMecanicos = value;
            }
        }

        public List<Materiales> ListaMateriales
        {
            get
            {
                return listaMateriales;
            }

            set
            {
                listaMateriales = value;
            }
        }
    }
}
