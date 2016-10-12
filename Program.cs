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
            Menu();


            
        }
        static void Menu()
        {
            Console.Clear(); //limpia consola
            Console.WriteLine("Menu Principal");
            Console.WriteLine("---------------");
            Console.WriteLine("1-Registro de mecanicos");
            Console.WriteLine("S-Salir");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion");


            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                RegistroDeMecanico();
            }
            if (opcion.ToLower() == "s")
            {
                Console.WriteLine("Cerrando app");
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
            dir.AsignarDatos();
            
            Mecanico _mecanico = new Mecanico(nombre,telefono,numeroRegistro, valorJornal, capacitacionExtra, dir);

            //Una vez creado el mecanico y asignados sus datos correctos, el MANAGER es llamado y se ejecuta la funcion AddMecanico, que toma como parametro, mecanico.
            EmpresaManager.Inst.AddMecanico(_mecanico);


        }
      


        





    }
}
