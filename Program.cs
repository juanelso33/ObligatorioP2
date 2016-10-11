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
            principal();

        }
        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Principal");
            Console.WriteLine("---------------");
            Console.WriteLine("1-Registro de mecanicos");
            Console.WriteLine("S-Salir");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion");
            return Console.ReadLine();


        }
        static string RegistroDeMecanico()
        {
            return "";
        }
        static string Salir()
        {
            return "";
        }
        static void principal()
        {
            string opcion = menuPrincipal();
            while (opcion.ToUpper().Trim() != "S")
            {
                if (opcion == "1")
                {

                }
            }
        }


        static string menuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Menu de control");
            Console.WriteLine("---------------");
            Console.WriteLine("1-Registro de mecanicos");
            Console.WriteLine("S-Salir");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion");
            return Console.ReadLine();
        }

        static void principal()
        {
            string opcion = menuPrincipal();
            while (opcion.ToUpper().Trim() != "S")
            {
                if (opcion == "1")
                {

                }
            }
        }






    }
}
