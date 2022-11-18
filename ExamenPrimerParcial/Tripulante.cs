using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
     class Tripulante
    {

        public string  nombre { get; set; }
        public int telefono { get; set; }
        public int cedula { get; set; }
        public int edad { get; set; }
        public string TiempoEnLaEmpresa { get; set; }
        public string sexo { get; set; }
        public  string Barco { get; set; }


        public Tripulante(string nombre, int telefono, int cedula, int edad, string TiempoEnLaEmpresa, string sexo, string barco)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cedula = cedula;
            this.edad = edad;
            this.TiempoEnLaEmpresa = TiempoEnLaEmpresa;
            this.sexo = sexo;
            this.Barco = barco;
        }

        public void sueldo()
        {



        }
         public virtual  void imprimiratributos()
        {
            Console.WriteLine("   Datos de la tripulacion   ");
            Console.WriteLine("---------------");
            Console.WriteLine("Cedula  :"+ cedula );
            Console.WriteLine( "Nombre " +nombre);
            Console.WriteLine("sexo :" + sexo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Telefono: "+telefono);
            Console.WriteLine("Tiempo en la empresa : " + TiempoEnLaEmpresa);

        }
            }
}
