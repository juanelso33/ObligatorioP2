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
        private int telefono;
        private Direccion direccionMecanico;
        private int numeroRegistro;  //Codigo unico
        private int valorJornal;
        private bool capacitacionExtra;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public int NumeroRegistro { get { return numeroRegistro; } set { numeroRegistro = value; } }
        public int ValorJornal { get { return valorJornal; } set { valorJornal = value; } }
        public bool CapacitacionExtra { get { return capacitacionExtra; } set { capacitacionExtra = value; } }
        internal Direccion DireccionMecanico { get { return direccionMecanico; } set { direccionMecanico = value; } }


        #endregion

        public Mecanico(string aNombre, int aTelefono, int aNumeroDeRegistro, int aValorPorHora, bool aCapacitacionExtra, Direccion aDir)
        {
            Nombre = aNombre;
            Telefono = aTelefono;
            NumeroRegistro = aNumeroDeRegistro;
            ValorJornal = aValorPorHora;
            CapacitacionExtra = aCapacitacionExtra;
            DireccionMecanico = aDir;

        }


        public static string ObtenerNombre()
        {
            string str = "";
            while (str.Length < 1)
            {
                Console.WriteLine("Ingrese nombre: ");
                str = Console.ReadLine();

            }

            return str;
        }
        public static int ObtenerTelefono()
        {
            int telefono = 0;
            bool numGuardado = false;
            while (!numGuardado)
            {
                int j;
                Console.WriteLine("Ingrese telefono:");

                string str = Console.ReadLine();
                if (Int32.TryParse(str, out j))
                    numGuardado = true;
                else
                {
                    numGuardado = false;
                    Console.WriteLine("ERROR: Debe ser un numero");
                }
                telefono = j;
            }

            return telefono;
        }
        public static int ObtenerNumeroDeRegistro()
        {

            bool numGuardado = false;
            int numeroRegistro = 0;
            while (!numGuardado)
            {
                int j;
                Console.WriteLine("Ingrese numero de registro : ");

                string str = Console.ReadLine();
                if (Int32.TryParse(str, out j))
                    numGuardado = true;
                else
                {
                    numGuardado = false;
                    Console.WriteLine("ERROR: Debe ser un numero");
                }
                numeroRegistro = j;

                if (EmpresaManager.Inst.NumeroDeRegistroDuplicado(numeroRegistro))
                {
                    numGuardado = false;
                    Console.WriteLine("ERROR: El numero de registro ya existe, ingrese otro");
                }

            }

            return numeroRegistro;
        }

        public static int ObtenerValorDeJornal()
        {
            int valor = 0;
            bool numGuardado = false;
            while (!numGuardado)
            {
                int j;
                Console.WriteLine("Ingrese numero de valor : ");

                string str = Console.ReadLine();
                if (Int32.TryParse(str, out j))
                    numGuardado = true;
                else
                {
                    numGuardado = false;
                    Console.WriteLine("ERROR: El valor debe ser un numero");
                }
                valor = j;

            }

            return valor; 
        }

        public static bool ObtenerCapacitacionExtra()
        {
            bool capacitacionGuardada = false;
            bool capacitacionExtra = false;
            while (!capacitacionGuardada)
            {
                Console.WriteLine("Tiene una capacitacion extra? S/N : ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    capacitacionExtra = true;
                    capacitacionGuardada = true;
                }
                if (respuesta.ToLower() == "n")
                {
                    capacitacionExtra = false;
                    capacitacionGuardada = true;
                }
            }

            return capacitacionExtra;

        }
    }
}
