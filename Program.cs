using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamamos al MENU
            Principal();
            
        }
        static string Menu()
        {
            Console.Clear(); //limpia consola
            Console.WriteLine("Menu Principal");
            Console.WriteLine("---------------");
            Console.WriteLine("1-Registro de mecanicos");
            Console.WriteLine("2-Registro de embarcaciones");
            Console.WriteLine("3-Mostrar embarcaciones");
            Console.WriteLine("S-Salir");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion");
            return Console.ReadLine();
           
        }

        static void Principal()
        {
            string opcion = Menu();

            while (opcion.ToUpper().Trim() != "S")
            {
                if (opcion == "1")
                {
                    RegistroDeMecanico();
                    Console.WriteLine("Registro exitoso :)");
                    Console.ReadLine();
                }else if( opcion == "2")
                {
                    RegistroDeEmbarcacion();
                    Console.WriteLine("Registro exitoso :)");
                    Console.ReadLine();
                }else if (opcion == "3")
                {
                    mostrarEmbarcacion();
                }else
                {
                    Console.WriteLine("La opcion no es correcta");
                    Console.ReadLine();
                }
                opcion = Menu();
            }    
        }


        static void RegistroDeMecanico()
        {
            Console.Clear();

            string nombre = "";
            int telefono =0;
            int numeroRegistro = 0;
            int valorJornal = 0;
            bool capacitacionExtra = false;
            Console.WriteLine("Registro de Mecanico");
            Console.WriteLine("");

            nombre = Mecanico.ObtenerNombre();
            telefono = Mecanico.ObtenerTelefono();
            numeroRegistro = Mecanico.ObtenerNumeroDeRegistro();
            valorJornal = Mecanico.ObtenerValorDeJornal();
            capacitacionExtra = Mecanico.ObtenerCapacitacionExtra();
                        
            Direccion dir = new Direccion();
            Console.WriteLine();
            Console.WriteLine("Ingreso de direccion");
            Console.ReadKey();
            dir.AsignarDatos();
            
            Mecanico _mecanico = new Mecanico(nombre,telefono,numeroRegistro, valorJornal, capacitacionExtra, dir);

            //Una vez creado el mecanico y asignados sus datos correctos, el MANAGER es llamado y se ejecuta la funcion AddMecanico, que toma como parametro, mecanico.
            EmpresaManager.Inst.AddMecanico(_mecanico);


        }
        static void RegistroDeEmbarcacion()
        {
            Console.Clear();

            int codigo = 0;
            string nombre = "";
            DateTime fechaConstruccion = new DateTime();
            string tipoDeMotor = "";

            nombre = Embarcacion.ObtenerNombre();
            codigo = Embarcacion.ObtenerCodigo();
            fechaConstruccion = Embarcacion.ObtenerFecha();
            tipoDeMotor = Embarcacion.ObtenerTipoDeMotor();

            Embarcacion _Embarcacion = new Embarcacion(codigo, nombre, fechaConstruccion, tipoDeMotor);
            EmpresaManager.Inst.AddEmbarcacion(_Embarcacion);
        }

        static void mostrarEmbarcacion()
        {
            if (EmpresaManager.Inst.Embarcacionlist.Count > 0)
            {
                for(int i=0;i<EmpresaManager.Inst.Embarcacionlist.Count;i++)
                {
                    Console.WriteLine("Embarcacion numero: "+ EmpresaManager.Inst.Embarcacionlist[i].Codigo+ "  Nombre: "+ EmpresaManager.Inst.Embarcacionlist[i].Nombre + "   Fecha de construccion: "+ EmpresaManager.Inst.Embarcacionlist[i].FechaConstruccion+ "   Tipo de motor: "+ EmpresaManager.Inst.Embarcacionlist[i].TipoDeMotor);
                    
                }
            }else
            {
                Console.WriteLine("No hay embarcaciones creadas");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

    }
}
