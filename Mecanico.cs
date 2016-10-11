using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    public class Mecanico
    {
        #region propiedades y atributos
        private string nombre;
        private string telefono;
        private Direccion direccionMecanico;
        private int numeroRegistro;  //Codigo unico
        private int valorJornal;
        private bool capacitacionExtra;
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

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int NumeroRegistro
        {
            get
            {
                return numeroRegistro;
            }

            set
            {
                numeroRegistro = value;
            }
        }

        public int ValorJornal
        {
            get
            {
                return valorJornal;
            }

            set
            {
                valorJornal = value;
            }
        }

        public bool CapacitacionExtra
        {
            get
            {
                return capacitacionExtra;
            }

            set
            {
                capacitacionExtra = value;
            }
        }

        internal Direccion DireccionMecanico
        {
            get
            {
                return direccionMecanico;
            }

            set
            {
                direccionMecanico = value;
            }
        }


        #endregion

        List<Mecanico> listaMecanicos = new List<Mecanico>();

        public Mecanico altaDeMecanicos(string unNombre, string unTelefono, Direccion unaDireccion, int unNumeroRegistro, int unValorJornal, bool unaCapacitacionExtra)//da de alta un nuevo mecanico
        {
            Mecanico nuevoMecanico = new Mecanico();
            nuevoMecanico.Nombre = unNombre;
            nuevoMecanico.Telefono = unTelefono;            
            nuevoMecanico.DireccionMecanico = unaDireccion;


            nuevoMecanico.NumeroRegistro = unNumeroRegistro;
            nuevoMecanico.ValorJornal = ValorJornal;
            nuevoMecanico.CapacitacionExtra = unaCapacitacionExtra;
            return nuevoMecanico;
        }

        public bool validarDatosMecanico(string nombre, string telefono, int numeroRegistro, int valor)
        {
            int n;
            bool todoOk = true;
            if (nombre.Length <1)
            {
                todoOk = false;
                Console.WriteLine("El nombre no puede estar vacio");
            }
            if (telefono.Length < 1)
            {
                todoOk = false;
                Console.WriteLine("El telefono no puede estar vacio");
            }else if (telefono.Length < 6 && AreThereOnlyNumbersInString(telefono))
            {

            } 


            return todoOk;
        }


        bool AreThereOnlyNumbersInString(string str)
        {

            int j;
            if (Int32.TryParse(str, out j))
                return true;
            else
                return false;
        }


        void coso()
        {
            


        }

    }
}
