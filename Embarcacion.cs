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

        public Embarcacion(int aCodigo,string aNombre,DateTime aFechaConstruccion,string aTipoDeMotor)
        {
            this.Codigo = aCodigo;
            this.FechaConstruccion = aFechaConstruccion;
            this.Nombre = aNombre;
            this.TipoDeMotor = aTipoDeMotor;
        }

        public static int ObtenerCodigo()
        {
            int codigo = 0;            
            codigo=EmpresaManager.Inst.Embarcacionlist.Count;
            codigo++;
            return codigo;
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
        public static string ObtenerTipoDeMotor()
        {
            string str = "";
            while (str.Length < 1)
            {
                Console.WriteLine("Ingrese tipo de motor: ");
                str = Console.ReadLine();
                if (str != "Integrado" && str!="Fuera de borda")
                {
                    str = "Otros";
                }
            }
            return str;
        }
        public static DateTime ObtenerFecha()
        {
            bool salir = false;
            string str = "";
            while(str.Length < 1 && salir==false)
            {
                Console.WriteLine("Ingrese fecha de construccion");
                str=Console.ReadLine();
                DateTime temp;
                if (DateTime.TryParse(str, out temp))
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error en el ingreso de la fecha");
                    str = "";
                    Console.ReadLine();
                }                
            }
            DateTime fecha = DateTime.Parse(str);
            return fecha;
        }
    }
}
