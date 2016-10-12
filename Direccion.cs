using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Direccion
    {
        #region propiedades y atributos
        private string calle;
        private int numeroDePuerta;
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

        public int NumeroDePuerta
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



    public  void AsignarDatos()
    {
        string aCalle = "";
        int aNumPuerta=0;
        string aCiudad="";

        while (aCalle.Length < 1)
        {
            Console.WriteLine("Ingrese nombre de calle : ");
            aCalle = Console.ReadLine();

        }
        while (aCiudad.Length < 1)
        {
            Console.WriteLine("Ingrese nombre de ciudad: ");
            aCiudad = Console.ReadLine();

        }
        bool numGuardado = false;

        while (!numGuardado)
        {
            int j;
            Console.WriteLine("Ingrese numero de puerta : ");

            string str = Console.ReadLine();
            if (Int32.TryParse(str, out j))
                numGuardado = true;
            else
                numGuardado = false;

            aNumPuerta = j;

        }

        //Los atributos de la misma clase, se setean aqui.

        Calle = aCalle;
        NumeroDePuerta = aNumPuerta;
        CiudadDeResidencia = aCiudad;


    }
}



